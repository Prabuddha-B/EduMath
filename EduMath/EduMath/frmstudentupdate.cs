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
using System.Linq.Expressions;

namespace EduMath
{
    public partial class frmstudentupdate : Form
    {
        public frmstudentupdate()
        {
            InitializeComponent();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=studentlms;Integrated Security=True");
                SqlCommand com;
                con.Open();

                string sqlselect = "select * from detail where studentnumber = '" + txtstudentnumber.Text + "'";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    lblfname.Text = dr["firstname"].ToString();
                    lbllname.Text = dr["lastname"].ToString();
                    lblgender.Text = dr["gender"].ToString();
                    //lbldob.Text = dr["dateofbirth"].ToString();

                    // Converting Full format of datetimepicker to show only the date not time.
                    DateTime dobfromdatabase = Convert.ToDateTime(dr["dateofbirth"]);
                    string formatteddate = dobfromdatabase.ToShortDateString();
                    lbldob.Text = formatteddate;

                    txtcontact.Text = dr["contactnumber"].ToString();
                    txtemail.Text = dr["emailid"].ToString();
                    txtschool.Text = dr["school"].ToString();
                    rtxtaddress.Text = dr["address"].ToString();

                    con.Close();
                }

                else
                {
                    MessageBox.Show("Record not found", "Error");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtstudentnumber.Clear();
            rtxtaddress.Clear();
            txtcontact.Clear();
            txtemail.Clear();
            txtschool.Clear();
            txtstudentnumber.Focus();
            lbldob.Text = "";
            lblfname.Text = "";
            lbllname.Text = "";
            lblgender.Text = "";

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=studentlms;Integrated Security=True");
                SqlCommand com;
                

                string sqlupdate = "update detail set emailid = '" + txtemail.Text + "', contactnumber ='" + txtcontact.Text + "',address='" + rtxtaddress.Text + "' , school='" + txtschool.Text + "' where studentnumber= '"+txtstudentnumber.Text+"'";
                
                SqlCommand cmnd = new SqlCommand(sqlupdate, con);
                con.Open();
                cmnd.ExecuteNonQuery();
               


                MessageBox.Show("Record Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstudentnumber.Clear();
                txtemail.Clear();
                txtcontact.Clear();
                rtxtaddress.Clear();
                txtschool.Clear();
                txtstudentnumber.Focus();
                lbldob.Text = "";
                lblfname.Text = "";
                lbllname.Text = "";
                lblgender.Text = "";
                txtstudentnumber.Focus();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
