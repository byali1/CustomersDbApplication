namespace CustomersDbApplication
{
    partial class ListCustomerPage
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
            lblSearchCustomer = new Label();
            tbxSearchCustomerByName = new TextBox();
            dgwCustomers = new DataGridView();
            checkBxGetActiveCustomers = new CheckBox();
            checkBxGetInActiveCustomers = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgwCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblSearchCustomer
            // 
            lblSearchCustomer.AutoSize = true;
            lblSearchCustomer.Location = new Point(50, 27);
            lblSearchCustomer.Name = "lblSearchCustomer";
            lblSearchCustomer.Size = new Size(69, 15);
            lblSearchCustomer.TabIndex = 5;
            lblSearchCustomer.Text = "Müşteri ara:";
            // 
            // tbxSearchCustomerByName
            // 
            tbxSearchCustomerByName.Location = new Point(125, 24);
            tbxSearchCustomerByName.Name = "tbxSearchCustomerByName";
            tbxSearchCustomerByName.Size = new Size(394, 23);
            tbxSearchCustomerByName.TabIndex = 4;
            tbxSearchCustomerByName.TextChanged += tbxSearchCustomerByName_TextChanged;
            // 
            // dgwCustomers
            // 
            dgwCustomers.AllowUserToAddRows = false;
            dgwCustomers.AllowUserToDeleteRows = false;
            dgwCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCustomers.Location = new Point(29, 95);
            dgwCustomers.Name = "dgwCustomers";
            dgwCustomers.ReadOnly = true;
            dgwCustomers.RowTemplate.Height = 25;
            dgwCustomers.Size = new Size(517, 211);
            dgwCustomers.TabIndex = 3;
            // 
            // checkBxGetActiveCustomers
            // 
            checkBxGetActiveCustomers.AutoSize = true;
            checkBxGetActiveCustomers.BackColor = Color.Transparent;
            checkBxGetActiveCustomers.Location = new Point(29, 70);
            checkBxGetActiveCustomers.Name = "checkBxGetActiveCustomers";
            checkBxGetActiveCustomers.Size = new Size(146, 19);
            checkBxGetActiveCustomers.TabIndex = 6;
            checkBxGetActiveCustomers.Text = "Aktif müşterileri göster";
            checkBxGetActiveCustomers.UseVisualStyleBackColor = false;
            checkBxGetActiveCustomers.CheckedChanged += checkBxGetActiveCustomers_CheckedChanged;
            // 
            // checkBxGetInActiveCustomers
            // 
            checkBxGetInActiveCustomers.AutoSize = true;
            checkBxGetInActiveCustomers.BackColor = Color.Transparent;
            checkBxGetInActiveCustomers.ForeColor = Color.Brown;
            checkBxGetInActiveCustomers.Location = new Point(351, 70);
            checkBxGetInActiveCustomers.Name = "checkBxGetInActiveCustomers";
            checkBxGetInActiveCustomers.Size = new Size(195, 19);
            checkBxGetInActiveCustomers.TabIndex = 7;
            checkBxGetInActiveCustomers.Text = "Aktif olmayan müşterileri göster";
            checkBxGetInActiveCustomers.UseVisualStyleBackColor = false;
            // 
            // ListCustomerPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 328);
            Controls.Add(checkBxGetInActiveCustomers);
            Controls.Add(checkBxGetActiveCustomers);
            Controls.Add(lblSearchCustomer);
            Controls.Add(tbxSearchCustomerByName);
            Controls.Add(dgwCustomers);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ListCustomerPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşterileri Listele";
            Load += ListCustomerPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgwCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearchCustomer;
        private TextBox tbxSearchCustomerByName;
        private DataGridView dgwCustomers;
        private CheckBox checkBxGetActiveCustomers;
        private CheckBox checkBxGetInActiveCustomers;
    }
}