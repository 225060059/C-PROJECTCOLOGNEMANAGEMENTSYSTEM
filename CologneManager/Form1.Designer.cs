namespace CologneManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            label5 = new Label();
            gridColognes = new DataGridView();
            btnAddCologne = new Button();
            txtStock = new TextBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            txtBrand = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            label6 = new Label();
            txtCustPhone = new TextBox();
            txtCustEmail = new TextBox();
            txtCustName = new TextBox();
            gridCustomers = new DataGridView();
            btnAddCustomer = new Button();
            labelPhone_Fixed = new Label();
            labelEmail_Fixed = new Label();
            labelName_Fixed = new Label();
            tabPage3 = new TabPage();
            panel3 = new Panel();
            label7 = new Label();
            cmbProduct = new ComboBox();
            cmbCustomer = new ComboBox();
            gridOrders = new DataGridView();
            numQuantity = new NumericUpDown();
            btnPlaceOrder = new Button();
            labelrandom3 = new Label();
            labelrandom2 = new Label();
            labelrandom1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridColognes).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCustomers).BeginInit();
            tabPage3.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(984, 461);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(gridColognes);
            tabPage1.Controls.Add(btnAddCologne);
            tabPage1.Controls.Add(txtStock);
            tabPage1.Controls.Add(txtPrice);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(txtBrand);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(976, 433);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Stock";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 68);
            panel1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(9, 5);
            label5.Name = "label5";
            label5.Size = new Size(513, 50);
            label5.TabIndex = 10;
            label5.Text = "Cologne Stock Management";
            // 
            // gridColognes
            // 
            gridColognes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridColognes.Location = new Point(340, 79);
            gridColognes.Name = "gridColognes";
            gridColognes.Size = new Size(618, 336);
            gridColognes.TabIndex = 9;
            // 
            // btnAddCologne
            // 
            btnAddCologne.Location = new Point(126, 244);
            btnAddCologne.Name = "btnAddCologne";
            btnAddCologne.Size = new Size(190, 42);
            btnAddCologne.TabIndex = 8;
            btnAddCologne.Text = "Add Cologne";
            btnAddCologne.UseVisualStyleBackColor = true;
            btnAddCologne.Click += btnAddCologne_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(126, 195);
            txtStock.Multiline = true;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(190, 32);
            txtStock.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(126, 157);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(190, 32);
            txtPrice.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(126, 119);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 32);
            txtName.TabIndex = 5;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(126, 78);
            txtBrand.Multiline = true;
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(190, 33);
            txtBrand.TabIndex = 4;
            txtBrand.TextChanged += txtBrand_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold);
            label4.Location = new Point(9, 189);
            label4.Name = "label4";
            label4.Size = new Size(95, 40);
            label4.TabIndex = 3;
            label4.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold);
            label3.Location = new Point(8, 151);
            label3.Name = "label3";
            label3.Size = new Size(88, 40);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold);
            label2.Location = new Point(8, 111);
            label2.Name = "label2";
            label2.Size = new Size(101, 40);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold);
            label1.Location = new Point(8, 71);
            label1.Name = "label1";
            label1.Size = new Size(103, 40);
            label1.TabIndex = 0;
            label1.Text = "Brand";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(txtCustPhone);
            tabPage2.Controls.Add(txtCustEmail);
            tabPage2.Controls.Add(txtCustName);
            tabPage2.Controls.Add(gridCustomers);
            tabPage2.Controls.Add(btnAddCustomer);
            tabPage2.Controls.Add(labelPhone_Fixed);
            tabPage2.Controls.Add(labelEmail_Fixed);
            tabPage2.Controls.Add(labelName_Fixed);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(976, 433);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(-4, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(988, 68);
            panel2.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(7, 3);
            label6.Name = "label6";
            label6.Size = new Size(515, 50);
            label6.TabIndex = 10;
            label6.Text = "Customers List Management";
            // 
            // txtCustPhone
            // 
            txtCustPhone.Location = new Point(114, 157);
            txtCustPhone.Multiline = true;
            txtCustPhone.Name = "txtCustPhone";
            txtCustPhone.Size = new Size(242, 31);
            txtCustPhone.TabIndex = 7;
            // 
            // txtCustEmail
            // 
            txtCustEmail.Location = new Point(114, 117);
            txtCustEmail.Multiline = true;
            txtCustEmail.Name = "txtCustEmail";
            txtCustEmail.Size = new Size(242, 31);
            txtCustEmail.TabIndex = 6;
            // 
            // txtCustName
            // 
            txtCustName.Location = new Point(114, 77);
            txtCustName.Multiline = true;
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(242, 31);
            txtCustName.TabIndex = 5;
            // 
            // gridCustomers
            // 
            gridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCustomers.Location = new Point(378, 77);
            gridCustomers.Name = "gridCustomers";
            gridCustomers.Size = new Size(576, 325);
            gridCustomers.TabIndex = 4;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(114, 207);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(242, 51);
            btnAddCustomer.TabIndex = 3;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // labelPhone_Fixed
            // 
            labelPhone_Fixed.AutoSize = true;
            labelPhone_Fixed.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPhone_Fixed.Location = new Point(6, 151);
            labelPhone_Fixed.Name = "labelPhone_Fixed";
            labelPhone_Fixed.Size = new Size(106, 40);
            labelPhone_Fixed.TabIndex = 2;
            labelPhone_Fixed.Text = "Phone";
            // 
            // labelEmail_Fixed
            // 
            labelEmail_Fixed.AutoSize = true;
            labelEmail_Fixed.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail_Fixed.Location = new Point(6, 111);
            labelEmail_Fixed.Name = "labelEmail_Fixed";
            labelEmail_Fixed.Size = new Size(95, 40);
            labelEmail_Fixed.TabIndex = 1;
            labelEmail_Fixed.Text = "Email";
            // 
            // labelName_Fixed
            // 
            labelName_Fixed.AutoSize = true;
            labelName_Fixed.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName_Fixed.Location = new Point(6, 71);
            labelName_Fixed.Name = "labelName_Fixed";
            labelName_Fixed.Size = new Size(101, 40);
            labelName_Fixed.TabIndex = 0;
            labelName_Fixed.Text = "Name";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel3);
            tabPage3.Controls.Add(cmbProduct);
            tabPage3.Controls.Add(cmbCustomer);
            tabPage3.Controls.Add(gridOrders);
            tabPage3.Controls.Add(numQuantity);
            tabPage3.Controls.Add(btnPlaceOrder);
            tabPage3.Controls.Add(labelrandom3);
            tabPage3.Controls.Add(labelrandom2);
            tabPage3.Controls.Add(labelrandom1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(976, 433);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Orders";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.Controls.Add(label7);
            panel3.Location = new Point(1, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(988, 68);
            panel3.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HighlightText;
            label7.Location = new Point(5, 2);
            label7.Name = "label7";
            label7.Size = new Size(449, 50);
            label7.TabIndex = 10;
            label7.Text = "Orders List Management";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(175, 123);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(196, 23);
            cmbProduct.TabIndex = 9;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(175, 85);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(196, 23);
            cmbCustomer.TabIndex = 8;
            // 
            // gridOrders
            // 
            gridOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOrders.Location = new Point(396, 85);
            gridOrders.Name = "gridOrders";
            gridOrders.Size = new Size(556, 329);
            gridOrders.TabIndex = 7;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(175, 165);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(196, 23);
            numQuantity.TabIndex = 6;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(175, 204);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(196, 51);
            btnPlaceOrder.TabIndex = 3;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // labelrandom3
            // 
            labelrandom3.AutoSize = true;
            labelrandom3.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold);
            labelrandom3.Location = new Point(8, 152);
            labelrandom3.Name = "labelrandom3";
            labelrandom3.Size = new Size(141, 40);
            labelrandom3.TabIndex = 2;
            labelrandom3.Text = "Quantity";
            // 
            // labelrandom2
            // 
            labelrandom2.AutoSize = true;
            labelrandom2.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold);
            labelrandom2.Location = new Point(8, 112);
            labelrandom2.Name = "labelrandom2";
            labelrandom2.Size = new Size(130, 40);
            labelrandom2.TabIndex = 1;
            labelrandom2.Text = "Product";
            // 
            // labelrandom1
            // 
            labelrandom1.AutoSize = true;
            labelrandom1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold);
            labelrandom1.Location = new Point(8, 72);
            labelrandom1.Name = "labelrandom1";
            labelrandom1.Size = new Size(154, 40);
            labelrandom1.TabIndex = 0;
            labelrandom1.Text = "Customer";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cologne Shop Management System";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridColognes).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCustomers).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView gridColognes;
        private Button btnAddCologne;
        private TextBox txtStock;
        private TextBox txtPrice;
        private TextBox txtName;
        private TextBox txtBrand;
        private DataGridView gridCustomers;
        private Button btnAddCustomer;
        private Label labelPhone_Fixed;
        private Label labelEmail_Fixed;
        private Label labelName_Fixed;
        private TextBox txtCustPhone;
        private TextBox txtCustEmail;
        private TextBox txtCustName;
        private TabPage tabPage3;
        private Label labelrandom3;
        private Label labelrandom2;
        private Label labelrandom1;
        private Button btnPlaceOrder;
        private NumericUpDown numQuantity;
        private DataGridView gridOrders;
        private ComboBox cmbProduct;
        private ComboBox cmbCustomer;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private Panel panel3;
        private Label label7;
    }
}
