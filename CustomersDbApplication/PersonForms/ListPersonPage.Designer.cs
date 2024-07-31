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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblSearchPerson = new Label();
            tbxSearchPersonByName = new TextBox();
            dgwPersons = new DataGridView();
            tbxPersonFirstName = new TextBox();
            tbxPersonLastName = new TextBox();
            grpBoxFilterPerson = new GroupBox();
            btnClear = new Button();
            lblPhoneNumber = new Label();
            lblDistrict = new Label();
            lblCity = new Label();
            lblOccupation = new Label();
            cbxOccupations = new ComboBox();
            cbxDistricts = new ComboBox();
            cbxCities = new ComboBox();
            btnSearch = new Button();
            tbxEmail = new TextBox();
            tbxPhoneNumber = new TextBox();
            tbxBirthPlace = new TextBox();
            tbxIdentityNumber = new TextBox();
            btnRefresh = new Button();
            btnOpenFormToAddPerson = new Button();
            grpBoxCRUD = new GroupBox();
            btnDeletePerson = new Button();
            btnOpenFormToUpdatePerson = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwPersons).BeginInit();
            grpBoxFilterPerson.SuspendLayout();
            grpBoxCRUD.SuspendLayout();
            SuspendLayout();
            // 
            // lblSearchPerson
            // 
            lblSearchPerson.AutoSize = true;
            lblSearchPerson.Location = new Point(83, 208);
            lblSearchPerson.Name = "lblSearchPerson";
            lblSearchPerson.Size = new Size(108, 15);
            lblSearchPerson.TabIndex = 8;
            lblSearchPerson.Text = "Gerçek müşteri ara:";
            // 
            // tbxSearchPersonByName
            // 
            tbxSearchPersonByName.Location = new Point(197, 205);
            tbxSearchPersonByName.Name = "tbxSearchPersonByName";
            tbxSearchPersonByName.Size = new Size(678, 23);
            tbxSearchPersonByName.TabIndex = 7;
            tbxSearchPersonByName.TextChanged += tbxSearchPersonByName_TextChanged;
            // 
            // dgwPersons
            // 
            dgwPersons.AllowUserToAddRows = false;
            dgwPersons.AllowUserToDeleteRows = false;
            dgwPersons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwPersons.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = Color.Brown;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgwPersons.DefaultCellStyle = dataGridViewCellStyle1;
            dgwPersons.Location = new Point(12, 241);
            dgwPersons.MultiSelect = false;
            dgwPersons.Name = "dgwPersons";
            dgwPersons.ReadOnly = true;
            dgwPersons.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgwPersons.RowTemplate.Height = 25;
            dgwPersons.Size = new Size(863, 231);
            dgwPersons.TabIndex = 6;
            dgwPersons.CellClick += dgwPersons_CellClick;
            dgwPersons.SelectionChanged += dgwPersons_SelectionChanged;
            // 
            // tbxPersonFirstName
            // 
            tbxPersonFirstName.Location = new Point(18, 33);
            tbxPersonFirstName.Name = "tbxPersonFirstName";
            tbxPersonFirstName.PlaceholderText = "Ad";
            tbxPersonFirstName.Size = new Size(139, 23);
            tbxPersonFirstName.TabIndex = 9;
            // 
            // tbxPersonLastName
            // 
            tbxPersonLastName.Location = new Point(18, 78);
            tbxPersonLastName.Name = "tbxPersonLastName";
            tbxPersonLastName.PlaceholderText = "Soyad";
            tbxPersonLastName.Size = new Size(139, 23);
            tbxPersonLastName.TabIndex = 10;
            // 
            // grpBoxFilterPerson
            // 
            grpBoxFilterPerson.Controls.Add(btnClear);
            grpBoxFilterPerson.Controls.Add(lblPhoneNumber);
            grpBoxFilterPerson.Controls.Add(lblDistrict);
            grpBoxFilterPerson.Controls.Add(lblCity);
            grpBoxFilterPerson.Controls.Add(lblOccupation);
            grpBoxFilterPerson.Controls.Add(cbxOccupations);
            grpBoxFilterPerson.Controls.Add(cbxDistricts);
            grpBoxFilterPerson.Controls.Add(cbxCities);
            grpBoxFilterPerson.Controls.Add(btnSearch);
            grpBoxFilterPerson.Controls.Add(tbxEmail);
            grpBoxFilterPerson.Controls.Add(tbxPhoneNumber);
            grpBoxFilterPerson.Controls.Add(tbxBirthPlace);
            grpBoxFilterPerson.Controls.Add(tbxIdentityNumber);
            grpBoxFilterPerson.Controls.Add(tbxPersonFirstName);
            grpBoxFilterPerson.Controls.Add(tbxPersonLastName);
            grpBoxFilterPerson.Location = new Point(12, 12);
            grpBoxFilterPerson.Name = "grpBoxFilterPerson";
            grpBoxFilterPerson.Size = new Size(863, 162);
            grpBoxFilterPerson.TabIndex = 11;
            grpBoxFilterPerson.TabStop = false;
            grpBoxFilterPerson.Text = "Gerçek müşteri arayın";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(18, 124);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 20;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(531, 15);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(67, 15);
            lblPhoneNumber.TabIndex = 25;
            lblPhoneNumber.Text = "Telefon No:";
            // 
            // lblDistrict
            // 
            lblDistrict.AutoSize = true;
            lblDistrict.Location = new Point(364, 63);
            lblDistrict.Name = "lblDistrict";
            lblDistrict.Size = new Size(28, 15);
            lblDistrict.TabIndex = 24;
            lblDistrict.Text = "İlçe:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(364, 15);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(36, 15);
            lblCity.TabIndex = 23;
            lblCity.Text = "Şehir:";
            // 
            // lblOccupation
            // 
            lblOccupation.AutoSize = true;
            lblOccupation.Location = new Point(531, 63);
            lblOccupation.Name = "lblOccupation";
            lblOccupation.Size = new Size(47, 15);
            lblOccupation.TabIndex = 22;
            lblOccupation.Text = "Meslek:";
            // 
            // cbxOccupations
            // 
            cbxOccupations.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOccupations.FormattingEnabled = true;
            cbxOccupations.Location = new Point(532, 78);
            cbxOccupations.Name = "cbxOccupations";
            cbxOccupations.Size = new Size(137, 23);
            cbxOccupations.TabIndex = 21;
            cbxOccupations.SelectedIndexChanged += cbxOccupations_SelectedIndexChanged;
            // 
            // cbxDistricts
            // 
            cbxDistricts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDistricts.FormattingEnabled = true;
            cbxDistricts.Location = new Point(364, 78);
            cbxDistricts.Name = "cbxDistricts";
            cbxDistricts.Size = new Size(137, 23);
            cbxDistricts.TabIndex = 20;
            cbxDistricts.SelectedIndexChanged += cbxDistricts_SelectedIndexChanged;
            // 
            // cbxCities
            // 
            cbxCities.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCities.FormattingEnabled = true;
            cbxCities.Location = new Point(364, 33);
            cbxCities.Name = "cbxCities";
            cbxCities.Size = new Size(137, 23);
            cbxCities.TabIndex = 19;
            cbxCities.SelectedIndexChanged += cbxCities_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(778, 114);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(70, 33);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(711, 33);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "E-mail";
            tbxEmail.Size = new Size(137, 23);
            tbxEmail.TabIndex = 17;
            // 
            // tbxPhoneNumber
            // 
            tbxPhoneNumber.Location = new Point(532, 33);
            tbxPhoneNumber.MaxLength = 10;
            tbxPhoneNumber.Name = "tbxPhoneNumber";
            tbxPhoneNumber.PlaceholderText = "5XXXXXXXXX";
            tbxPhoneNumber.Size = new Size(137, 23);
            tbxPhoneNumber.TabIndex = 16;
            tbxPhoneNumber.KeyPress += tbxPhoneNumber_KeyPress;
            // 
            // tbxBirthPlace
            // 
            tbxBirthPlace.Location = new Point(194, 78);
            tbxBirthPlace.Name = "tbxBirthPlace";
            tbxBirthPlace.PlaceholderText = "Doğum yeri";
            tbxBirthPlace.Size = new Size(137, 23);
            tbxBirthPlace.TabIndex = 12;
            // 
            // tbxIdentityNumber
            // 
            tbxIdentityNumber.Location = new Point(194, 33);
            tbxIdentityNumber.MaxLength = 11;
            tbxIdentityNumber.Name = "tbxIdentityNumber";
            tbxIdentityNumber.PlaceholderText = "TC No";
            tbxIdentityNumber.Size = new Size(137, 23);
            tbxIdentityNumber.TabIndex = 11;
            tbxIdentityNumber.KeyPress += tbxIdentityNumber_KeyPress;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(12, 202);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(65, 27);
            btnRefresh.TabIndex = 19;
            btnRefresh.Text = "Yenile";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnOpenFormToAddPerson
            // 
            btnOpenFormToAddPerson.Location = new Point(31, 33);
            btnOpenFormToAddPerson.Name = "btnOpenFormToAddPerson";
            btnOpenFormToAddPerson.Size = new Size(79, 32);
            btnOpenFormToAddPerson.TabIndex = 20;
            btnOpenFormToAddPerson.Text = "Ekle";
            btnOpenFormToAddPerson.UseVisualStyleBackColor = true;
            btnOpenFormToAddPerson.Click += btnOpenFormToAddPerson_Click;
            // 
            // grpBoxCRUD
            // 
            grpBoxCRUD.Controls.Add(btnDeletePerson);
            grpBoxCRUD.Controls.Add(btnOpenFormToUpdatePerson);
            grpBoxCRUD.Controls.Add(btnOpenFormToAddPerson);
            grpBoxCRUD.Location = new Point(12, 491);
            grpBoxCRUD.Name = "grpBoxCRUD";
            grpBoxCRUD.Size = new Size(383, 82);
            grpBoxCRUD.TabIndex = 21;
            grpBoxCRUD.TabStop = false;
            grpBoxCRUD.Text = "CRUD İşlemleri";
            // 
            // btnDeletePerson
            // 
            btnDeletePerson.Location = new Point(277, 33);
            btnDeletePerson.Name = "btnDeletePerson";
            btnDeletePerson.Size = new Size(75, 32);
            btnDeletePerson.TabIndex = 22;
            btnDeletePerson.Text = "Sil";
            btnDeletePerson.UseVisualStyleBackColor = true;
            btnDeletePerson.Click += btnDeletePerson_Click;
            // 
            // btnOpenFormToUpdatePerson
            // 
            btnOpenFormToUpdatePerson.Location = new Point(157, 33);
            btnOpenFormToUpdatePerson.Name = "btnOpenFormToUpdatePerson";
            btnOpenFormToUpdatePerson.Size = new Size(78, 32);
            btnOpenFormToUpdatePerson.TabIndex = 21;
            btnOpenFormToUpdatePerson.Text = "Güncelle";
            btnOpenFormToUpdatePerson.UseVisualStyleBackColor = true;
            btnOpenFormToUpdatePerson.Click += btnOpenFormToUpdatePerson_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 123, 123);
            btnExit.Cursor = Cursors.Hand;
            btnExit.ForeColor = Color.Maroon;
            btnExit.Location = new Point(792, 524);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(83, 32);
            btnExit.TabIndex = 22;
            btnExit.Text = "Kapat";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // ListPersonPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 585);
            Controls.Add(btnExit);
            Controls.Add(grpBoxCRUD);
            Controls.Add(btnRefresh);
            Controls.Add(grpBoxFilterPerson);
            Controls.Add(lblSearchPerson);
            Controls.Add(tbxSearchPersonByName);
            Controls.Add(dgwPersons);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ListPersonPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerçek Müşteri Listeleme Paneli";
            Load += ListPersonPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgwPersons).EndInit();
            grpBoxFilterPerson.ResumeLayout(false);
            grpBoxFilterPerson.PerformLayout();
            grpBoxCRUD.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearchPerson;
        private TextBox tbxSearchPersonByName;
        private TextBox tbxPersonFirstName;
        private TextBox tbxPersonLastName;
        private GroupBox grpBoxFilterPerson;
        private TextBox tbxIdentityNumber;
        private TextBox tbxBirthPlace;
        private TextBox tbxEmail;
        private TextBox tbxPhoneNumber;
        private TextBox tbxDistrict;
        private TextBox tbxCity;
        private Button btnSearch;
        private Button btnRefresh;
        private ComboBox cbxCities;
        private ComboBox cbxDistricts;
        private ComboBox cbxOccupations;
        private Label lblOccupation;
        private Label lblDistrict;
        private Label lblCity;
        private Label lblPhoneNumber;
        private Button btnClear;
        private Button btnOpenFormToAddPerson;
        private GroupBox grpBoxCRUD;
        private Button btnDeletePerson;
        private Button btnOpenFormToUpdatePerson;
        private Button btnExit;
        public static DataGridView dgwPersons;
    }
}