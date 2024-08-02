namespace CustomersDbApplication.CompanyForms
{
    partial class ListCompanyPage
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
            btnExit = new Button();
            grpBoxCRUD = new GroupBox();
            btnDeleteCompany = new Button();
            btnOpenFormToUpdateCompany = new Button();
            btnOpenFormToAddCompany = new Button();
            btnRefresh = new Button();
            grpBoxFilterCompany = new GroupBox();
            btnClear = new Button();
            lblPhoneNumber = new Label();
            lblDistrict = new Label();
            lblCity = new Label();
            lblCompanySectorType = new Label();
            cbxCompanySectorTypes = new ComboBox();
            cbxDistricts = new ComboBox();
            cbxCities = new ComboBox();
            btnSearch = new Button();
            tbxEmail = new TextBox();
            tbxPhoneNumber = new TextBox();
            tbxTaxNumber = new TextBox();
            tbxCompanyName = new TextBox();
            lblSearchCompany = new Label();
            tbxSearchCompanyByName = new TextBox();
            dgwCompanies = new DataGridView();
            grpBoxCRUD.SuspendLayout();
            grpBoxFilterCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCompanies).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 123, 123);
            btnExit.Cursor = Cursors.Hand;
            btnExit.ForeColor = Color.Maroon;
            btnExit.Location = new Point(804, 531);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(83, 32);
            btnExit.TabIndex = 29;
            btnExit.Text = "Kapat";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // grpBoxCRUD
            // 
            grpBoxCRUD.Controls.Add(btnDeleteCompany);
            grpBoxCRUD.Controls.Add(btnOpenFormToUpdateCompany);
            grpBoxCRUD.Controls.Add(btnOpenFormToAddCompany);
            grpBoxCRUD.Location = new Point(24, 498);
            grpBoxCRUD.Name = "grpBoxCRUD";
            grpBoxCRUD.Size = new Size(383, 82);
            grpBoxCRUD.TabIndex = 28;
            grpBoxCRUD.TabStop = false;
            grpBoxCRUD.Text = "CRUD İşlemleri";
            // 
            // btnDeleteCompany
            // 
            btnDeleteCompany.Cursor = Cursors.Hand;
            btnDeleteCompany.Location = new Point(277, 33);
            btnDeleteCompany.Name = "btnDeleteCompany";
            btnDeleteCompany.Size = new Size(75, 32);
            btnDeleteCompany.TabIndex = 22;
            btnDeleteCompany.Text = "Sil";
            btnDeleteCompany.UseVisualStyleBackColor = true;
            // 
            // btnOpenFormToUpdateCompany
            // 
            btnOpenFormToUpdateCompany.Cursor = Cursors.Hand;
            btnOpenFormToUpdateCompany.Location = new Point(157, 33);
            btnOpenFormToUpdateCompany.Name = "btnOpenFormToUpdateCompany";
            btnOpenFormToUpdateCompany.Size = new Size(78, 32);
            btnOpenFormToUpdateCompany.TabIndex = 21;
            btnOpenFormToUpdateCompany.Text = "Güncelle";
            btnOpenFormToUpdateCompany.UseVisualStyleBackColor = true;
            btnOpenFormToUpdateCompany.Click += btnOpenFormToUpdateCompany_Click;
            // 
            // btnOpenFormToAddCompany
            // 
            btnOpenFormToAddCompany.Cursor = Cursors.Hand;
            btnOpenFormToAddCompany.Location = new Point(31, 33);
            btnOpenFormToAddCompany.Name = "btnOpenFormToAddCompany";
            btnOpenFormToAddCompany.Size = new Size(79, 32);
            btnOpenFormToAddCompany.TabIndex = 20;
            btnOpenFormToAddCompany.Text = "Ekle";
            btnOpenFormToAddCompany.UseVisualStyleBackColor = true;
            btnOpenFormToAddCompany.Click += btnOpenFormToAddCompany_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(24, 209);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(65, 27);
            btnRefresh.TabIndex = 27;
            btnRefresh.Text = "Yenile";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // grpBoxFilterCompany
            // 
            grpBoxFilterCompany.Controls.Add(btnClear);
            grpBoxFilterCompany.Controls.Add(lblPhoneNumber);
            grpBoxFilterCompany.Controls.Add(lblDistrict);
            grpBoxFilterCompany.Controls.Add(lblCity);
            grpBoxFilterCompany.Controls.Add(lblCompanySectorType);
            grpBoxFilterCompany.Controls.Add(cbxCompanySectorTypes);
            grpBoxFilterCompany.Controls.Add(cbxDistricts);
            grpBoxFilterCompany.Controls.Add(cbxCities);
            grpBoxFilterCompany.Controls.Add(btnSearch);
            grpBoxFilterCompany.Controls.Add(tbxEmail);
            grpBoxFilterCompany.Controls.Add(tbxPhoneNumber);
            grpBoxFilterCompany.Controls.Add(tbxTaxNumber);
            grpBoxFilterCompany.Controls.Add(tbxCompanyName);
            grpBoxFilterCompany.ForeColor = Color.MediumBlue;
            grpBoxFilterCompany.Location = new Point(24, 19);
            grpBoxFilterCompany.Name = "grpBoxFilterCompany";
            grpBoxFilterCompany.Size = new Size(863, 162);
            grpBoxFilterCompany.TabIndex = 26;
            grpBoxFilterCompany.TabStop = false;
            grpBoxFilterCompany.Text = "Tüzel müşteri arayın";
            // 
            // btnClear
            // 
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(18, 114);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 20;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
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
            // lblCompanySectorType
            // 
            lblCompanySectorType.AutoSize = true;
            lblCompanySectorType.Location = new Point(531, 63);
            lblCompanySectorType.Name = "lblCompanySectorType";
            lblCompanySectorType.Size = new Size(43, 15);
            lblCompanySectorType.TabIndex = 22;
            lblCompanySectorType.Text = "Sektör:";
            // 
            // cbxCompanySectorTypes
            // 
            cbxCompanySectorTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCompanySectorTypes.FormattingEnabled = true;
            cbxCompanySectorTypes.Location = new Point(532, 78);
            cbxCompanySectorTypes.Name = "cbxCompanySectorTypes";
            cbxCompanySectorTypes.Size = new Size(137, 23);
            cbxCompanySectorTypes.TabIndex = 21;
            // 
            // cbxDistricts
            // 
            cbxDistricts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDistricts.FormattingEnabled = true;
            cbxDistricts.Location = new Point(364, 78);
            cbxDistricts.Name = "cbxDistricts";
            cbxDistricts.Size = new Size(137, 23);
            cbxDistricts.TabIndex = 20;
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
            btnSearch.ForeColor = SystemColors.ActiveCaptionText;
            btnSearch.Location = new Point(778, 114);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(70, 33);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = true;
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
            // 
            // tbxTaxNumber
            // 
            tbxTaxNumber.Location = new Point(18, 78);
            tbxTaxNumber.MaxLength = 11;
            tbxTaxNumber.Name = "tbxTaxNumber";
            tbxTaxNumber.PlaceholderText = "Vergi numarası";
            tbxTaxNumber.Size = new Size(217, 23);
            tbxTaxNumber.TabIndex = 11;
            // 
            // tbxCompanyName
            // 
            tbxCompanyName.Location = new Point(18, 33);
            tbxCompanyName.Name = "tbxCompanyName";
            tbxCompanyName.PlaceholderText = "Unvan";
            tbxCompanyName.Size = new Size(316, 23);
            tbxCompanyName.TabIndex = 9;
            // 
            // lblSearchCompany
            // 
            lblSearchCompany.AutoSize = true;
            lblSearchCompany.Location = new Point(121, 215);
            lblSearchCompany.Name = "lblSearchCompany";
            lblSearchCompany.Size = new Size(58, 15);
            lblSearchCompany.TabIndex = 25;
            lblSearchCompany.Text = "Şirket ara:";
            // 
            // tbxSearchCompanyByName
            // 
            tbxSearchCompanyByName.Location = new Point(185, 213);
            tbxSearchCompanyByName.Name = "tbxSearchCompanyByName";
            tbxSearchCompanyByName.Size = new Size(702, 23);
            tbxSearchCompanyByName.TabIndex = 24;
            tbxSearchCompanyByName.TextChanged += tbxSearchCompanyByName_TextChanged;
            // 
            // dgwCompanies
            // 
            dgwCompanies.AllowUserToAddRows = false;
            dgwCompanies.AllowUserToDeleteRows = false;
            dgwCompanies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwCompanies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCompanies.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = Color.Brown;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgwCompanies.DefaultCellStyle = dataGridViewCellStyle1;
            dgwCompanies.Location = new Point(24, 248);
            dgwCompanies.MultiSelect = false;
            dgwCompanies.Name = "dgwCompanies";
            dgwCompanies.ReadOnly = true;
            dgwCompanies.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgwCompanies.RowTemplate.Height = 25;
            dgwCompanies.Size = new Size(863, 231);
            dgwCompanies.TabIndex = 23;
            dgwCompanies.SelectionChanged += dgwCompanies_SelectionChanged;
            // 
            // ListCompanyPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(908, 604);
            Controls.Add(btnExit);
            Controls.Add(grpBoxCRUD);
            Controls.Add(btnRefresh);
            Controls.Add(grpBoxFilterCompany);
            Controls.Add(lblSearchCompany);
            Controls.Add(tbxSearchCompanyByName);
            Controls.Add(dgwCompanies);
            MaximizeBox = false;
            Name = "ListCompanyPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tüzel Müşteri Listeleme Paneli";
            Load += ListCompanyPage_Load;
            grpBoxCRUD.ResumeLayout(false);
            grpBoxFilterCompany.ResumeLayout(false);
            grpBoxFilterCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCompanies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private GroupBox grpBoxCRUD;
        private Button btnDeleteCompany;
        private Button btnOpenFormToUpdateCompany;
        private Button btnOpenFormToAddCompany;
        private Button btnRefresh;
        private GroupBox grpBoxFilterCompany;
        private Button btnClear;
        private Label lblPhoneNumber;
        private Label lblDistrict;
        private Label lblCity;
        private Label lblCompanySectorType;
        private ComboBox cbxCompanySectorTypes;
        private ComboBox cbxDistricts;
        private ComboBox cbxCities;
        private Button btnSearch;
        private TextBox tbxEmail;
        private TextBox tbxPhoneNumber;
        private TextBox tbxTaxNumber;
        private TextBox tbxCompanyName;
        private TextBox tbxPersonLastName;
        private Label lblSearchCompany;
        private TextBox tbxSearchCompanyByName;
        public static DataGridView dgwCompanies;
    }
}