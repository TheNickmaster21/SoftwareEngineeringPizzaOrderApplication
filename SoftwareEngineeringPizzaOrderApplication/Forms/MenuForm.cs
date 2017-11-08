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

        private Boolean overrideShowingMainForm = false;

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
            if (!overrideShowingMainForm)
            {
                mainForm.Show();
            }
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.time = DateTime.Now;

            Customer customer = customerProxy.getCustomer(this.phoneNumber.Text);
            if (customer == null)
            {
                MessageBox.Show("Customer with the given phone number was not found!");
                return;
            }
            order.customer = customer.phone_number;

            fillOrder(order);

            try
            {
                orderProxy.saveOrder(order);

                OrderReceiptView orderReceiptView = new OrderReceiptView(mainForm, customer, order);
                orderReceiptView.Show();
                overrideShowingMainForm = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillOrder(Order order)
        {
            decimal price = 0;
            order.OrderItems = new List<OrderItem>();

            foreach (string pizza in this.PizzaListBox.Items)
            {
                price += decimal.Parse(pizza.Substring(1, pizza.IndexOf('-') - 2));

                OrderItem orderItem = new OrderItem();
                orderItem.quantity = 1;
                orderItem.item = pizza.Substring(pizza.IndexOf('-') + 2, pizza.Length - pizza.IndexOf('-') - 2);

                order.OrderItems.Add(orderItem);
            }

            if (this.largeNumeric.Value > 0)
            {
                OrderItem orderItem = new OrderItem();
                orderItem.item = "Large Drink";
                orderItem.quantity = (int)this.largeNumeric.Value;
                price += (decimal)(2.19 * orderItem.quantity);
                order.OrderItems.Add(orderItem);
            }

            if (this.MediumNumeric.Value > 0)
            {
                OrderItem orderItem = new OrderItem();
                orderItem.item = "Medium Drink";
                orderItem.quantity = (int)this.MediumNumeric.Value;
                price += (decimal)(1.69 * orderItem.quantity);
                order.OrderItems.Add(orderItem);
            }

            if (this.smallNumeric.Value > 0)
            {
                OrderItem orderItem = new OrderItem();
                orderItem.item = "Small Drink";
                orderItem.quantity = (int)this.smallNumeric.Value;
                price += (decimal)(0.99 * orderItem.quantity);
                order.OrderItems.Add(orderItem);
            }

            if (this.breadstickNumeric.Value > 0)
            {
                OrderItem orderItem = new OrderItem();
                orderItem.item = "Breadsticks";
                orderItem.quantity = (int)this.breadstickNumeric.Value;
                price += (decimal)(4.99 * orderItem.quantity);
                order.OrderItems.Add(orderItem);
            }

            order.price = (int)(price * 100);
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
