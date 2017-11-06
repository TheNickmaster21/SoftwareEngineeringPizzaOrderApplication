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
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
