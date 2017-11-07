namespace SoftwareEngineeringPizzaOrderApplication
{
    partial class CustomerInfoInputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.TextBox();
            this.line2 = new System.Windows.Forms.TextBox();
            this.line3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.ComboBox();
            this.state = new System.Windows.Forms.ComboBox();
            this.city = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.zipCode = new System.Windows.Forms.TextBox();
            this.pizzaApplicationDatabaseDataSet = new SoftwareEngineeringPizzaOrderApplication.PizzaApplicationDatabaseDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new SoftwareEngineeringPizzaOrderApplication.PizzaApplicationDatabaseDataSetTableAdapters.OrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaApplicationDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Number";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(28, 25);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(190, 20);
            this.phoneNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(25, 321);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(58, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.close_Click);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(28, 69);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(190, 20);
            this.firstName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(28, 115);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(190, 20);
            this.lastName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(28, 164);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(190, 20);
            this.line1.TabIndex = 4;
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(28, 190);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(190, 20);
            this.line2.TabIndex = 5;
            // 
            // line3
            // 
            this.line3.Location = new System.Drawing.Point(28, 216);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(190, 20);
            this.line3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Country";
            // 
            // country
            // 
            this.country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.country.FormattingEnabled = true;
            this.country.Items.AddRange(new object[] {
            "US"});
            this.country.Location = new System.Drawing.Point(89, 294);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(52, 21);
            this.country.Sorted = true;
            this.country.TabIndex = 9;
            // 
            // state
            // 
            this.state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.state.FormattingEnabled = true;
            this.state.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.state.Location = new System.Drawing.Point(28, 294);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(55, 21);
            this.state.TabIndex = 8;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(28, 255);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(190, 20);
            this.city.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Zip Code";
            // 
            // zipCode
            // 
            this.zipCode.Location = new System.Drawing.Point(147, 295);
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(71, 20);
            this.zipCode.TabIndex = 10;
            // 
            // pizzaApplicationDatabaseDataSet
            // 
            this.pizzaApplicationDatabaseDataSet.DataSetName = "PizzaApplicationDatabaseDataSet";
            this.pizzaApplicationDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.pizzaApplicationDatabaseDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerInfoInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 356);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.state);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.label1);
            this.Name = "CustomerInfoInputForm";
            this.Text = " New Customer";
            ((System.ComponentModel.ISupportInitialize)(this.pizzaApplicationDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PizzaApplicationDatabaseDataSet pizzaApplicationDatabaseDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private PizzaApplicationDatabaseDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox line1;
        private System.Windows.Forms.TextBox line2;
        private System.Windows.Forms.TextBox line3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.ComboBox state;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox zipCode;
    }
}