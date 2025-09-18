using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class DoctorManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HOP36BN\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");
        public DoctorManagement()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from Doctor";


            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "select * from Doctor";


            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
           
        }

        private void DoctorManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet4.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter3.Fill(this.hospitalDataSet4.Doctor);
            // TODO: This line of code loads data into the 'hospitalDataSet3.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter2.Fill(this.hospitalDataSet3.Doctor);
            // TODO: This line of code loads data into the 'hospital_ManagementDataSet4.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter1.Fill(this.hospital_ManagementDataSet4.Doctor);
            // TODO: This line of code loads data into the 'hospital_ManagementDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hospital_ManagementDataSet.Doctor);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string query = "select * from Doctor where DoctorName like '" + textBox1.Text + "%'";
            //string query = "select * from Doctor where DoctorName like '%" + textBox1.Text + "%'";

            string query = "select * from Doctor where DoctorID like '%" + textBox1.Text + "%' " +
               "or DoctorName like '%" + textBox1.Text + "%' " +
               "or DoctorAge like '%" + textBox1.Text + "%' " +
               "or Gender like '%" + textBox1.Text + "%' " +
               "or Qualification like '%" + textBox1.Text + "%' " +
               "or DoctorContact like '%" + textBox1.Text + "%' " +
               "or Department like '%" + textBox1.Text + "%' " +
               "or AvailableSlot like '%" + textBox1.Text + "%'";


            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
