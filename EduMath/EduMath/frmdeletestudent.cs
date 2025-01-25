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
using System.Configuration;

namespace EduMath
{
    public partial class frmdeletestudent : Form
    {
        public frmdeletestudent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntview_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=studentlms;Integrated Security=True");
                SqlCommand com;

                con.Open();
                string sqlselect = "select * from detail where studentnumber = '" + txtentertudent.Text + "'";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    txtfname.Text = dr["firstname"].ToString();
                    txtlastname.Text = dr["lastname"].ToString();
                    txtgender.Text = dr["gender"].ToString();
                    txttp.Text = dr["contactnumber"].ToString();
                    con.Close();

                }
                else
                {
                    MessageBox.Show("Record not found ", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }








        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=studentlms;Integrated Security=True");
                SqlCommand com;

                con.Open();
                string sqldelete = "delete from detail where studentnumber = '" + txtentertudent.Text + "'";
                com = new SqlCommand(sqldelete, con);
                com.ExecuteNonQuery();

                DialogResult result = MessageBox.Show("Are you sure you want to delete the record.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    txtentertudent.Clear();
                    txtfname.Clear();
                    txtlastname.Clear();
                    txtgender.Clear();
                    txttp.Clear();
                    txtentertudent.Focus();
                    con.Close();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtentertudent.Clear();
            txtfname.Clear();
            txtlastname.Clear();
            txtgender.Clear();
            txttp.Clear();
            txtentertudent.Focus();

        }
    }
}
