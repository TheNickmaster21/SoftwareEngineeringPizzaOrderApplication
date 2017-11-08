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
    public partial class CustomerInfoInputForm : Form
    {

        MainForm mainForm;
        MenuForm menuForm;

        CustomerProxy customerProxy = new CustomerProxy();
        AddressProxy addressProxy = new AddressProxy();

        public CustomerInfoInputForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            this.FormClosed += this.closed;
        }

        public CustomerInfoInputForm(MenuForm menuForm)
        {
            this.menuForm = menuForm;
            InitializeComponent();
            this.FormClosed += this.closed;
        }

        private void save_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            address.city = this.city.Text;
            address.country = (string)this.country.Items[this.country.SelectedIndex];
            address.line_1 = this.line1.Text;
            address.line_2 = this.line2.Text;
            address.line_3 = this.line3.Text;
            address.postal_code = this.zipCode.Text;
            address.state = (string)this.state.Items[this.state.SelectedIndex];

            Customer customer = new Customer();
            customer.phone_number = this.phoneNumber.Text;
            customer.first_name = this.firstName.Text;
            customer.last_name = this.lastName.Text;
            customer.card_type = this.chargeCard.Text;

            try
            {
                address = addressProxy.saveAddress(address);
                customer.address = address.Id;

                customer = customerProxy.saveCustomer(customer);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            MessageBox.Show("Saved " + customer.first_name + " " + customer.last_name + "!");
            if (menuForm != null)
            {
                menuForm.giveCustomerPhoneNumber(customer.phone_number);
            }
            this.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closed(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.Show();
            }
            else if (menuForm != null)
            {
                menuForm.Show();
            }
        }
    }
}
