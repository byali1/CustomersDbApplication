namespace CustomersDbApplication
{
    partial class UserControlListCustomers
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
            dgwCustomers = new DataGridView();
            tbxSearchCustomerByName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgwCustomers).BeginInit();
            SuspendLayout();
            // 
            // dgwCustomers
            // 
            dgwCustomers.AllowUserToAddRows = false;
            dgwCustomers.AllowUserToDeleteRows = false;
            dgwCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCustomers.Location = new Point(55, 80);
            dgwCustomers.Name = "dgwCustomers";
            dgwCustomers.ReadOnly = true;
            dgwCustomers.RowTemplate.Height = 25;
            dgwCustomers.Size = new Size(517, 150);
            dgwCustomers.TabIndex = 0;
            // 
            // tbxSearchCustomerByName
            // 
            tbxSearchCustomerByName.Location = new Point(186, 40);
            tbxSearchCustomerByName.Name = "tbxSearchCustomerByName";
            tbxSearchCustomerByName.Size = new Size(264, 23);
            tbxSearchCustomerByName.TabIndex = 1;
            tbxSearchCustomerByName.TextChanged += tbxSearchCustomerByName_TextChanged;
            // 
            // UserControlListCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbxSearchCustomerByName);
            Controls.Add(dgwCustomers);
            Name = "UserControlListCustomers";
            Size = new Size(621, 313);
            Load += UserControlListCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)dgwCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwCustomers;
        private TextBox tbxSearchCustomerByName;
    }
}
