namespace PrototypeOfAll
{
    partial class DocDashForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocDashForm));
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.AvailableLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ProfilePanelTimer = new System.Windows.Forms.Timer(this.components);
            this.ProfilePanelExtender = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.hospitalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new PrototypeOfAll.HospitalDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hospital_Data_Set = new PrototypeOfAll.Hospital_Data_Set();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new PrototypeOfAll.Hospital_Data_SetTableAdapters.DoctorTableAdapter();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableSlotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_Data_Set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.ProfilePanel.Controls.Add(this.LogoutButton);
            this.ProfilePanel.Controls.Add(this.AvailableLabel);
            this.ProfilePanel.Controls.Add(this.ContactLabel);
            this.ProfilePanel.Controls.Add(this.NameLabel);
            this.ProfilePanel.Location = new System.Drawing.Point(800, 0);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(0, 450);
            this.ProfilePanel.TabIndex = 0;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.White;
            this.LogoutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoutButton.BackgroundImage")));
            this.LogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.ForeColor = System.Drawing.Color.Snow;
            this.LogoutButton.Location = new System.Drawing.Point(171, 401);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(37, 37);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.UseVisualStyleBackColor = false;
            // 
            // AvailableLabel
            // 
            this.AvailableLabel.AutoSize = true;
            this.AvailableLabel.Location = new System.Drawing.Point(15, 222);
            this.AvailableLabel.Name = "AvailableLabel";
            this.AvailableLabel.Size = new System.Drawing.Size(85, 13);
            this.AvailableLabel.TabIndex = 2;
            this.AvailableLabel.Text = "Available Time : ";
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(47, 197);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(53, 13);
            this.ContactLabel.TabIndex = 1;
            this.ContactLabel.Text = "Contact : ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(56, 172);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name : ";
            // 
            // ProfilePanelTimer
            // 
            this.ProfilePanelTimer.Interval = 15;
            // 
            // ProfilePanelExtender
            // 
            this.ProfilePanelExtender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfilePanelExtender.Location = new System.Drawing.Point(743, 32);
            this.ProfilePanelExtender.Name = "ProfilePanelExtender";
            this.ProfilePanelExtender.Size = new System.Drawing.Size(45, 23);
            this.ProfilePanelExtender.TabIndex = 3;
            this.ProfilePanelExtender.Text = "Profile";
            this.ProfilePanelExtender.UseVisualStyleBackColor = true;
            this.ProfilePanelExtender.Click += new System.EventHandler(this.ProfilePanelExtender_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(373, 346);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 28);
            this.button5.TabIndex = 17;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 24);
            this.button4.TabIndex = 16;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchTextBox.Location = new System.Drawing.Point(123, 97);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(278, 23);
            this.SearchTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(47, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(273, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 28);
            this.button3.TabIndex = 13;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(165, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(73, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hospitalDataSetBindingSource
            // 
            this.hospitalDataSetBindingSource.DataSource = this.hospitalDataSet;
            this.hospitalDataSetBindingSource.Position = 0;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorIDDataGridViewTextBoxColumn,
            this.doctorNameDataGridViewTextBoxColumn,
            this.doctorAgeDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.doctorContactDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.qualificationDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.availableSlotDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 214);
            this.dataGridView1.TabIndex = 18;
            // 
            // hospital_Data_Set
            // 
            this.hospital_Data_Set.DataSetName = "Hospital_Data_Set";
            this.hospital_Data_Set.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.hospital_Data_Set;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            // 
            // doctorAgeDataGridViewTextBoxColumn
            // 
            this.doctorAgeDataGridViewTextBoxColumn.DataPropertyName = "DoctorAge";
            this.doctorAgeDataGridViewTextBoxColumn.HeaderText = "DoctorAge";
            this.doctorAgeDataGridViewTextBoxColumn.Name = "doctorAgeDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // doctorContactDataGridViewTextBoxColumn
            // 
            this.doctorContactDataGridViewTextBoxColumn.DataPropertyName = "DoctorContact";
            this.doctorContactDataGridViewTextBoxColumn.HeaderText = "DoctorContact";
            this.doctorContactDataGridViewTextBoxColumn.Name = "doctorContactDataGridViewTextBoxColumn";
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            // 
            // qualificationDataGridViewTextBoxColumn
            // 
            this.qualificationDataGridViewTextBoxColumn.DataPropertyName = "Qualification";
            this.qualificationDataGridViewTextBoxColumn.HeaderText = "Qualification";
            this.qualificationDataGridViewTextBoxColumn.Name = "qualificationDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // availableSlotDataGridViewTextBoxColumn
            // 
            this.availableSlotDataGridViewTextBoxColumn.DataPropertyName = "AvailableSlot";
            this.availableSlotDataGridViewTextBoxColumn.HeaderText = "AvailableSlot";
            this.availableSlotDataGridViewTextBoxColumn.Name = "availableSlotDataGridViewTextBoxColumn";
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchButton.Location = new System.Drawing.Point(410, 95);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(29, 24);
            this.SearchButton.TabIndex = 19;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearButton.BackgroundImage")));
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(445, 95);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(31, 25);
            this.ClearButton.TabIndex = 20;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DocDashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProfilePanelExtender);
            this.Controls.Add(this.ProfilePanel);
            this.Name = "DocDashForm";
            this.Text = "DocDashForm";
            this.ProfilePanel.ResumeLayout(false);
            this.ProfilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_Data_Set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.Label AvailableLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Timer ProfilePanelTimer;
        private System.Windows.Forms.Button ProfilePanelExtender;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource hospitalDataSetBindingSource;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Hospital_Data_Set hospital_Data_Set;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private Hospital_Data_SetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableSlotDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ClearButton;
    }
}