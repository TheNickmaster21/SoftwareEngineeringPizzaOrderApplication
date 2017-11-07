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

        }

        private void AddPizzaButton_Click(object sender, EventArgs e)
        {

        }

        public void addPizza(string pizza)
        {
            this.PizzaListBox.Items.Add(pizza);
        }
    }
}
