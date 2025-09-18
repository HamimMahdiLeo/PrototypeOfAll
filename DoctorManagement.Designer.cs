namespace Hospital_Management
{
    partial class DoctorManagement
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospital_ManagementDataSet4 = new Hospital_Management.Hospital_ManagementDataSet4();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospital_ManagementDataSet = new Hospital_Management.Hospital_ManagementDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.doctorTableAdapter = new Hospital_Management.Hospital_ManagementDataSetTableAdapters.DoctorTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.doctorTableAdapter1 = new Hospital_Management.Hospital_ManagementDataSet4TableAdapters.DoctorTableAdapter();
            this.hospitalDataSet3 = new Hospital_Management.HospitalDataSet3();
            this.doctorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter2 = new Hospital_Management.HospitalDataSet3TableAdapters.DoctorTableAdapter();
            this.hospitalDataSet4 = new Hospital_Management.HospitalDataSet4();
            this.doctorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter3 = new Hospital_Management.HospitalDataSet4TableAdapters.DoctorTableAdapter();
            this.hospitalDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableSlotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_ManagementDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(45, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
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
            this.dataGridView1.DataSource = this.doctorBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(45, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 275);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // doctorBindingSource1
            // 
            this.doctorBindingSource1.DataMember = "Doctor";
            this.doctorBindingSource1.DataSource = this.hospital_ManagementDataSet4;
            // 
            // hospital_ManagementDataSet4
            // 
            this.hospital_ManagementDataSet4.DataSetName = "Hospital_ManagementDataSet4";
            this.hospital_ManagementDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.hospital_ManagementDataSet;
            // 
            // hospital_ManagementDataSet
            // 
            this.hospital_ManagementDataSet.DataSetName = "Hospital_ManagementDataSet";
            this.hospital_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(183, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(345, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(129, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 29);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(651, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(493, 403);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 33);
            this.button5.TabIndex = 9;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // doctorTableAdapter1
            // 
            this.doctorTableAdapter1.ClearBeforeFill = true;
            // 
            // hospitalDataSet3
            // 
            this.hospitalDataSet3.DataSetName = "HospitalDataSet3";
            this.hospitalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource2
            // 
            this.doctorBindingSource2.DataMember = "Doctor";
            this.doctorBindingSource2.DataSource = this.hospitalDataSet3;
            // 
            // doctorTableAdapter2
            // 
            this.doctorTableAdapter2.ClearBeforeFill = true;
            // 
            // hospitalDataSet4
            // 
            this.hospitalDataSet4.DataSetName = "HospitalDataSet4";
            this.hospitalDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource3
            // 
            this.doctorBindingSource3.DataMember = "Doctor";
            this.doctorBindingSource3.DataSource = this.hospitalDataSet4;
            // 
            // doctorTableAdapter3
            // 
            this.doctorTableAdapter3.ClearBeforeFill = true;
            // 
            // hospitalDataSet4BindingSource
            // 
            this.hospitalDataSet4BindingSource.DataSource = this.hospitalDataSet4;
            this.hospitalDataSet4BindingSource.Position = 0;
            // 
            // doctorBindingSource4
            // 
            this.doctorBindingSource4.DataMember = "Doctor";
            this.doctorBindingSource4.DataSource = this.hospitalDataSet4BindingSource;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
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
            // DoctorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "DoctorManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Management";
            this.Load += new System.EventHandler(this.DoctorManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_ManagementDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private Hospital_ManagementDataSet hospital_ManagementDataSet;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private Hospital_ManagementDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.Button button5;
        private Hospital_ManagementDataSet4 hospital_ManagementDataSet4;
        private System.Windows.Forms.BindingSource doctorBindingSource1;
        private Hospital_ManagementDataSet4TableAdapters.DoctorTableAdapter doctorTableAdapter1;
        private HospitalDataSet3 hospitalDataSet3;
        private System.Windows.Forms.BindingSource doctorBindingSource2;
        private HospitalDataSet3TableAdapters.DoctorTableAdapter doctorTableAdapter2;
        private HospitalDataSet4 hospitalDataSet4;
        private System.Windows.Forms.BindingSource doctorBindingSource3;
        private HospitalDataSet4TableAdapters.DoctorTableAdapter doctorTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableSlotDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource doctorBindingSource4;
        private System.Windows.Forms.BindingSource hospitalDataSet4BindingSource;
    }
}