using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrototypeOfAll
{
    public partial class DocDashForm : Form
    {
        // Single connection used throughout
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        private bool isProfilePanelExpanded = false;
        private int targetWidth = 220;
        private int animationStep = 20;

        public DocDashForm()
        {
            InitializeComponent();

            // Start Profile Panel collapsed
            ProfilePanel.Width = 0;
            ProfilePanel.Left = this.ClientSize.Width;

            // Wire events
            ProfilePanelTimer.Tick += ProfilePanelTimer_Tick;
            ProfilePanelExtender.Click += ProfilePanelExtender_Click;
            SearchButton.Click += SearchButton_Click;
            ClearButton.Click += ClearButton_Click;
            button1.Click += button1_Click; // Show all doctors button

            // Initialize DataGridView as blank
            dataGridView1.DataSource = new DataTable();
        }

        private void ProfilePanelExtender_Click(object sender, EventArgs e)
        {
            ProfilePanelTimer.Start();
        }

        private void ProfilePanelTimer_Tick(object sender, EventArgs e)
        {
            if (isProfilePanelExpanded)
            {
                // Collapse
                ProfilePanel.Width -= animationStep;
                ProfilePanel.Left += animationStep;

                if (ProfilePanel.Width <= 0)
                {
                    ProfilePanel.Width = 0;
                    ProfilePanel.Left = this.ClientSize.Width;
                    isProfilePanelExpanded = false;
                    ProfilePanelTimer.Stop();
                }
            }
            else
            {
                // Expand
                ProfilePanel.Width += animationStep;
                ProfilePanel.Left -= animationStep;

                if (ProfilePanel.Width >= targetWidth)
                {
                    ProfilePanel.Width = targetWidth;
                    ProfilePanel.Left = this.ClientSize.Width - targetWidth;
                    isProfilePanelExpanded = true;
                    ProfilePanelTimer.Stop();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show all doctors
            string query = "SELECT * FROM Doctor"; // Make sure table name matches database
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string keyword = SearchTextBox.Text.Trim(); // Ensure TextBox is named SearchTextBox

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a keyword to search.");
                return;
            }

            string query = @"SELECT * FROM Doctor
                             WHERE DoctorId LIKE @keyword
                                OR DoctorName LIKE @keyword
                                OR DoctorAge LIKE @keyword
                                OR Gender LIKE @keyword
                                OR Qualification LIKE @keyword
                                OR DoctorContact LIKE @keyword
                                OR BloodGroup LIKE @keyword
                                OR Department LIKE @keyword
                                OR AvailableSlot LIKE @keyword";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                // Show "No match found"
                DataTable emptyTable = new DataTable();
                emptyTable.Columns.Add("Message");
                emptyTable.Rows.Add("No match found");
                dataGridView1.DataSource = emptyTable;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            dataGridView1.DataSource = new DataTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: implement if you need cell click functionality
        }
    }
}
