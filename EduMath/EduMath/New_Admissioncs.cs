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
    public partial class frmnewadmission : Form
    {

        public frmnewadmission()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=studentlms;Integrated Security=True");
        SqlCommand com;

        private void frmnewadmission_Load(object sender, EventArgs e)
        {

            // Code for auto incremented student ID
            SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=studentlms;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = " select MAX (studentnumber) from detail";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            label12.Text = (abc + 1).ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = txtfname.Text;
                string lastname = txtlname.Text;
                string dateofbirth = dateTimePicker1.Text;

                string gender = "";
                if (rdbmale.Checked)
                {
                    gender = "Male";
                }
                else if (rdbfemale.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    MessageBox.Show("Please select the gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                int contactnumber = int.Parse(txtcontactno.Text);
                string address = rtxtadress.Text;
                string school = txtschool.Text;
                string emailid = txtemail.Text;

                // SQL insert qury

                con.Open();
                string sqlinsert = "insert into detail(firstname,lastname,dateofbirth,gender,contactnumber,address,school,emailid) values('" + firstname + "', '" + lastname + "', '" + dateofbirth + "', '" + gender + "'," + contactnumber + ", '" + address + "', '" + school + "', '" + emailid + "') ";
                com = new SqlCommand(sqlinsert, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Record added succesfully. Please remember the student number.", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtfname.Clear();
                txtlname.Clear();

                txtcontactno.Clear();
                txtemail.Clear();
                txtschool.Clear();
                rtxtadress.Clear();
                rdbmale.Checked = false;
                rdbfemale.Checked = false;
                dateTimePicker1.Text = "";
                txtfname.Focus();
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfname.Clear();
            txtlname.Clear();

            txtcontactno.Clear();
            txtemail.Clear();
            txtschool.Clear();
            rtxtadress.Clear();
            rdbmale.Checked = false;
            rdbfemale.Checked = false;
            dateTimePicker1.Text = "";
            txtfname.Focus();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
