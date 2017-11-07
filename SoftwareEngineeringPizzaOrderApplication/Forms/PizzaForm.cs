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
    public partial class PizzaForm : Form
    {
        MenuForm menuForm;

        public PizzaForm(MenuForm menuForm)
        {
            this.menuForm = menuForm;
            InitializeComponent();
            this.FormClosed += this.closed;
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            menuForm.addPizza(buildPizza());
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closed(object sender, EventArgs e)
        {
            menuForm.Show();
        }

        private string buildPizza()
        {
            double price;
            string description;

            // Size
            if (this.smallRadio.Checked)
            {
                price = 3.99;
                description = "Small Pizza w/ ";

            }
            else if (this.mediumRadio.Checked)
            {
                price = 7.99;
                description = "Medium Pizza w/ ";
            }
            else // large pizza
            {
                price = 11.99;
                description = "Large Pizza w/ ";
            }

            // Sauce
            if (this.redRadio.Checked)
            {
                description += "Red Sauce";

            }
            else if (this.whiteRadio.Checked)
            {
                description += "White Sauce";
            }
            else // no sauce
            {
                description += "No Sauce";
            }

            // Toppings
            foreach (CheckBox toppingBox in this.toppingBox.Controls)
            {
                if (toppingBox.Checked)
                {
                    description += ", " + toppingBox.Text;
                    price += .25;
                }
            }

            return "$" + price + " - " + description;
        }
    }
}
