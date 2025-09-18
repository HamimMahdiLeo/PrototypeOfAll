namespace PrototypeOfAll
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.QualificationTextBox = new System.Windows.Forms.TextBox();
            this.QualificationLabel = new System.Windows.Forms.Label();
            this.DiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.DiagnosisLabel = new System.Windows.Forms.Label();
            this.BloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.DOB_DTP = new System.Windows.Forms.DateTimePicker();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.Label();
            this.BloodGroupLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.GeneralInfoHeadingLabel = new System.Windows.Forms.Label();
            this.NextToPanel2Button = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.ExitFromSignupButton = new System.Windows.Forms.Button();
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.BackToPanel1 = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.AccountInfoHeadingLabel = new System.Windows.Forms.Label();
            this.SignupButton = new System.Windows.Forms.Button();
            this.GeneralPanel.SuspendLayout();
            this.AccountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.AllowDrop = true;
            this.GeneralPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GeneralPanel.BackgroundImage")));
            this.GeneralPanel.Controls.Add(this.AddressTextBox);
            this.GeneralPanel.Controls.Add(this.AddressLabel);
            this.GeneralPanel.Controls.Add(this.QualificationTextBox);
            this.GeneralPanel.Controls.Add(this.QualificationLabel);
            this.GeneralPanel.Controls.Add(this.DiagnosisTextBox);
            this.GeneralPanel.Controls.Add(this.DiagnosisLabel);
            this.GeneralPanel.Controls.Add(this.BloodGroupComboBox);
            this.GeneralPanel.Controls.Add(this.CategoryComboBox);
            this.GeneralPanel.Controls.Add(this.GenderComboBox);
            this.GeneralPanel.Controls.Add(this.DOB_DTP);
            this.GeneralPanel.Controls.Add(this.ContactTextBox);
            this.GeneralPanel.Controls.Add(this.AgeTextBox);
            this.GeneralPanel.Controls.Add(this.FullNameTextBox);
            this.GeneralPanel.Controls.Add(this.Category);
            this.GeneralPanel.Controls.Add(this.BloodGroupLabel);
            this.GeneralPanel.Controls.Add(this.ContactLabel);
            this.GeneralPanel.Controls.Add(this.GenderLabel);
            this.GeneralPanel.Controls.Add(this.AgeLabel);
            this.GeneralPanel.Controls.Add(this.DOBLabel);
            this.GeneralPanel.Controls.Add(this.FullNameLabel);
            this.GeneralPanel.Controls.Add(this.GeneralInfoHeadingLabel);
            this.GeneralPanel.Controls.Add(this.NextToPanel2Button);
            this.GeneralPanel.Controls.Add(this.ClearAllButton);
            this.GeneralPanel.Controls.Add(this.ExitFromSignupButton);
            this.GeneralPanel.Location = new System.Drawing.Point(0, 0);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(795, 445);
            this.GeneralPanel.TabIndex = 0;
            this.GeneralPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GeneralPanel_Paint);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(151, 326);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddressTextBox.TabIndex = 25;
            this.AddressTextBox.Visible = false;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddressLabel.ForeColor = System.Drawing.Color.White;
            this.AddressLabel.Location = new System.Drawing.Point(24, 326);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(72, 17);
            this.AddressLabel.TabIndex = 24;
            this.AddressLabel.Text = "Address : ";
            this.AddressLabel.Visible = false;
            this.AddressLabel.Click += new System.EventHandler(this.AddressLabel_Click);
            // 
            // QualificationTextBox
            // 
            this.QualificationTextBox.Location = new System.Drawing.Point(580, 201);
            this.QualificationTextBox.Name = "QualificationTextBox";
            this.QualificationTextBox.Size = new System.Drawing.Size(100, 20);
            this.QualificationTextBox.TabIndex = 21;
            this.QualificationTextBox.Visible = false;
            this.QualificationTextBox.TextChanged += new System.EventHandler(this.QualificationTextBox_TextChanged);
            // 
            // QualificationLabel
            // 
            this.QualificationLabel.AutoSize = true;
            this.QualificationLabel.BackColor = System.Drawing.Color.Transparent;
            this.QualificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.QualificationLabel.ForeColor = System.Drawing.Color.White;
            this.QualificationLabel.Location = new System.Drawing.Point(453, 201);
            this.QualificationLabel.Name = "QualificationLabel";
            this.QualificationLabel.Size = new System.Drawing.Size(98, 17);
            this.QualificationLabel.TabIndex = 20;
            this.QualificationLabel.Text = "Qualification : ";
            this.QualificationLabel.Visible = false;
            this.QualificationLabel.Click += new System.EventHandler(this.QualificationLabel_Click);
            // 
            // DiagnosisTextBox
            // 
            this.DiagnosisTextBox.Location = new System.Drawing.Point(580, 202);
            this.DiagnosisTextBox.Name = "DiagnosisTextBox";
            this.DiagnosisTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiagnosisTextBox.TabIndex = 19;
            this.DiagnosisTextBox.Visible = false;
            this.DiagnosisTextBox.TextChanged += new System.EventHandler(this.DiagnosisTextBox_TextChanged);
            // 
            // DiagnosisLabel
            // 
            this.DiagnosisLabel.AutoSize = true;
            this.DiagnosisLabel.BackColor = System.Drawing.Color.Transparent;
            this.DiagnosisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DiagnosisLabel.ForeColor = System.Drawing.Color.White;
            this.DiagnosisLabel.Location = new System.Drawing.Point(453, 202);
            this.DiagnosisLabel.Name = "DiagnosisLabel";
            this.DiagnosisLabel.Size = new System.Drawing.Size(82, 17);
            this.DiagnosisLabel.TabIndex = 18;
            this.DiagnosisLabel.Text = "Diagnosis : ";
            this.DiagnosisLabel.Visible = false;
            this.DiagnosisLabel.Click += new System.EventHandler(this.DiagnosisLabel_Click);
            // 
            // BloodGroupComboBox
            // 
            this.BloodGroupComboBox.FormattingEnabled = true;
            this.BloodGroupComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.BloodGroupComboBox.Location = new System.Drawing.Point(151, 256);
            this.BloodGroupComboBox.Name = "BloodGroupComboBox";
            this.BloodGroupComboBox.Size = new System.Drawing.Size(121, 21);
            this.BloodGroupComboBox.TabIndex = 17;
            this.BloodGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.BloodGroupComboBox_SelectedIndexChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Doctor",
            "Nurse",
            "Patient"});
            this.CategoryComboBox.Location = new System.Drawing.Point(151, 288);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 16;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(151, 189);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(121, 21);
            this.GenderComboBox.TabIndex = 15;
            this.GenderComboBox.SelectedIndexChanged += new System.EventHandler(this.GenderComboBox_SelectedIndexChanged);
            // 
            // DOB_DTP
            // 
            this.DOB_DTP.Location = new System.Drawing.Point(151, 124);
            this.DOB_DTP.MaxDate = new System.DateTime(2025, 9, 14, 0, 0, 0, 0);
            this.DOB_DTP.Name = "DOB_DTP";
            this.DOB_DTP.Size = new System.Drawing.Size(200, 20);
            this.DOB_DTP.TabIndex = 14;
            this.DOB_DTP.Value = new System.DateTime(2025, 9, 14, 0, 0, 0, 0);
            this.DOB_DTP.ValueChanged += new System.EventHandler(this.DOB_DTP_ValueChanged);
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Location = new System.Drawing.Point(151, 224);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(100, 20);
            this.ContactTextBox.TabIndex = 13;
            this.ContactTextBox.TextChanged += new System.EventHandler(this.ContactTextBox_TextChanged);
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(151, 154);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AgeTextBox.TabIndex = 12;
            this.AgeTextBox.TextChanged += new System.EventHandler(this.AgeTextBox_TextChanged);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(151, 86);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FullNameTextBox.TabIndex = 11;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.BackColor = System.Drawing.Color.Transparent;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Category.ForeColor = System.Drawing.Color.White;
            this.Category.Location = new System.Drawing.Point(24, 289);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(77, 17);
            this.Category.TabIndex = 10;
            this.Category.Text = "Category : ";
            this.Category.Click += new System.EventHandler(this.Category_Click);
            // 
            // BloodGroupLabel
            // 
            this.BloodGroupLabel.AutoSize = true;
            this.BloodGroupLabel.BackColor = System.Drawing.Color.Transparent;
            this.BloodGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BloodGroupLabel.ForeColor = System.Drawing.Color.White;
            this.BloodGroupLabel.Location = new System.Drawing.Point(24, 256);
            this.BloodGroupLabel.Name = "BloodGroupLabel";
            this.BloodGroupLabel.Size = new System.Drawing.Size(100, 17);
            this.BloodGroupLabel.TabIndex = 9;
            this.BloodGroupLabel.Text = "Blood Group : ";
            this.BloodGroupLabel.Click += new System.EventHandler(this.BloodGroupLabel_Click);
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.BackColor = System.Drawing.Color.Transparent;
            this.ContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ContactLabel.ForeColor = System.Drawing.Color.White;
            this.ContactLabel.Location = new System.Drawing.Point(24, 224);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(68, 17);
            this.ContactLabel.TabIndex = 8;
            this.ContactLabel.Text = "Contact : ";
            this.ContactLabel.Click += new System.EventHandler(this.ContactLabel_Click);
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.BackColor = System.Drawing.Color.Transparent;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GenderLabel.ForeColor = System.Drawing.Color.White;
            this.GenderLabel.Location = new System.Drawing.Point(24, 189);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(68, 17);
            this.GenderLabel.TabIndex = 7;
            this.GenderLabel.Text = "Gender : ";
            this.GenderLabel.Click += new System.EventHandler(this.GenderLabel_Click);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.BackColor = System.Drawing.Color.Transparent;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AgeLabel.ForeColor = System.Drawing.Color.White;
            this.AgeLabel.Location = new System.Drawing.Point(24, 154);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(45, 17);
            this.AgeLabel.TabIndex = 6;
            this.AgeLabel.Text = "Age : ";
            this.AgeLabel.Click += new System.EventHandler(this.AgeLabel_Click);
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.BackColor = System.Drawing.Color.Transparent;
            this.DOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DOBLabel.ForeColor = System.Drawing.Color.White;
            this.DOBLabel.Location = new System.Drawing.Point(24, 124);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(99, 17);
            this.DOBLabel.TabIndex = 5;
            this.DOBLabel.Text = "Date of Birth : ";
            this.DOBLabel.Click += new System.EventHandler(this.DOBLabel_Click);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FullNameLabel.ForeColor = System.Drawing.Color.White;
            this.FullNameLabel.Location = new System.Drawing.Point(24, 86);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(83, 17);
            this.FullNameLabel.TabIndex = 4;
            this.FullNameLabel.Text = "Full Name : ";
            // 
            // GeneralInfoHeadingLabel
            // 
            this.GeneralInfoHeadingLabel.AutoSize = true;
            this.GeneralInfoHeadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.GeneralInfoHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.GeneralInfoHeadingLabel.ForeColor = System.Drawing.Color.White;
            this.GeneralInfoHeadingLabel.Location = new System.Drawing.Point(253, 21);
            this.GeneralInfoHeadingLabel.Name = "GeneralInfoHeadingLabel";
            this.GeneralInfoHeadingLabel.Size = new System.Drawing.Size(300, 37);
            this.GeneralInfoHeadingLabel.TabIndex = 3;
            this.GeneralInfoHeadingLabel.Text = "General Information";
            // 
            // NextToPanel2Button
            // 
            this.NextToPanel2Button.Location = new System.Drawing.Point(717, 419);
            this.NextToPanel2Button.Name = "NextToPanel2Button";
            this.NextToPanel2Button.Size = new System.Drawing.Size(75, 23);
            this.NextToPanel2Button.TabIndex = 2;
            this.NextToPanel2Button.Text = "Next";
            this.NextToPanel2Button.UseVisualStyleBackColor = true;
            this.NextToPanel2Button.Click += new System.EventHandler(this.NextToPanel2Button_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(367, 377);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(75, 23);
            this.ClearAllButton.TabIndex = 1;
            this.ClearAllButton.Text = "Reset";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // ExitFromSignupButton
            // 
            this.ExitFromSignupButton.Location = new System.Drawing.Point(3, 419);
            this.ExitFromSignupButton.Name = "ExitFromSignupButton";
            this.ExitFromSignupButton.Size = new System.Drawing.Size(75, 23);
            this.ExitFromSignupButton.TabIndex = 0;
            this.ExitFromSignupButton.Text = "Back";
            this.ExitFromSignupButton.UseVisualStyleBackColor = true;
            this.ExitFromSignupButton.Click += new System.EventHandler(this.ExitFromSignupButton_Click);
            // 
            // AccountPanel
            // 
            this.AccountPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AccountPanel.BackgroundImage")));
            this.AccountPanel.Controls.Add(this.ShowPasswordCheckBox);
            this.AccountPanel.Controls.Add(this.BackToPanel1);
            this.AccountPanel.Controls.Add(this.PasswordTextBox);
            this.AccountPanel.Controls.Add(this.ConfirmPasswordTextBox);
            this.AccountPanel.Controls.Add(this.UsernameTextBox);
            this.AccountPanel.Controls.Add(this.ConfirmPasswordLabel);
            this.AccountPanel.Controls.Add(this.PasswordLabel);
            this.AccountPanel.Controls.Add(this.UsernameLabel);
            this.AccountPanel.Controls.Add(this.AccountInfoHeadingLabel);
            this.AccountPanel.Controls.Add(this.SignupButton);
            this.AccountPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(795, 445);
            this.AccountPanel.TabIndex = 26;
            this.AccountPanel.Visible = false;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(549, 260);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(102, 17);
            this.ShowPasswordCheckBox.TabIndex = 9;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = false;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // BackToPanel1
            // 
            this.BackToPanel1.Location = new System.Drawing.Point(3, 419);
            this.BackToPanel1.Name = "BackToPanel1";
            this.BackToPanel1.Size = new System.Drawing.Size(75, 23);
            this.BackToPanel1.TabIndex = 0;
            this.BackToPanel1.Text = "Back";
            this.BackToPanel1.UseVisualStyleBackColor = true;
            this.BackToPanel1.Click += new System.EventHandler(this.BackToPanel1_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(393, 201);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 8;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(393, 260);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConfirmPasswordTextBox.TabIndex = 7;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(393, 151);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.UsernameTextBox.TabIndex = 6;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ConfirmPasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(218, 261);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(133, 17);
            this.ConfirmPasswordLabel.TabIndex = 5;
            this.ConfirmPasswordLabel.Text = "Confirm Password : ";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PasswordLabel.Location = new System.Drawing.Point(270, 202);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(81, 17);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password : ";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UsernameLabel.Location = new System.Drawing.Point(266, 152);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(85, 17);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username : ";
            // 
            // AccountInfoHeadingLabel
            // 
            this.AccountInfoHeadingLabel.AutoSize = true;
            this.AccountInfoHeadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.AccountInfoHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.AccountInfoHeadingLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AccountInfoHeadingLabel.Location = new System.Drawing.Point(238, 46);
            this.AccountInfoHeadingLabel.Name = "AccountInfoHeadingLabel";
            this.AccountInfoHeadingLabel.Size = new System.Drawing.Size(331, 37);
            this.AccountInfoHeadingLabel.TabIndex = 2;
            this.AccountInfoHeadingLabel.Text = "Account Information : ";
            // 
            // SignupButton
            // 
            this.SignupButton.Location = new System.Drawing.Point(700, 419);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(92, 23);
            this.SignupButton.TabIndex = 1;
            this.SignupButton.Text = "Create Account";
            this.SignupButton.UseVisualStyleBackColor = true;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GeneralPanel);
            this.Controls.Add(this.AccountPanel);
            this.Name = "SignupForm";
            this.Text = "Prototype";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            this.AccountPanel.ResumeLayout(false);
            this.AccountPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.Button NextToPanel2Button;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Button ExitFromSignupButton;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label BloodGroupLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label GeneralInfoHeadingLabel;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.ComboBox BloodGroupComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.DateTimePicker DOB_DTP;
        private System.Windows.Forms.TextBox QualificationTextBox;
        private System.Windows.Forms.Label QualificationLabel;
        private System.Windows.Forms.TextBox DiagnosisTextBox;
        private System.Windows.Forms.Label DiagnosisLabel;
        private System.Windows.Forms.Panel AccountPanel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label AccountInfoHeadingLabel;
        private System.Windows.Forms.Button SignupButton;
        private System.Windows.Forms.Button BackToPanel1;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
    }
}

