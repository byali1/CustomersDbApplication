namespace CustomersDbApplication.PersonForms
{
    partial class UpdatePersonPage
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
            lblName = new Label();
            tbxCustomerName = new TextBox();
            btnUpdatePerson = new Button();
            cbxPersonIdentityType = new ComboBox();
            lblPersonIdentityType = new Label();
            cbxPersonOccupations = new ComboBox();
            label1 = new Label();
            tbxIdentityNumber = new TextBox();
            lblOccupation = new Label();
            dTimePickerBirthDate = new DateTimePicker();
            label3 = new Label();
            lblAddressType = new Label();
            cbxAddressTypes = new ComboBox();
            lblAddressName = new Label();
            tbxAddressName = new TextBox();
            richTbxAddressDetailDescription = new RichTextBox();
            label4 = new Label();
            lblCity = new Label();
            cbxCities = new ComboBox();
            lblDistrict = new Label();
            cbxDistricts = new ComboBox();
            checkBxIsBillingAddress = new CheckBox();
            lblPhoneNumber = new Label();
            tbxPhoneNumber = new TextBox();
            lblEmail = new Label();
            tbxEmail = new TextBox();
            checkBxIsPrimaryPhoneNumber = new CheckBox();
            checkBxIsPrimaryEmail = new CheckBox();
            btnExit = new Button();
            grpBxUpdatePerson = new GroupBox();
            tbxBirthPlace = new TextBox();
            lblBirthPlace = new Label();
            lblGender = new Label();
            radioBtnFemale = new RadioButton();
            radioBtnMale = new RadioButton();
            tbxCustomerLastName = new TextBox();
            label2 = new Label();
            grpBxUpdatePerson.SuspendLayout();
            SuspendLayout();
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
            // btnUpdatePerson
            // 
            btnUpdatePerson.BackColor = SystemColors.ActiveCaption;
            btnUpdatePerson.Cursor = Cursors.Hand;
            btnUpdatePerson.ForeColor = Color.Black;
            btnUpdatePerson.Location = new Point(769, 334);
            btnUpdatePerson.Name = "btnUpdatePerson";
            btnUpdatePerson.Size = new Size(109, 32);
            btnUpdatePerson.TabIndex = 5;
            btnUpdatePerson.Text = "Güncelle";
            btnUpdatePerson.UseVisualStyleBackColor = false;
            btnUpdatePerson.Click += btnUpdatePerson_Click;
            // 
            // cbxPersonIdentityType
            // 
            cbxPersonIdentityType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxPersonIdentityType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxPersonIdentityType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPersonIdentityType.FormattingEnabled = true;
            cbxPersonIdentityType.Location = new Point(524, 73);
            cbxPersonIdentityType.Name = "cbxPersonIdentityType";
            cbxPersonIdentityType.Size = new Size(209, 23);
            cbxPersonIdentityType.TabIndex = 6;
            // 
            // lblPersonIdentityType
            // 
            lblPersonIdentityType.AutoSize = true;
            lblPersonIdentityType.Location = new Point(524, 55);
            lblPersonIdentityType.Name = "lblPersonIdentityType";
            lblPersonIdentityType.Size = new Size(63, 15);
            lblPersonIdentityType.TabIndex = 7;
            lblPersonIdentityType.Text = "Kimlik tipi:";
            // 
            // cbxPersonOccupations
            // 
            cbxPersonOccupations.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxPersonOccupations.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxPersonOccupations.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPersonOccupations.FormattingEnabled = true;
            cbxPersonOccupations.Location = new Point(17, 137);
            cbxPersonOccupations.Name = "cbxPersonOccupations";
            cbxPersonOccupations.Size = new Size(209, 23);
            cbxPersonOccupations.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(769, 55);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 12;
            label1.Text = "TC Kimlik No:";
            // 
            // tbxIdentityNumber
            // 
            tbxIdentityNumber.Location = new Point(769, 73);
            tbxIdentityNumber.MaxLength = 11;
            tbxIdentityNumber.Name = "tbxIdentityNumber";
            tbxIdentityNumber.Size = new Size(209, 23);
            tbxIdentityNumber.TabIndex = 13;
            tbxIdentityNumber.KeyPress += tbxIdentityNumber_KeyPress;
            // 
            // lblOccupation
            // 
            lblOccupation.AutoSize = true;
            lblOccupation.Location = new Point(17, 119);
            lblOccupation.Name = "lblOccupation";
            lblOccupation.Size = new Size(47, 15);
            lblOccupation.TabIndex = 14;
            lblOccupation.Text = "Meslek:";
            // 
            // dTimePickerBirthDate
            // 
            dTimePickerBirthDate.Location = new Point(272, 137);
            dTimePickerBirthDate.Name = "dTimePickerBirthDate";
            dTimePickerBirthDate.Size = new Size(209, 23);
            dTimePickerBirthDate.TabIndex = 15;
            dTimePickerBirthDate.Value = new DateTime(2024, 7, 23, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 119);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 16;
            label3.Text = "Doğum Tarihi:";
            // 
            // lblAddressType
            // 
            lblAddressType.AutoSize = true;
            lblAddressType.Location = new Point(769, 119);
            lblAddressType.Name = "lblAddressType";
            lblAddressType.Size = new Size(62, 15);
            lblAddressType.TabIndex = 19;
            lblAddressType.Text = "Adres Tipi:";
            // 
            // cbxAddressTypes
            // 
            cbxAddressTypes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxAddressTypes.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxAddressTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAddressTypes.FormattingEnabled = true;
            cbxAddressTypes.Location = new Point(769, 140);
            cbxAddressTypes.Name = "cbxAddressTypes";
            cbxAddressTypes.Size = new Size(209, 23);
            cbxAddressTypes.TabIndex = 20;
            // 
            // lblAddressName
            // 
            lblAddressName.AutoSize = true;
            lblAddressName.Location = new Point(272, 253);
            lblAddressName.Name = "lblAddressName";
            lblAddressName.Size = new Size(65, 15);
            lblAddressName.TabIndex = 21;
            lblAddressName.Text = "Adres ismi:";
            // 
            // tbxAddressName
            // 
            tbxAddressName.Location = new Point(272, 274);
            tbxAddressName.Name = "tbxAddressName";
            tbxAddressName.Size = new Size(209, 23);
            tbxAddressName.TabIndex = 22;
            // 
            // richTbxAddressDetailDescription
            // 
            richTbxAddressDetailDescription.DetectUrls = false;
            richTbxAddressDetailDescription.Location = new Point(17, 204);
            richTbxAddressDetailDescription.MaxLength = 2000;
            richTbxAddressDetailDescription.Name = "richTbxAddressDetailDescription";
            richTbxAddressDetailDescription.Size = new Size(209, 148);
            richTbxAddressDetailDescription.TabIndex = 26;
            richTbxAddressDetailDescription.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 186);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 27;
            label4.Text = "Adresiniz:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(272, 186);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(36, 15);
            lblCity.TabIndex = 28;
            lblCity.Text = "Şehir:";
            // 
            // cbxCities
            // 
            cbxCities.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxCities.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxCities.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCities.FormattingEnabled = true;
            cbxCities.Location = new Point(272, 207);
            cbxCities.Name = "cbxCities";
            cbxCities.Size = new Size(209, 23);
            cbxCities.TabIndex = 29;
            cbxCities.SelectedIndexChanged += cbxCities_SelectedIndexChanged;
            // 
            // lblDistrict
            // 
            lblDistrict.AutoSize = true;
            lblDistrict.Location = new Point(524, 186);
            lblDistrict.Name = "lblDistrict";
            lblDistrict.Size = new Size(28, 15);
            lblDistrict.TabIndex = 30;
            lblDistrict.Text = "İlçe:";
            // 
            // cbxDistricts
            // 
            cbxDistricts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxDistricts.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxDistricts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDistricts.FormattingEnabled = true;
            cbxDistricts.Location = new Point(524, 207);
            cbxDistricts.Name = "cbxDistricts";
            cbxDistricts.Size = new Size(209, 23);
            cbxDistricts.TabIndex = 31;
            // 
            // checkBxIsBillingAddress
            // 
            checkBxIsBillingAddress.AutoSize = true;
            checkBxIsBillingAddress.Location = new Point(17, 360);
            checkBxIsBillingAddress.Name = "checkBxIsBillingAddress";
            checkBxIsBillingAddress.Size = new Size(159, 19);
            checkBxIsBillingAddress.TabIndex = 32;
            checkBxIsBillingAddress.Text = "Bu benim fatura adresim.";
            checkBxIsBillingAddress.UseVisualStyleBackColor = true;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(769, 186);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(100, 15);
            lblPhoneNumber.TabIndex = 33;
            lblPhoneNumber.Text = "Telefon numarası:";
            // 
            // tbxPhoneNumber
            // 
            tbxPhoneNumber.Location = new Point(769, 207);
            tbxPhoneNumber.MaxLength = 10;
            tbxPhoneNumber.Name = "tbxPhoneNumber";
            tbxPhoneNumber.PlaceholderText = "5XXXXXXXXX";
            tbxPhoneNumber.Size = new Size(209, 23);
            tbxPhoneNumber.TabIndex = 34;
            tbxPhoneNumber.KeyPress += tbxPhoneNumber_KeyPress;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(524, 253);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 35;
            lblEmail.Text = "Email:";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(524, 274);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(209, 23);
            tbxEmail.TabIndex = 36;
            // 
            // checkBxIsPrimaryPhoneNumber
            // 
            checkBxIsPrimaryPhoneNumber.AutoSize = true;
            checkBxIsPrimaryPhoneNumber.Location = new Point(769, 236);
            checkBxIsPrimaryPhoneNumber.Name = "checkBxIsPrimaryPhoneNumber";
            checkBxIsPrimaryPhoneNumber.Size = new Size(142, 19);
            checkBxIsPrimaryPhoneNumber.TabIndex = 37;
            checkBxIsPrimaryPhoneNumber.Text = "Birincil numaram yap.";
            checkBxIsPrimaryPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // checkBxIsPrimaryEmail
            // 
            checkBxIsPrimaryEmail.AutoSize = true;
            checkBxIsPrimaryEmail.Location = new Point(524, 303);
            checkBxIsPrimaryEmail.Name = "checkBxIsPrimaryEmail";
            checkBxIsPrimaryEmail.Size = new Size(119, 19);
            checkBxIsPrimaryEmail.TabIndex = 38;
            checkBxIsPrimaryEmail.Text = "Birincil email yap.";
            checkBxIsPrimaryEmail.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 123, 123);
            btnExit.Cursor = Cursors.Hand;
            btnExit.ForeColor = Color.Maroon;
            btnExit.Location = new Point(895, 334);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(83, 32);
            btnExit.TabIndex = 39;
            btnExit.Text = "Kapat";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // grpBxUpdatePerson
            // 
            grpBxUpdatePerson.Controls.Add(btnExit);
            grpBxUpdatePerson.Controls.Add(checkBxIsPrimaryEmail);
            grpBxUpdatePerson.Controls.Add(checkBxIsPrimaryPhoneNumber);
            grpBxUpdatePerson.Controls.Add(tbxEmail);
            grpBxUpdatePerson.Controls.Add(lblEmail);
            grpBxUpdatePerson.Controls.Add(tbxPhoneNumber);
            grpBxUpdatePerson.Controls.Add(lblPhoneNumber);
            grpBxUpdatePerson.Controls.Add(checkBxIsBillingAddress);
            grpBxUpdatePerson.Controls.Add(cbxDistricts);
            grpBxUpdatePerson.Controls.Add(lblDistrict);
            grpBxUpdatePerson.Controls.Add(cbxCities);
            grpBxUpdatePerson.Controls.Add(lblCity);
            grpBxUpdatePerson.Controls.Add(label4);
            grpBxUpdatePerson.Controls.Add(richTbxAddressDetailDescription);
            grpBxUpdatePerson.Controls.Add(tbxAddressName);
            grpBxUpdatePerson.Controls.Add(lblAddressName);
            grpBxUpdatePerson.Controls.Add(cbxAddressTypes);
            grpBxUpdatePerson.Controls.Add(lblAddressType);
            grpBxUpdatePerson.Controls.Add(tbxBirthPlace);
            grpBxUpdatePerson.Controls.Add(lblBirthPlace);
            grpBxUpdatePerson.Controls.Add(label3);
            grpBxUpdatePerson.Controls.Add(dTimePickerBirthDate);
            grpBxUpdatePerson.Controls.Add(lblOccupation);
            grpBxUpdatePerson.Controls.Add(tbxIdentityNumber);
            grpBxUpdatePerson.Controls.Add(label1);
            grpBxUpdatePerson.Controls.Add(lblGender);
            grpBxUpdatePerson.Controls.Add(radioBtnFemale);
            grpBxUpdatePerson.Controls.Add(radioBtnMale);
            grpBxUpdatePerson.Controls.Add(cbxPersonOccupations);
            grpBxUpdatePerson.Controls.Add(lblPersonIdentityType);
            grpBxUpdatePerson.Controls.Add(cbxPersonIdentityType);
            grpBxUpdatePerson.Controls.Add(btnUpdatePerson);
            grpBxUpdatePerson.Controls.Add(tbxCustomerLastName);
            grpBxUpdatePerson.Controls.Add(tbxCustomerName);
            grpBxUpdatePerson.Controls.Add(lblName);
            grpBxUpdatePerson.Controls.Add(label2);
            grpBxUpdatePerson.ForeColor = Color.Firebrick;
            grpBxUpdatePerson.Location = new Point(32, 32);
            grpBxUpdatePerson.Name = "grpBxUpdatePerson";
            grpBxUpdatePerson.Size = new Size(1010, 390);
            grpBxUpdatePerson.TabIndex = 7;
            grpBxUpdatePerson.TabStop = false;
            grpBxUpdatePerson.Text = "Gerçek müşteri güncelle";
            // 
            // tbxBirthPlace
            // 
            tbxBirthPlace.Location = new Point(524, 140);
            tbxBirthPlace.Name = "tbxBirthPlace";
            tbxBirthPlace.Size = new Size(209, 23);
            tbxBirthPlace.TabIndex = 18;
            // 
            // lblBirthPlace
            // 
            lblBirthPlace.AutoSize = true;
            lblBirthPlace.Location = new Point(524, 119);
            lblBirthPlace.Name = "lblBirthPlace";
            lblBirthPlace.Size = new Size(72, 15);
            lblBirthPlace.TabIndex = 17;
            lblBirthPlace.Text = "Doğum Yeri:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(272, 312);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(52, 15);
            lblGender.TabIndex = 11;
            lblGender.Text = "Cinsiyet:";
            // 
            // radioBtnFemale
            // 
            radioBtnFemale.AutoSize = true;
            radioBtnFemale.Location = new Point(340, 334);
            radioBtnFemale.Name = "radioBtnFemale";
            radioBtnFemale.Size = new Size(55, 19);
            radioBtnFemale.TabIndex = 10;
            radioBtnFemale.TabStop = true;
            radioBtnFemale.Text = "Kadın";
            radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // radioBtnMale
            // 
            radioBtnMale.AutoSize = true;
            radioBtnMale.Location = new Point(272, 334);
            radioBtnMale.Name = "radioBtnMale";
            radioBtnMale.Size = new Size(53, 19);
            radioBtnMale.TabIndex = 9;
            radioBtnMale.TabStop = true;
            radioBtnMale.Text = "Erkek";
            radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // tbxCustomerLastName
            // 
            tbxCustomerLastName.Location = new Point(272, 73);
            tbxCustomerLastName.Name = "tbxCustomerLastName";
            tbxCustomerLastName.Size = new Size(209, 23);
            tbxCustomerLastName.TabIndex = 4;
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
            // UpdatePersonPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 447);
            Controls.Add(grpBxUpdatePerson);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UpdatePersonPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerçek Müşteri Güncelleme Paneli";
            Load += UpdatePersonPage_Load;
            grpBxUpdatePerson.ResumeLayout(false);
            grpBxUpdatePerson.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblName;
        private TextBox tbxCustomerName;
        private Button btnUpdatePerson;
        private ComboBox cbxPersonIdentityType;
        private Label lblPersonIdentityType;
        private ComboBox cbxPersonOccupations;
        private Label label1;
        private TextBox tbxIdentityNumber;
        private Label lblOccupation;
        private DateTimePicker dTimePickerBirthDate;
        private Label label3;
        private Label lblAddressType;
        private ComboBox cbxAddressTypes;
        private Label lblAddressName;
        private TextBox tbxAddressName;
        private RichTextBox richTbxAddressDetailDescription;
        private Label label4;
        private Label lblCity;
        private ComboBox cbxCities;
        private Label lblDistrict;
        private ComboBox cbxDistricts;
        private CheckBox checkBxIsBillingAddress;
        private Label lblPhoneNumber;
        private TextBox tbxPhoneNumber;
        private Label lblEmail;
        private TextBox tbxEmail;
        private CheckBox checkBxIsPrimaryPhoneNumber;
        private CheckBox checkBxIsPrimaryEmail;
        private Button btnExit;
        private GroupBox grpBxUpdatePerson;
        private TextBox tbxBirthPlace;
        private Label lblBirthPlace;
        private Label lblGender;
        private RadioButton radioBtnFemale;
        private RadioButton radioBtnMale;
        private TextBox tbxCustomerLastName;
        private Label label2;
    }
}