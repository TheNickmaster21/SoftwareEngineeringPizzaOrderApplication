using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringPizzaOrderApplication
{
    public partial class OrderReceiptView : Form
    {
        Customer customer;
        Order order;
        MainForm mainForm;

        AddressProxy addressProxy = new AddressProxy();

        Boolean overrideShowingMainForm = false;

        public OrderReceiptView(MainForm mainForm, Customer customer, Order order)
        {
            this.mainForm = mainForm;
            this.customer = customer;
            this.order = order;

            InitializeComponent();

            addressProxy.fillAddress(customer);

            makeReceipt();
        }

        private void makeReceipt()
        {
            List<String> receipt = new List<String>();

            receipt.Add("Example Pizza Company");
            receipt.Add("123 Fake Rd");
            receipt.Add("Kennesaw, GA 30144");
            receipt.Add("");
            receipt.Add("Customer");
            receipt.Add(customer.first_name + " " + customer.last_name);
            receipt.Add(customer.phone_number);
            receipt.Add("");
            receipt.Add("Address");
            receipt.Add(customer.Address.line_1);
            if(customer.Address.line_2 != null && customer.Address.line_2 != "")
            {
                receipt.Add(customer.Address.line_2);
            }
            if (customer.Address.line_3 != null && customer.Address.line_3 != "")
            {
                receipt.Add(customer.Address.line_3);
            }
            receipt.Add(customer.Address.city + ", " + customer.Address.state + " " + customer.Address.postal_code);
            receipt.Add("");
            receipt.Add(order.time.ToString());
            receipt.Add("");
            receipt.Add("Items");
            foreach (OrderItem orderItem in order.OrderItems)
            {
                receipt.Add(orderItem.quantity + " " + orderItem.item);
            }            receipt.Add("");
            receipt.Add("Total: $" + ((decimal)order.price) / 100);

            this.textBox.Lines = receipt.ToArray();
            this.printDocument.PrintPage += document_PrintPage;
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            var graphics = e.Graphics;
            var normalFont = new Font("Calibri", 14);

            var pageBounds = e.MarginBounds;
            var drawingPoint = new PointF(pageBounds.Left, (pageBounds.Top + normalFont.Height));

            foreach (String s in this.textBox.Lines)
            {
                graphics.DrawString(s, normalFont, Brushes.Black, drawingPoint);

                drawingPoint.Y += normalFont.Height;
            }

            e.HasMorePages = false;
        }

        private void closed(object sender, EventArgs e)
        {
            if (!overrideShowingMainForm)
            {
                mainForm.Show();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            overrideShowingMainForm = false;
            MenuForm menuForm = new MenuForm(mainForm);
            menuForm.Show();
            this.Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            this.printDialog.Document = this.printDocument;
            this.printDialog.ShowDialog();
        }
    }
}
