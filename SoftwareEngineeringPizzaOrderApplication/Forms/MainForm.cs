﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzaApplicationDatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaApplicationDatabaseDataSet.Address' table. You can move, or remove it, as needed.
            this.addressTableAdapter.Fill(this.pizzaApplicationDatabaseDataSet.Address);
            // TODO: This line of code loads data into the 'pizzaApplicationDatabaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.pizzaApplicationDatabaseDataSet.Customer);

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(this);
            menuForm.Show();
            this.Hide();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {

        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            CustomerViewForm customerViewForm = new CustomerViewForm(this);
            customerViewForm.Show();
            this.Hide();
        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerInfoInputForm customerInfoInputForm = new CustomerInfoInputForm(this);
            customerInfoInputForm.Show();
            this.Hide();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
