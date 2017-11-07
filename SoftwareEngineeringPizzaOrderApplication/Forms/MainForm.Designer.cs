namespace SoftwareEngineeringPizzaOrderApplication
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.pizzaApplicationDatabaseDataSet = new SoftwareEngineeringPizzaOrderApplication.PizzaApplicationDatabaseDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new SoftwareEngineeringPizzaOrderApplication.PizzaApplicationDatabaseDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new SoftwareEngineeringPizzaOrderApplication.PizzaApplicationDatabaseDataSetTableAdapters.TableAdapterManager();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTableAdapter = new SoftwareEngineeringPizzaOrderApplication.PizzaApplicationDatabaseDataSetTableAdapters.AddressTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NewCustomerButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaApplicationDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pizzaApplicationDatabaseDataSet
            // 
            this.pizzaApplicationDatabaseDataSet.DataSetName = "PizzaApplicationDatabaseDataSet";
            this.pizzaApplicationDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.pizzaApplicationDatabaseDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.OrderItemTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SoftwareEngineeringPizzaOrderApplication.PizzaApplicationDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "Address";
            this.addressBindingSource.DataSource = this.pizzaApplicationDatabaseDataSet;
            // 
            // addressTableAdapter
            // 
            this.addressTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Pizza Application! What would you like to do?";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.NewCustomerButton);
            this.flowLayoutPanel1.Controls.Add(this.MenuButton);
            this.flowLayoutPanel1.Controls.Add(this.OrderButton);
            this.flowLayoutPanel1.Controls.Add(this.CustomerButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(332, 129);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // NewCustomerButton
            // 
            this.NewCustomerButton.Location = new System.Drawing.Point(3, 16);
            this.NewCustomerButton.Name = "NewCustomerButton";
            this.NewCustomerButton.Size = new System.Drawing.Size(329, 23);
            this.NewCustomerButton.TabIndex = 1;
            this.NewCustomerButton.Text = "Register New Customer";
            this.NewCustomerButton.UseVisualStyleBackColor = true;
            this.NewCustomerButton.Click += new System.EventHandler(this.NewCustomerButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(3, 45);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(329, 23);
            this.MenuButton.TabIndex = 2;
            this.MenuButton.Text = "Order as Customer";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(3, 74);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(329, 23);
            this.OrderButton.TabIndex = 3;
            this.OrderButton.Text = "View Orders";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // CustomerButton
            // 
            this.CustomerButton.Location = new System.Drawing.Point(3, 103);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(329, 23);
            this.CustomerButton.TabIndex = 4;
            this.CustomerButton.Text = "View Customers";
            this.CustomerButton.UseVisualStyleBackColor = true;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(250, 147);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(94, 23);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Exit Application";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 179);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.quitButton);
            this.Name = "MainForm";
            this.Text = "Pizza Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pizzaApplicationDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PizzaApplicationDatabaseDataSet pizzaApplicationDatabaseDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private PizzaApplicationDatabaseDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private PizzaApplicationDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private PizzaApplicationDatabaseDataSetTableAdapters.AddressTableAdapter addressTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.Button NewCustomerButton;
        private System.Windows.Forms.Button quitButton;
    }
}

