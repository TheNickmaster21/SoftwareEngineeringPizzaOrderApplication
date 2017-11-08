namespace SoftwareEngineeringPizzaOrderApplication
{
    partial class OrderReceiptView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.textBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(270, 472);
            this.textBox.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 491);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(107, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Back To Menu";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(125, 491);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(61, 23);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(192, 491);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(91, 23);
            this.orderButton.TabIndex = 3;
            this.orderButton.Text = "New Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // OrderReceiptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 526);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.textBox);
            this.Name = "OrderReceiptView";
            this.Text = "Order Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button orderButton;
    }
}