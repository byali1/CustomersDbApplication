namespace CustomersDbApplication
{
    partial class UserControlAddPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            customersDbContextBindingSource = new BindingSource(components);
            dgwPersons = new DataGridView();
            label2 = new Label();
            lblName = new Label();
            tbxCustomerName = new TextBox();
            tbxCustomerLastName = new TextBox();
            grpBxAddCustomer = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)customersDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwPersons).BeginInit();
            grpBxAddCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // customersDbContextBindingSource
            // 
            customersDbContextBindingSource.DataSource = typeof(DataAccess.Concrete.AdoNet.CustomersDbContext);
            // 
            // dgwPersons
            // 
            dgwPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwPersons.Location = new Point(68, 26);
            dgwPersons.Name = "dgwPersons";
            dgwPersons.RowTemplate.Height = 25;
            dgwPersons.Size = new Size(423, 150);
            dgwPersons.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 38);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "Müşteri soyadı:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(18, 38);
            lblName.Name = "lblName";
            lblName.Size = new Size(69, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Müşteri adı:";
            // 
            // tbxCustomerName
            // 
            tbxCustomerName.Location = new Point(18, 56);
            tbxCustomerName.Name = "tbxCustomerName";
            tbxCustomerName.Size = new Size(209, 23);
            tbxCustomerName.TabIndex = 3;
            // 
            // tbxCustomerLastName
            // 
            tbxCustomerLastName.Location = new Point(273, 56);
            tbxCustomerLastName.Name = "tbxCustomerLastName";
            tbxCustomerLastName.Size = new Size(209, 23);
            tbxCustomerLastName.TabIndex = 4;
            // 
            // grpBxAddCustomer
            // 
            grpBxAddCustomer.Controls.Add(tbxCustomerLastName);
            grpBxAddCustomer.Controls.Add(tbxCustomerName);
            grpBxAddCustomer.Controls.Add(lblName);
            grpBxAddCustomer.Controls.Add(label2);
            grpBxAddCustomer.Location = new Point(68, 199);
            grpBxAddCustomer.Name = "grpBxAddCustomer";
            grpBxAddCustomer.Size = new Size(501, 196);
            grpBxAddCustomer.TabIndex = 4;
            grpBxAddCustomer.TabStop = false;
            grpBxAddCustomer.Text = "Müşteri ekle";
            // 
            // UserControlAddPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpBxAddCustomer);
            Controls.Add(dgwPersons);
            Name = "UserControlAddPerson";
            Size = new Size(917, 502);
            Load += UserControlAddPerson_Load;
            ((System.ComponentModel.ISupportInitialize)customersDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwPersons).EndInit();
            grpBxAddCustomer.ResumeLayout(false);
            grpBxAddCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource customersDbContextBindingSource;
        private DataGridView dgwPersons;
        private Label label2;
        private Label lblName;
        private TextBox tbxCustomerName;
        private TextBox tbxCustomerLastName;
        private GroupBox grpBxAddCustomer;
    }
}
