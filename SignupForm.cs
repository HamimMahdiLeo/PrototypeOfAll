using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PrototypeOfAll
{
    public partial class SignupForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public SignupForm()
        {
            InitializeComponent();

            DOB_DTP.Format = DateTimePickerFormat.Custom;
            DOB_DTP.CustomFormat = "'Select'";
            PasswordTextBox.UseSystemPasswordChar = true;
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            GeneralPanel.Visible = true;
            AccountPanel.Visible = false;

            HideOptionalFields();
        }

        // ---------------------- Password Validation ----------------------
        private bool HasSpecialChar(string password) => password.Any(ch => !char.IsLetterOrDigit(ch));
        private bool HasUpperCase(string password) => password.Any(ch => char.IsUpper(ch));
        private bool HasLowerCase(string password) => password.Any(ch => char.IsLower(ch));
        private bool HasNumber(string password) => password.Any(ch => char.IsDigit(ch));

        // ---------------------- General Panel ----------------------
        private void DOB_DTP_ValueChanged(object sender, EventArgs e)
        {
            DOB_DTP.Format = DateTimePickerFormat.Long;
            DateTime dob = DOB_DTP.Value;
            DateTime today = DateTime.Today;

            int age = today.Year - dob.Year;
            if (dob.Date > today.AddYears(-age)) age--;
            AgeTextBox.Text = age.ToString();
        }

        //this is a test comment

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = CategoryComboBox.Text;

            HideOptionalFields();

            if (category == "Doctor")
            {
                QualificationLabel.Visible = true;
                QualificationTextBox.Visible = true;
            }
            else if (category == "Nurse")
            {
                //ShiftLabel.Visible = true;
                //ShiftTextBox.Visible = true;
            }
            else if (category == "Patient")
            {
                DiagnosisLabel.Visible = true;
                DiagnosisTextBox.Visible = true;
                AddressLabel.Visible = true;
                AddressTextBox.Visible = true;
            }
        }

        private void HideOptionalFields()
        {
            QualificationLabel.Visible = false;
            QualificationTextBox.Visible = false;
            //ShiftLabel.Visible = false;
            //ShiftTextBox.Visible = false;
            DiagnosisLabel.Visible = false;
            DiagnosisTextBox.Visible = false;
            AddressLabel.Visible = false;
            AddressTextBox.Visible = false;
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            FullNameTextBox.Text = "";
            AgeTextBox.Text = "";
            ContactTextBox.Text = "";
            BloodGroupComboBox.Text = "";
            DiagnosisTextBox.Text = "";
            QualificationTextBox.Text = "";
            //ShiftTextBox.Text = "";
            AddressTextBox.Text = "";
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
            ConfirmPasswordTextBox.Text = "";

            if (GenderComboBox.Items.Count > 0)
                GenderComboBox.Text = "Select";
            if (CategoryComboBox.Items.Count > 0)
                CategoryComboBox.Text = "Select";

            DOB_DTP.Format = DateTimePickerFormat.Custom;
            DOB_DTP.CustomFormat = "'Select'";
            HideOptionalFields();
            FullNameTextBox.Focus();
        }

        private void NextToPanel2Button_Click(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text == "" ||
                GenderComboBox.Text == "Select" ||
                BloodGroupComboBox.Text == "Select" ||
                ContactTextBox.Text == "" ||
                CategoryComboBox.Text == "Select")
            {
                MessageBox.Show("Please fill out all fields before proceeding.");
                return;
            }

            string category = CategoryComboBox.Text;
            if (category == "Doctor" && QualificationTextBox.Text == "")
            {
                MessageBox.Show("Please enter your Qualification.");
                return;
            }
            //if (category == "Nurse" && ShiftTextBox.Text == "")
            //{
            //    MessageBox.Show("Please enter your Shift.");
            //    return;
            //}
            if (category == "Patient" && (DiagnosisTextBox.Text == "" || AddressTextBox.Text == ""))
            {
                MessageBox.Show("Please enter Diagnosis and Address.");
                return;
            }

            GeneralPanel.Visible = false;
            AccountPanel.Visible = true;
        }

        private void BackToPanel1_Click(object sender, EventArgs e)
        {
            GeneralPanel.Visible = true;
            AccountPanel.Visible = false;
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool show = ShowPasswordCheckBox.Checked;
            PasswordTextBox.UseSystemPasswordChar = !show;
            ConfirmPasswordTextBox.UseSystemPasswordChar = !show;
        }

        private void ContactTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = ContactTextBox.Text;
            if (input.Length > 11)
            {
                MessageBox.Show("Phone number must be 11 digits.");
                ContactTextBox.Text = input.Substring(0, 11);
                ContactTextBox.SelectionStart = ContactTextBox.Text.Length;
            }
            if (input.Length >= 2 && !input.StartsWith("01"))
            {
                MessageBox.Show("Phone number must start with 01.");
                ContactTextBox.Clear();
            }
        }

        // ---------------------- Signup Button ----------------------
        private void SignupButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            string confirmPassword = ConfirmPasswordTextBox.Text.Trim();
            string category = CategoryComboBox.Text;
            string gender = GenderComboBox.Text;
            string BloodGroup = BloodGroupComboBox.Text;
            string age = AgeTextBox.Text;

            // ---------- Username Checks ----------
            if (username == "")
            {
                MessageBox.Show("No Username Detected");
                return;
            }

            try
            {
                con.Open();
                string checkQuery = "SELECT COUNT(*) FROM Login WHERE Username = '" + username + "'";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                int count = (int)checkCmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("Username already taken. Please choose another.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking username: " + ex.Message);
                return;
            }

            // ---------- Password Checks ----------
            if (password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please enter and confirm your password.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            if (password.Length < 6 || !HasUpperCase(password) || !HasLowerCase(password) || !HasNumber(password) || !HasSpecialChar(password))
            {
                MessageBox.Show("Password must contain at least one lowercase letter, one uppercase, one number, one special character and must be at least 6 characters long.");
                return;
            }

            // ---------- Prepare Queries ----------
            string insert_query = "";
            string login_query = "";

            if (category == "Patient")
            {
                insert_query = "INSERT INTO Patient (PatientName, PatientAge, Gender, PatientContact, BloodGroup, PatientAddress, Diagnosis) VALUES ('"
                    + FullNameTextBox.Text + "', '"
                    + age + "', '"
                    + gender + "', '"
                    + ContactTextBox.Text + "', '"
                    + BloodGroup + "', '"
                    + AddressTextBox.Text + "', '"
                    + DiagnosisTextBox.Text + "')";
            }
            else if (category == "Doctor")
            {
                insert_query = "INSERT INTO Doctor (DoctorName, DoctorAge, Gender, DoctorContact, BloodGroup, Qualification) VALUES ('"
                    + FullNameTextBox.Text + "', '"
                    + age + "', '"
                    + gender + "', '"
                    + ContactTextBox.Text + "', '"
                    + BloodGroup + "', '"
                    + QualificationTextBox.Text + "')";
            }
            else if (category == "Nurse")
            {
                insert_query = "INSERT INTO Nurse (NurseName, NurseAge, Gender, NurseContact, BloodGroup) VALUES ('"
                    + FullNameTextBox.Text + "', '"
                    + age + "', '"
                    + gender + "', '"
                    + ContactTextBox.Text + "', '"
                    + BloodGroup + "')";
            }
            else
            {
                MessageBox.Show("Invalid category selected!");
                return;
            }

            login_query = "INSERT INTO Login (Username, Password, Role) VALUES ('"
                + UsernameTextBox.Text + "', '"
                + PasswordTextBox.Text + "', '"
                + category + "' )";

            // ---------- Execute Queries ----------
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(insert_query, con);
                cmd.ExecuteNonQuery();

                SqlCommand loginCmd = new SqlCommand(login_query, con);
                loginCmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Account created successfully!");

                AccountPanel.Hide();
                GeneralPanel.Show();
                ClearAllButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void GeneralPanel_Paint(object sender, PaintEventArgs e) { }
        private void ShiftLabel_Click(object sender, EventArgs e) { }
        private void QualificationTextBox_TextChanged(object sender, EventArgs e) { }
        private void QualificationLabel_Click(object sender, EventArgs e) { }
        private void DiagnosisTextBox_TextChanged(object sender, EventArgs e) { }
        private void DiagnosisLabel_Click(object sender, EventArgs e) { }
        private void BloodGroupComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void AgeTextBox_TextChanged(object sender, EventArgs e) { }
        private void FullNameTextBox_TextChanged(object sender, EventArgs e) { }
        private void Category_Click(object sender, EventArgs e) { }
        private void BloodGroupLabel_Click(object sender, EventArgs e) { }
        private void ContactLabel_Click(object sender, EventArgs e) { }
        private void GenderLabel_Click(object sender, EventArgs e) { }
        private void AgeLabel_Click(object sender, EventArgs e) { }
        private void DOBLabel_Click(object sender, EventArgs e) { }
        private void FullNameLabel_Click(object sender, EventArgs e) { }
        private void ExitFromSignupButton_Click(object sender, EventArgs e) { }
        private void AddressTextBox_TextChanged(object sender, EventArgs e) { }
        private void AddressLabel_Click(object sender, EventArgs e) { }
    }
}
