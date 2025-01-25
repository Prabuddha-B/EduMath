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

namespace EduMath
{
    public partial class frmviewstudents : Form
    {
        public frmviewstudents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtenterstudent.Clear();
            dataGridView2.DataSource = null;
            txtenterstudent.Focus();
        }

        private void btntsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=studentlms;Integrated Security=True");
            SqlCommand com;

            try
            {
                con.Open();
                string query1 = "Select * From detail Where studentnumber = '" + txtenterstudent.Text + "'";
                SqlDataAdapter da1 = new SqlDataAdapter(query1, con);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                // If user enters not existed stnumber. showing a message box using if condition.

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Student number does not exist.");
                }
                else
                {
                    dataGridView2.DataSource = dt;
                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // deleted button
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=studentlms;Integrated Security=True");
            SqlCommand com;

            try
            {
                con.Open();
                string query10 = "Select * From detail";
                SqlDataAdapter da10 = new SqlDataAdapter(query10, con);
                DataTable dt0 = new DataTable();
                da10.Fill(dt0);

                // If user enters not existed stnumber. showing a message box using if condition.

                if (dt0.Rows.Count == 0)
                {
                    MessageBox.Show("Student number does not exist.");
                }
                else
                {
                    dataGridView2.DataSource = dt0;
                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
