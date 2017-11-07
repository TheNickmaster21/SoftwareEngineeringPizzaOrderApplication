using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringPizzaOrderApplication
{
    public partial class MenuForm : Form
    {
        private MainForm mainForm;

        private CustomerProxy customerProxy = new CustomerProxy();
        private OrderProxy orderProxy = new OrderProxy();

        public MenuForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            this.FormClosed += this.closed;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closed(object sender, EventArgs e)
        {
            mainForm.Show();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            Order order = new Order();

            setCustomer(order);
            fillOrder(order);

            orderProxy.saveOrder(order);
        }

        private void setCustomer(Order order)
        {
            Customer customer = customerProxy.getCustomer(this.phoneNumber.Text);
            if (customer == null)
            {
                MessageBox.Show("Customer with the given phone number was not found!");
                return;
            }
            order.customer = customer.phone_number;
        }

        private void fillOrder(Order order)
        {
            decimal price = 0;
            order.OrderItems = new List<OrderItem>();

            foreach (string pizza in this.PizzaListBox.Items)
            {
                price += decimal.Parse(pizza.Substring(1, pizza.IndexOf('-')));

                OrderItem orderItem = new OrderItem();
                orderItem.quantity = 1;
                orderItem.item = pizza.Substring(pizza.IndexOf('-'), pizza.Length - 1);

                order.OrderItems.Add(orderItem);
            }
        }

        private void RegisterNewCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerInfoInputForm customerInfoInputForm = new CustomerInfoInputForm(this);
            customerInfoInputForm.Show();
            this.Hide();
        }

        public void giveCustomerPhoneNumber(string phoneNumber)
        {
            this.phoneNumber.Text = phoneNumber;
        }

        private void RemovePizzaButton_Click(object sender, EventArgs e)
        {
            if (this.PizzaListBox.SelectedIndex > -1)
            {
                this.PizzaListBox.Items.RemoveAt(this.PizzaListBox.SelectedIndex);
            }
        }

        private void AddPizzaButton_Click(object sender, EventArgs e)
        {
            PizzaForm pizzaForm = new PizzaForm(this);
            pizzaForm.Show();
            this.Hide();
        }

        public void addPizza(string pizza)
        {
            this.PizzaListBox.Items.Add(pizza);
        }
    }
}
