using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EduMath
{
    public partial class frmteachersearch : Form
    {
        public frmteachersearch()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntclearfield_Click(object sender, EventArgs e)
        {

        }

        private void btntsearch_Click(object sender, EventArgs e)
        {

            //Code for the data grid view
            SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=studentlms;Integrated Security=True");
            SqlCommand com;

            con.Open();
            string query = "Select * From teacher Where teacherid = " + txtenterid.Text + "";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            con.Close();


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtenterid.Clear();
            txtenterid.Focus();
            dataGridView1.DataSource = null;
        }
    }
}
