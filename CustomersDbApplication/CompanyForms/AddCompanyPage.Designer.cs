namespace CustomersDbApplication.CompanyForms
{
    partial class AddCompanyPage
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
            grpBxAddCompany = new GroupBox();
            tbxEmployeeCount = new TextBox();
            btnExit = new Button();
            checkBxIsPrimaryEmail = new CheckBox();
            checkBxIsPrimaryPhoneNumber = new CheckBox();
            tbxEmail = new TextBox();
            lblEmail = new Label();
            tbxPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            checkBxIsBillingAddress = new CheckBox();
            cbxDistricts = new ComboBox();
            lblDistrict = new Label();
            cbxCities = new ComboBox();
            lblCity = new Label();
            label4 = new Label();
            richTbxAddressDetailDescription = new RichTextBox();
            tbxAddressName = new TextBox();
            lblAddressName = new Label();
            cbxAddressTypes = new ComboBox();
            lblAddressType = new Label();
            lblEstablishedDate = new Label();
            dTimePickerEstablishedDate = new DateTimePicker();
            lblEmployeeCount = new Label();
            tbxTaxNumber = new TextBox();
            lblTaxNumber = new Label();
            lblCompanySector = new Label();
            cbxCompanySectors = new ComboBox();
            btnAddCompany = new Button();
            tbxCustomerName = new TextBox();
            lblName = new Label();
            grpBxAddCompany.SuspendLayout();
            SuspendLayout();
            // 
            // grpBxAddCompany
            // 
            grpBxAddCompany.Controls.Add(tbxEmployeeCount);
            grpBxAddCompany.Controls.Add(btnExit);
            grpBxAddCompany.Controls.Add(checkBxIsPrimaryEmail);
            grpBxAddCompany.Controls.Add(checkBxIsPrimaryPhoneNumber);
            grpBxAddCompany.Controls.Add(tbxEmail);
            grpBxAddCompany.Controls.Add(lblEmail);
            grpBxAddCompany.Controls.Add(tbxPhoneNumber);
            grpBxAddCompany.Controls.Add(lblPhoneNumber);
            grpBxAddCompany.Controls.Add(checkBxIsBillingAddress);
            grpBxAddCompany.Controls.Add(cbxDistricts);
            grpBxAddCompany.Controls.Add(lblDistrict);
            grpBxAddCompany.Controls.Add(cbxCities);
            grpBxAddCompany.Controls.Add(lblCity);
            grpBxAddCompany.Controls.Add(label4);
            grpBxAddCompany.Controls.Add(richTbxAddressDetailDescription);
            grpBxAddCompany.Controls.Add(tbxAddressName);
            grpBxAddCompany.Controls.Add(lblAddressName);
            grpBxAddCompany.Controls.Add(cbxAddressTypes);
            grpBxAddCompany.Controls.Add(lblAddressType);
            grpBxAddCompany.Controls.Add(lblEstablishedDate);
            grpBxAddCompany.Controls.Add(dTimePickerEstablishedDate);
            grpBxAddCompany.Controls.Add(lblEmployeeCount);
            grpBxAddCompany.Controls.Add(tbxTaxNumber);
            grpBxAddCompany.Controls.Add(lblTaxNumber);
            grpBxAddCompany.Controls.Add(lblCompanySector);
            grpBxAddCompany.Controls.Add(cbxCompanySectors);
            grpBxAddCompany.Controls.Add(btnAddCompany);
            grpBxAddCompany.Controls.Add(tbxCustomerName);
            grpBxAddCompany.Controls.Add(lblName);
            grpBxAddCompany.ForeColor = Color.MidnightBlue;
            grpBxAddCompany.Location = new Point(12, 12);
            grpBxAddCompany.Name = "grpBxAddCompany";
            grpBxAddCompany.Size = new Size(1010, 370);
            grpBxAddCompany.TabIndex = 7;
            grpBxAddCompany.TabStop = false;
            grpBxAddCompany.Text = "Tüzel müşteri ekle";
            // 
            // tbxEmployeeCount
            // 
            tbxEmployeeCount.Location = new Point(16, 114);
            tbxEmployeeCount.Name = "tbxEmployeeCount";
            tbxEmployeeCount.Size = new Size(209, 23);
            tbxEmployeeCount.TabIndex = 40;
            tbxEmployeeCount.KeyPress += tbxEmployeeCount_KeyPress;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 123, 123);
            btnExit.Cursor = Cursors.Hand;
            btnExit.ForeColor = Color.Maroon;
            btnExit.Location = new Point(890, 321);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(87, 32);
            btnExit.TabIndex = 39;
            btnExit.Text = "Kapat";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // checkBxIsPrimaryEmail
            // 
            checkBxIsPrimaryEmail.AutoSize = true;
            checkBxIsPrimaryEmail.Location = new Point(523, 277);
            checkBxIsPrimaryEmail.Name = "checkBxIsPrimaryEmail";
            checkBxIsPrimaryEmail.Size = new Size(119, 19);
            checkBxIsPrimaryEmail.TabIndex = 38;
            checkBxIsPrimaryEmail.Text = "Birincil email yap.";
            checkBxIsPrimaryEmail.UseVisualStyleBackColor = true;
            // 
            // checkBxIsPrimaryPhoneNumber
            // 
            checkBxIsPrimaryPhoneNumber.AutoSize = true;
            checkBxIsPrimaryPhoneNumber.Location = new Point(768, 143);
            checkBxIsPrimaryPhoneNumber.Name = "checkBxIsPrimaryPhoneNumber";
            checkBxIsPrimaryPhoneNumber.Size = new Size(142, 19);
            checkBxIsPrimaryPhoneNumber.TabIndex = 37;
            checkBxIsPrimaryPhoneNumber.Text = "Birincil numaram yap.";
            checkBxIsPrimaryPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(523, 248);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(209, 23);
            tbxEmail.TabIndex = 36;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(523, 227);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 35;
            lblEmail.Text = "Email:";
            // 
            // tbxPhoneNumber
            // 
            tbxPhoneNumber.Location = new Point(768, 114);
            tbxPhoneNumber.MaxLength = 10;
            tbxPhoneNumber.Name = "tbxPhoneNumber";
            tbxPhoneNumber.PlaceholderText = "5XXXXXXXXX";
            tbxPhoneNumber.Size = new Size(209, 23);
            tbxPhoneNumber.TabIndex = 34;
            tbxPhoneNumber.KeyPress += tbxPhoneNumber_KeyPress;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(768, 93);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(100, 15);
            lblPhoneNumber.TabIndex = 33;
            lblPhoneNumber.Text = "Telefon numarası:";
            // 
            // checkBxIsBillingAddress
            // 
            checkBxIsBillingAddress.AutoSize = true;
            checkBxIsBillingAddress.Location = new Point(16, 334);
            checkBxIsBillingAddress.Name = "checkBxIsBillingAddress";
            checkBxIsBillingAddress.Size = new Size(159, 19);
            checkBxIsBillingAddress.TabIndex = 32;
            checkBxIsBillingAddress.Text = "Bu benim fatura adresim.";
            checkBxIsBillingAddress.UseVisualStyleBackColor = true;
            // 
            // cbxDistricts
            // 
            cbxDistricts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxDistricts.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxDistricts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDistricts.FormattingEnabled = true;
            cbxDistricts.Location = new Point(523, 181);
            cbxDistricts.Name = "cbxDistricts";
            cbxDistricts.Size = new Size(209, 23);
            cbxDistricts.TabIndex = 31;
            // 
            // lblDistrict
            // 
            lblDistrict.AutoSize = true;
            lblDistrict.Location = new Point(523, 160);
            lblDistrict.Name = "lblDistrict";
            lblDistrict.Size = new Size(28, 15);
            lblDistrict.TabIndex = 30;
            lblDistrict.Text = "İlçe:";
            // 
            // cbxCities
            // 
            cbxCities.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxCities.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxCities.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCities.FormattingEnabled = true;
            cbxCities.Location = new Point(271, 181);
            cbxCities.Name = "cbxCities";
            cbxCities.Size = new Size(209, 23);
            cbxCities.TabIndex = 29;
            cbxCities.SelectedIndexChanged += cbxCities_SelectedIndexChanged;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(271, 160);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(36, 15);
            lblCity.TabIndex = 28;
            lblCity.Text = "Şehir:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 160);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 27;
            label4.Text = "Adresiniz:";
            // 
            // richTbxAddressDetailDescription
            // 
            richTbxAddressDetailDescription.DetectUrls = false;
            richTbxAddressDetailDescription.Location = new Point(16, 178);
            richTbxAddressDetailDescription.MaxLength = 2000;
            richTbxAddressDetailDescription.Name = "richTbxAddressDetailDescription";
            richTbxAddressDetailDescription.Size = new Size(209, 148);
            richTbxAddressDetailDescription.TabIndex = 26;
            richTbxAddressDetailDescription.Text = "";
            // 
            // tbxAddressName
            // 
            tbxAddressName.Location = new Point(271, 248);
            tbxAddressName.Name = "tbxAddressName";
            tbxAddressName.Size = new Size(209, 23);
            tbxAddressName.TabIndex = 22;
            // 
            // lblAddressName
            // 
            lblAddressName.AutoSize = true;
            lblAddressName.Location = new Point(271, 227);
            lblAddressName.Name = "lblAddressName";
            lblAddressName.Size = new Size(65, 15);
            lblAddressName.TabIndex = 21;
            lblAddressName.Text = "Adres ismi:";
            // 
            // cbxAddressTypes
            // 
            cbxAddressTypes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxAddressTypes.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxAddressTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAddressTypes.FormattingEnabled = true;
            cbxAddressTypes.Location = new Point(523, 111);
            cbxAddressTypes.Name = "cbxAddressTypes";
            cbxAddressTypes.Size = new Size(209, 23);
            cbxAddressTypes.TabIndex = 20;
            // 
            // lblAddressType
            // 
            lblAddressType.AutoSize = true;
            lblAddressType.Location = new Point(523, 90);
            lblAddressType.Name = "lblAddressType";
            lblAddressType.Size = new Size(62, 15);
            lblAddressType.TabIndex = 19;
            lblAddressType.Text = "Adres Tipi:";
            // 
            // lblEstablishedDate
            // 
            lblEstablishedDate.AutoSize = true;
            lblEstablishedDate.Location = new Point(271, 93);
            lblEstablishedDate.Name = "lblEstablishedDate";
            lblEstablishedDate.Size = new Size(81, 15);
            lblEstablishedDate.TabIndex = 16;
            lblEstablishedDate.Text = "Kuruluş Tarihi:";
            // 
            // dTimePickerEstablishedDate
            // 
            dTimePickerEstablishedDate.Location = new Point(271, 111);
            dTimePickerEstablishedDate.Name = "dTimePickerEstablishedDate";
            dTimePickerEstablishedDate.Size = new Size(209, 23);
            dTimePickerEstablishedDate.TabIndex = 15;
            dTimePickerEstablishedDate.Value = new DateTime(2024, 7, 23, 0, 0, 0, 0);
            // 
            // lblEmployeeCount
            // 
            lblEmployeeCount.AutoSize = true;
            lblEmployeeCount.Location = new Point(16, 93);
            lblEmployeeCount.Name = "lblEmployeeCount";
            lblEmployeeCount.Size = new Size(128, 15);
            lblEmployeeCount.TabIndex = 14;
            lblEmployeeCount.Text = "Çalışan Personel Sayısı:";
            // 
            // tbxTaxNumber
            // 
            tbxTaxNumber.Location = new Point(768, 47);
            tbxTaxNumber.MaxLength = 10;
            tbxTaxNumber.Name = "tbxTaxNumber";
            tbxTaxNumber.Size = new Size(209, 23);
            tbxTaxNumber.TabIndex = 13;
            tbxTaxNumber.KeyPress += tbxTaxNumber_KeyPress;
            // 
            // lblTaxNumber
            // 
            lblTaxNumber.AutoSize = true;
            lblTaxNumber.Location = new Point(768, 29);
            lblTaxNumber.Name = "lblTaxNumber";
            lblTaxNumber.Size = new Size(90, 15);
            lblTaxNumber.TabIndex = 12;
            lblTaxNumber.Text = "Vergi Numarası:";
            // 
            // lblCompanySector
            // 
            lblCompanySector.AutoSize = true;
            lblCompanySector.Location = new Point(523, 29);
            lblCompanySector.Name = "lblCompanySector";
            lblCompanySector.Size = new Size(43, 15);
            lblCompanySector.TabIndex = 7;
            lblCompanySector.Text = "Sektör:";
            // 
            // cbxCompanySectors
            // 
            cbxCompanySectors.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxCompanySectors.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxCompanySectors.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCompanySectors.FormattingEnabled = true;
            cbxCompanySectors.Location = new Point(523, 47);
            cbxCompanySectors.Name = "cbxCompanySectors";
            cbxCompanySectors.Size = new Size(209, 23);
            cbxCompanySectors.TabIndex = 6;
            // 
            // btnAddCompany
            // 
            btnAddCompany.BackColor = Color.LightGreen;
            btnAddCompany.Cursor = Cursors.Hand;
            btnAddCompany.Location = new Point(768, 321);
            btnAddCompany.Name = "btnAddCompany";
            btnAddCompany.Size = new Size(87, 32);
            btnAddCompany.TabIndex = 5;
            btnAddCompany.Text = "Ekle";
            btnAddCompany.UseVisualStyleBackColor = false;
            btnAddCompany.Click += btnAddCompany_Click;
            // 
            // tbxCustomerName
            // 
            tbxCustomerName.Location = new Point(16, 47);
            tbxCustomerName.Name = "tbxCustomerName";
            tbxCustomerName.Size = new Size(464, 23);
            tbxCustomerName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(16, 29);
            lblName.Name = "lblName";
            lblName.Size = new Size(69, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Müşteri adı:";
            // 
            // AddCompanyPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1036, 411);
            Controls.Add(grpBxAddCompany);
            Name = "AddCompanyPage";
            Text = "Tüzel Müşteri Ekleme Paneli";
            Load += AddCompanyPage_Load;
            grpBxAddCompany.ResumeLayout(false);
            grpBxAddCompany.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBxAddCompany;
        private Button btnExit;
        private CheckBox checkBxIsPrimaryEmail;
        private CheckBox checkBxIsPrimaryPhoneNumber;
        private TextBox tbxEmail;
        private Label lblEmail;
        private TextBox tbxPhoneNumber;
        private Label lblPhoneNumber;
        private CheckBox checkBxIsBillingAddress;
        private ComboBox cbxDistricts;
        private Label lblDistrict;
        private ComboBox cbxCities;
        private Label lblCity;
        private Label label4;
        private RichTextBox richTbxAddressDetailDescription;
        private TextBox tbxAddressName;
        private Label lblAddressName;
        private ComboBox cbxAddressTypes;
        private Label lblAddressType;
        private Label lblEstablishedDate;
        private DateTimePicker dTimePickerEstablishedDate;
        private Label lblEmployeeCount;
        private TextBox tbxTaxNumber;
        private Label lblTaxNumber;
        private Label lblCompanySector;
        private ComboBox cbxCompanySectors;
        private Button btnAddCompany;
        private TextBox tbxCustomerName;
        private Label lblName;
        private TextBox tbxEmployeeCount;
    }
}