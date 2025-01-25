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
using System.Runtime.InteropServices;

namespace EduMath
{
    public partial class frmteacherreg : Form
    {
        public frmteacherreg()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=studentlms;Integrated Security=True");
        SqlCommand com;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btntback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntclear_Click(object sender, EventArgs e)
        {
            txtteacherid.Clear();
            txttname.Clear();
            txttnic.Clear();
            txttcontactno.Clear();
            txttemail.Clear();
            rtxttadress.Clear();
            rdbtmale.Checked = false;
            rdbtfemale.Checked = false;
            comboBox1.SelectedIndex = -1;

        }

        private void btntsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string teacherid = txtteacherid.Text;
                string title = comboBox1.Text;
                string tname = txttname.Text;
                string tnic = txttnic.Text;
                string contactno = txttcontactno.Text;
                string temail = txttemail.Text;
                string taddress = rtxttadress.Text;
                string tgender = "";

                if (rdbtmale.Checked)
                {
                    tgender = "Male";
                }
                else if (rdbtfemale.Checked)
                {
                    tgender = "Female";
                }
                else
                {
                    MessageBox.Show("Plase select the gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // SQL Insert Query

                con.Open();
                string sqlinsert = "insert into teacher(teacherid,title,name,nicnumber,gender,contactnumber,emailid,address) values ( '" + teacherid + "', '" + title + "' , '" + tname + "' , '" + tnic + "' , '" + tgender + "' , '" + contactno + "' , '" + temail + "', '" + taddress + "' ) ";
                com = new SqlCommand(sqlinsert, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Record added succesfully.", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtteacherid.Clear();
                txttname.Clear();
                txttnic.Clear();
                txttcontactno.Clear();
                txttemail.Clear();
                rtxttadress.Clear();
                rdbtmale.Checked = false;
                rdbtfemale.Checked = false;
                comboBox1.SelectedIndex = -1;
                this.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }



        }
    }
}







