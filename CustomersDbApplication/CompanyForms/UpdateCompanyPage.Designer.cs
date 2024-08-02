namespace CustomersDbApplication.CompanyForms
{
    partial class UpdateCompanyPage
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
            grpBxUpdateCompany = new GroupBox();
            btnExit = new Button();
            btnUpdateCompany = new Button();
            tbxEmployeeCount = new TextBox();
            checkBxIsPrimaryEmail = new CheckBox();
            checkBxIsPrimaryPhoneNumber = new CheckBox();
            tbxEmail = new TextBox();
            label2 = new Label();
            tbxPhoneNumber = new TextBox();
            label5 = new Label();
            checkBxIsBillingAddress = new CheckBox();
            cbxDistricts = new ComboBox();
            label6 = new Label();
            cbxCities = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            richTbxAddressDetailDescription = new RichTextBox();
            tbxAddressName = new TextBox();
            label9 = new Label();
            cbxAddressTypes = new ComboBox();
            label10 = new Label();
            lblEstablishedDate = new Label();
            dTimePickerEstablishedDate = new DateTimePicker();
            lblEmployeeCount = new Label();
            tbxTaxNumber = new TextBox();
            lblTaxNumber = new Label();
            lblCompanySector = new Label();
            cbxCompanySectors = new ComboBox();
            tbxCompanyName = new TextBox();
            label11 = new Label();
            grpBxUpdateCompany.SuspendLayout();
            SuspendLayout();
            // 
            // grpBxUpdateCompany
            // 
            grpBxUpdateCompany.Controls.Add(btnExit);
            grpBxUpdateCompany.Controls.Add(btnUpdateCompany);
            grpBxUpdateCompany.Controls.Add(tbxEmployeeCount);
            grpBxUpdateCompany.Controls.Add(checkBxIsPrimaryEmail);
            grpBxUpdateCompany.Controls.Add(checkBxIsPrimaryPhoneNumber);
            grpBxUpdateCompany.Controls.Add(tbxEmail);
            grpBxUpdateCompany.Controls.Add(label2);
            grpBxUpdateCompany.Controls.Add(tbxPhoneNumber);
            grpBxUpdateCompany.Controls.Add(label5);
            grpBxUpdateCompany.Controls.Add(checkBxIsBillingAddress);
            grpBxUpdateCompany.Controls.Add(cbxDistricts);
            grpBxUpdateCompany.Controls.Add(label6);
            grpBxUpdateCompany.Controls.Add(cbxCities);
            grpBxUpdateCompany.Controls.Add(label7);
            grpBxUpdateCompany.Controls.Add(label8);
            grpBxUpdateCompany.Controls.Add(richTbxAddressDetailDescription);
            grpBxUpdateCompany.Controls.Add(tbxAddressName);
            grpBxUpdateCompany.Controls.Add(label9);
            grpBxUpdateCompany.Controls.Add(cbxAddressTypes);
            grpBxUpdateCompany.Controls.Add(label10);
            grpBxUpdateCompany.Controls.Add(lblEstablishedDate);
            grpBxUpdateCompany.Controls.Add(dTimePickerEstablishedDate);
            grpBxUpdateCompany.Controls.Add(lblEmployeeCount);
            grpBxUpdateCompany.Controls.Add(tbxTaxNumber);
            grpBxUpdateCompany.Controls.Add(lblTaxNumber);
            grpBxUpdateCompany.Controls.Add(lblCompanySector);
            grpBxUpdateCompany.Controls.Add(cbxCompanySectors);
            grpBxUpdateCompany.Controls.Add(tbxCompanyName);
            grpBxUpdateCompany.Controls.Add(label11);
            grpBxUpdateCompany.ForeColor = Color.MidnightBlue;
            grpBxUpdateCompany.Location = new Point(27, 26);
            grpBxUpdateCompany.Name = "grpBxUpdateCompany";
            grpBxUpdateCompany.Size = new Size(1010, 370);
            grpBxUpdateCompany.TabIndex = 9;
            grpBxUpdateCompany.TabStop = false;
            grpBxUpdateCompany.Text = "Tüzel müşteri ekle";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 123, 123);
            btnExit.Cursor = Cursors.Hand;
            btnExit.ForeColor = Color.Maroon;
            btnExit.Location = new Point(894, 309);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(83, 32);
            btnExit.TabIndex = 42;
            btnExit.Text = "Kapat";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdateCompany
            // 
            btnUpdateCompany.BackColor = SystemColors.ActiveCaption;
            btnUpdateCompany.Cursor = Cursors.Hand;
            btnUpdateCompany.ForeColor = Color.Black;
            btnUpdateCompany.Location = new Point(768, 309);
            btnUpdateCompany.Name = "btnUpdateCompany";
            btnUpdateCompany.Size = new Size(109, 32);
            btnUpdateCompany.TabIndex = 41;
            btnUpdateCompany.Text = "Güncelle";
            btnUpdateCompany.UseVisualStyleBackColor = false;
            btnUpdateCompany.Click += btnUpdateCompany_Click;
            // 
            // tbxEmployeeCount
            // 
            tbxEmployeeCount.Location = new Point(16, 114);
            tbxEmployeeCount.Name = "tbxEmployeeCount";
            tbxEmployeeCount.Size = new Size(209, 23);
            tbxEmployeeCount.TabIndex = 40;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(523, 227);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 35;
            label2.Text = "Email:";
            // 
            // tbxPhoneNumber
            // 
            tbxPhoneNumber.Location = new Point(768, 114);
            tbxPhoneNumber.MaxLength = 10;
            tbxPhoneNumber.Name = "tbxPhoneNumber";
            tbxPhoneNumber.PlaceholderText = "5XXXXXXXXX";
            tbxPhoneNumber.Size = new Size(209, 23);
            tbxPhoneNumber.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(768, 93);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 33;
            label5.Text = "Telefon numarası:";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(523, 160);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 30;
            label6.Text = "İlçe:";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(271, 160);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 28;
            label7.Text = "Şehir:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 160);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 27;
            label8.Text = "Adresiniz:";
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(271, 227);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 21;
            label9.Text = "Adres ismi:";
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(523, 90);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 19;
            label10.Text = "Adres Tipi:";
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
            // tbxCompanyName
            // 
            tbxCompanyName.Location = new Point(16, 47);
            tbxCompanyName.Name = "tbxCompanyName";
            tbxCompanyName.Size = new Size(464, 23);
            tbxCompanyName.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 29);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 1;
            label11.Text = "Müşteri adı:";
            // 
            // UpdateCompanyPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 424);
            Controls.Add(grpBxUpdateCompany);
            MaximizeBox = false;
            Name = "UpdateCompanyPage";
            Text = "Tüzel Müşteri Güncelleme Paneli";
            Load += UpdateCompanyPage_Load;
            grpBxUpdateCompany.ResumeLayout(false);
            grpBxUpdateCompany.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBxUpdateCompany;
        private Button btnExit;
        private Button btnUpdateCompany;
        private TextBox tbxEmployeeCount;
        private CheckBox checkBxIsPrimaryEmail;
        private CheckBox checkBxIsPrimaryPhoneNumber;
        private TextBox tbxEmail;
        private Label label2;
        private TextBox tbxPhoneNumber;
        private Label label5;
        private CheckBox checkBxIsBillingAddress;
        private ComboBox cbxDistricts;
        private Label label6;
        private ComboBox cbxCities;
        private Label label7;
        private Label label8;
        private RichTextBox richTbxAddressDetailDescription;
        private TextBox tbxAddressName;
        private Label label9;
        private ComboBox cbxAddressTypes;
        private Label label10;
        private Label lblEstablishedDate;
        private DateTimePicker dTimePickerEstablishedDate;
        private Label lblEmployeeCount;
        private TextBox tbxTaxNumber;
        private Label lblTaxNumber;
        private Label lblCompanySector;
        private ComboBox cbxCompanySectors;
        private TextBox tbxCompanyName;
        private Label label11;
    }
}