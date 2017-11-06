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
    public partial class CustomerViewForm : Form
    {
        MainForm mainForm;

        public CustomerViewForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzaApplicationDatabaseDataSet);

        }

        private void back_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
