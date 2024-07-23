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
            tbxBirthPlace = new TextBox();
            lblBirthPlace = new Label();
            label3 = new Label();
            dTimePickerBirthDate = new DateTimePicker();
            lblOccupation = new Label();
            tbxIdentityNumber = new TextBox();
            label1 = new Label();
            lblGender = new Label();
            radioBtnFemale = new RadioButton();
            radioBtnMale = new RadioButton();
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
            dgwPersons.Size = new Size(1010, 190);
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
            grpBxAddPerson.Controls.Add(checkBxIsPrimaryEmail);
            grpBxAddPerson.Controls.Add(checkBxIsPrimaryPhoneNumber);
            grpBxAddPerson.Controls.Add(tbxEmail);
            grpBxAddPerson.Controls.Add(lblEmail);
            grpBxAddPerson.Controls.Add(tbxPhoneNumber);
            grpBxAddPerson.Controls.Add(lblPhoneNumber);
            grpBxAddPerson.Controls.Add(checkBxIsBillingAddress);
            grpBxAddPerson.Controls.Add(cbxDistricts);
            grpBxAddPerson.Controls.Add(lblDistrict);
            grpBxAddPerson.Controls.Add(cbxCities);
            grpBxAddPerson.Controls.Add(lblCity);
            grpBxAddPerson.Controls.Add(label4);
            grpBxAddPerson.Controls.Add(richTbxAddressDetailDescription);
            grpBxAddPerson.Controls.Add(tbxAddressName);
            grpBxAddPerson.Controls.Add(lblAddressName);
            grpBxAddPerson.Controls.Add(cbxAddressTypes);
            grpBxAddPerson.Controls.Add(lblAddressType);
            grpBxAddPerson.Controls.Add(tbxBirthPlace);
            grpBxAddPerson.Controls.Add(lblBirthPlace);
            grpBxAddPerson.Controls.Add(label3);
            grpBxAddPerson.Controls.Add(dTimePickerBirthDate);
            grpBxAddPerson.Controls.Add(lblOccupation);
            grpBxAddPerson.Controls.Add(tbxIdentityNumber);
            grpBxAddPerson.Controls.Add(label1);
            grpBxAddPerson.Controls.Add(lblGender);
            grpBxAddPerson.Controls.Add(radioBtnFemale);
            grpBxAddPerson.Controls.Add(radioBtnMale);
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
            grpBxAddPerson.Size = new Size(1010, 390);
            grpBxAddPerson.TabIndex = 4;
            grpBxAddPerson.TabStop = false;
            grpBxAddPerson.Text = "Gerçek müşteri ekle";
            grpBxAddPerson.Enter += grpBxAddPerson_Enter;
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
            // tbxEmail
            // 
            tbxEmail.Location = new Point(524, 274);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(209, 23);
            tbxEmail.TabIndex = 36;
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
            // tbxPhoneNumber
            // 
            tbxPhoneNumber.Location = new Point(769, 207);
            tbxPhoneNumber.MaxLength = 10;
            tbxPhoneNumber.Name = "tbxPhoneNumber";
            tbxPhoneNumber.PlaceholderText = "5XXXXXXXXX";
            tbxPhoneNumber.Size = new Size(209, 23);
            tbxPhoneNumber.TabIndex = 34;
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
            // lblDistrict
            // 
            lblDistrict.AutoSize = true;
            lblDistrict.Location = new Point(524, 186);
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
            cbxCities.Location = new Point(272, 207);
            cbxCities.Name = "cbxCities";
            cbxCities.Size = new Size(209, 23);
            cbxCities.TabIndex = 29;
            cbxCities.SelectedIndexChanged += cbxCities_SelectedIndexChanged;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 186);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 27;
            label4.Text = "Adresiniz:";
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
            // tbxAddressName
            // 
            tbxAddressName.Location = new Point(272, 274);
            tbxAddressName.Name = "tbxAddressName";
            tbxAddressName.Size = new Size(209, 23);
            tbxAddressName.TabIndex = 22;
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
            // lblAddressType
            // 
            lblAddressType.AutoSize = true;
            lblAddressType.Location = new Point(769, 119);
            lblAddressType.Name = "lblAddressType";
            lblAddressType.Size = new Size(62, 15);
            lblAddressType.TabIndex = 19;
            lblAddressType.Text = "Adres Tipi:";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 119);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 16;
            label3.Text = "Doğum Tarihi:";
            // 
            // dTimePickerBirthDate
            // 
            dTimePickerBirthDate.Location = new Point(272, 137);
            dTimePickerBirthDate.Name = "dTimePickerBirthDate";
            dTimePickerBirthDate.Size = new Size(209, 23);
            dTimePickerBirthDate.TabIndex = 15;
            dTimePickerBirthDate.Value = new DateTime(2024, 7, 23, 0, 0, 0, 0);
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
            // tbxIdentityNumber
            // 
            tbxIdentityNumber.Location = new Point(769, 73);
            tbxIdentityNumber.MaxLength = 11;
            tbxIdentityNumber.Name = "tbxIdentityNumber";
            tbxIdentityNumber.Size = new Size(209, 23);
            tbxIdentityNumber.TabIndex = 13;
            tbxIdentityNumber.KeyPress += tbxIdentityNumber_KeyPress;
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
            // lblPersonIdentityType
            // 
            lblPersonIdentityType.AutoSize = true;
            lblPersonIdentityType.Location = new Point(524, 55);
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
            cbxPersonIdentityType.Location = new Point(524, 73);
            cbxPersonIdentityType.Name = "cbxPersonIdentityType";
            cbxPersonIdentityType.Size = new Size(209, 23);
            cbxPersonIdentityType.TabIndex = 6;
            // 
            // btnAddPerson
            // 
            btnAddPerson.BackColor = Color.LightGreen;
            btnAddPerson.Location = new Point(895, 352);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(109, 32);
            btnAddPerson.TabIndex = 5;
            btnAddPerson.Text = "Ekle";
            btnAddPerson.UseVisualStyleBackColor = false;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // UserControlAddPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpBxAddPerson);
            Controls.Add(dgwPersons);
            Name = "UserControlAddPerson";
            Size = new Size(1079, 630);
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
        private RadioButton radioBtnFemale;
        private RadioButton radioBtnMale;
        private Label lblGender;
        private Label label3;
        private DateTimePicker dTimePickerBirthDate;
        private Label lblOccupation;
        private TextBox tbxIdentityNumber;
        private Label label1;
        private TextBox tbxBirthPlace;
        private Label lblBirthPlace;
        private Label lblAddressType;
        private ComboBox cbxAddressTypes;
        private TextBox tbxAddressName;
        private Label lblAddressName;
        private Label label4;
        private RichTextBox richTbxAddressDetailDescription;
        private ComboBox cbxCities;
        private Label lblCity;
        private ComboBox cbxDistricts;
        private Label lblDistrict;
        private CheckBox checkBxIsBillingAddress;
        private TextBox tbxPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox tbxEmail;
        private Label lblEmail;
        private CheckBox checkBxIsPrimaryPhoneNumber;
        private CheckBox checkBxIsPrimaryEmail;
    }
}
