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

        CustomerProxy customerProxy = new CustomerProxy();
        AddressProxy addressProxy = new AddressProxy();

        public CustomerInfoInputForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void OrderViewForm_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            address.city = this.city.Text;
            address.country = this.country.SelectedText;
            address.line_1 = this.line1.Text;
            address.line_2 = this.line2.Text;
            address.line_3 = this.line3.Text;
            address.postal_code = this.zipCode.Text;
            address.state = this.state.SelectedText;

            Customer customer = new Customer();
            customer.phone_number = this.phoneNumber.Text;
            customer.first_name = this.firstName.Text;
            customer.last_name = this.lastName.Text;

            try
            {
                address = addressProxy.saveAddress(address);
                customer.address = address.Id;

                customer = customerProxy.saveCustomer(customer);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
