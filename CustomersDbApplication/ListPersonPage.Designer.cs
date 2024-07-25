namespace CustomersDbApplication
{
    partial class ListPersonPage
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
            lblSearchPerson = new Label();
            tbxSearchPersonByName = new TextBox();
            dgwPersons = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwPersons).BeginInit();
            SuspendLayout();
            // 
            // lblSearchPerson
            // 
            lblSearchPerson.AutoSize = true;
            lblSearchPerson.Location = new Point(221, 47);
            lblSearchPerson.Name = "lblSearchPerson";
            lblSearchPerson.Size = new Size(108, 15);
            lblSearchPerson.TabIndex = 8;
            lblSearchPerson.Text = "Gerçek müşteri ara:";
            // 
            // tbxSearchPersonByName
            // 
            tbxSearchPersonByName.Location = new Point(335, 44);
            tbxSearchPersonByName.Name = "tbxSearchPersonByName";
            tbxSearchPersonByName.Size = new Size(772, 23);
            tbxSearchPersonByName.TabIndex = 7;
            tbxSearchPersonByName.TextChanged += tbxSearchPersonByName_TextChanged;
            // 
            // dgwPersons
            // 
            dgwPersons.AllowUserToAddRows = false;
            dgwPersons.AllowUserToDeleteRows = false;
            dgwPersons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwPersons.Location = new Point(27, 83);
            dgwPersons.Name = "dgwPersons";
            dgwPersons.ReadOnly = true;
            dgwPersons.RowTemplate.Height = 25;
            dgwPersons.Size = new Size(1319, 231);
            dgwPersons.TabIndex = 6;
            // 
            // ListPersonPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 326);
            Controls.Add(lblSearchPerson);
            Controls.Add(tbxSearchPersonByName);
            Controls.Add(dgwPersons);
            Name = "ListPersonPage";
            Text = "Gerçek Müşteri Listeleme Paneli";
            Load += ListPersonPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgwPersons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearchPerson;
        private TextBox tbxSearchPersonByName;
        private DataGridView dgwPersons;
    }
}