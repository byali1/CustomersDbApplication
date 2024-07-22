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
            grpBxAddPerson = new GroupBox();
            cbxPersonOccupations = new ComboBox();
            lblPersonIdentityType = new Label();
            cbxPersonIdentityType = new ComboBox();
            btnAddPerson = new Button();
            ((System.ComponentModel.ISupportInitialize)customersDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwPersons).BeginInit();
            grpBxAddPerson.SuspendLayout();
            SuspendLayout();
            // 
            // customersDbContextBindingSource
            // 
            customersDbContextBindingSource.DataSource = typeof(DataAccess.Concrete.AdoNet.CustomersDbContext);
            // 
            // dgwPersons
            // 
            dgwPersons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwPersons.Location = new Point(33, 3);
            dgwPersons.Name = "dgwPersons";
            dgwPersons.RowTemplate.Height = 25;
            dgwPersons.Size = new Size(1097, 190);
            dgwPersons.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 55);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "Müşteri soyadı:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(17, 55);
            lblName.Name = "lblName";
            lblName.Size = new Size(69, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Müşteri adı:";
            // 
            // tbxCustomerName
            // 
            tbxCustomerName.Location = new Point(17, 73);
            tbxCustomerName.Name = "tbxCustomerName";
            tbxCustomerName.Size = new Size(209, 23);
            tbxCustomerName.TabIndex = 3;
            // 
            // tbxCustomerLastName
            // 
            tbxCustomerLastName.Location = new Point(272, 73);
            tbxCustomerLastName.Name = "tbxCustomerLastName";
            tbxCustomerLastName.Size = new Size(209, 23);
            tbxCustomerLastName.TabIndex = 4;
            // 
            // grpBxAddPerson
            // 
            grpBxAddPerson.Controls.Add(cbxPersonOccupations);
            grpBxAddPerson.Controls.Add(lblPersonIdentityType);
            grpBxAddPerson.Controls.Add(cbxPersonIdentityType);
            grpBxAddPerson.Controls.Add(btnAddPerson);
            grpBxAddPerson.Controls.Add(tbxCustomerLastName);
            grpBxAddPerson.Controls.Add(tbxCustomerName);
            grpBxAddPerson.Controls.Add(lblName);
            grpBxAddPerson.Controls.Add(label2);
            grpBxAddPerson.Location = new Point(33, 214);
            grpBxAddPerson.Name = "grpBxAddPerson";
            grpBxAddPerson.Size = new Size(501, 196);
            grpBxAddPerson.TabIndex = 4;
            grpBxAddPerson.TabStop = false;
            grpBxAddPerson.Text = "Gerçek müşteri ekle";
            // 
            // cbxPersonOccupations
            // 
            cbxPersonOccupations.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxPersonOccupations.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxPersonOccupations.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPersonOccupations.FormattingEnabled = true;
            cbxPersonOccupations.Location = new Point(272, 132);
            cbxPersonOccupations.Name = "cbxPersonOccupations";
            cbxPersonOccupations.Size = new Size(209, 23);
            cbxPersonOccupations.TabIndex = 8;
            // 
            // lblPersonIdentityType
            // 
            lblPersonIdentityType.AutoSize = true;
            lblPersonIdentityType.Location = new Point(17, 114);
            lblPersonIdentityType.Name = "lblPersonIdentityType";
            lblPersonIdentityType.Size = new Size(63, 15);
            lblPersonIdentityType.TabIndex = 7;
            lblPersonIdentityType.Text = "Kimlik tipi:";
            // 
            // cbxPersonIdentityType
            // 
            cbxPersonIdentityType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxPersonIdentityType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxPersonIdentityType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPersonIdentityType.FormattingEnabled = true;
            cbxPersonIdentityType.Location = new Point(17, 132);
            cbxPersonIdentityType.Name = "cbxPersonIdentityType";
            cbxPersonIdentityType.Size = new Size(209, 23);
            cbxPersonIdentityType.TabIndex = 6;
            // 
            // btnAddPerson
            // 
            btnAddPerson.Location = new Point(406, 22);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(75, 23);
            btnAddPerson.TabIndex = 5;
            btnAddPerson.Text = "Ekle";
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // UserControlAddPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpBxAddPerson);
            Controls.Add(dgwPersons);
            Name = "UserControlAddPerson";
            Size = new Size(1161, 498);
            Load += UserControlAddPerson_Load;
            ((System.ComponentModel.ISupportInitialize)customersDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwPersons).EndInit();
            grpBxAddPerson.ResumeLayout(false);
            grpBxAddPerson.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource customersDbContextBindingSource;
        private DataGridView dgwPersons;
        private Label label2;
        private Label lblName;
        private TextBox tbxCustomerName;
        private TextBox tbxCustomerLastName;
        private GroupBox grpBxAddPerson;
        private Button btnAddPerson;
        private ComboBox cbxPersonIdentityType;
        private Label lblPersonIdentityType;
        private ComboBox cbxPersonOccupations;
    }
}
