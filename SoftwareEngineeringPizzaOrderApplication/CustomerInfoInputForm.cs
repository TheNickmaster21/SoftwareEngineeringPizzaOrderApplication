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
    public partial class OrderViewForm : Form
    {
        public OrderViewForm()
        {
            InitializeComponent();
        }

        private void OrderViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaApplicationDatabaseDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.pizzaApplicationDatabaseDataSet.Order);

        }
    }
}
