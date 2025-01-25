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
    public partial class frmdashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=studentlms;Integrated Security=True");
        SqlCommand com;


        // Defining a new method for user roles 
        public string Role { get; }

        public frmdashboard(string role)
        {
            Role = role;
            InitializeComponent();
            // Giving access for the dashboard based on their user role
            logoutToolStripMenuItem.Visible = (role == "admin" || role == "teacher" || role == "student");
            aboutUsToolStripMenuItem.Visible = (role == "admin" || role == "teacher" || role == "student");
            lessonsToolStripMenuItem.Visible = (role == "admin" || role == "teacher" || role == "student");           
            admissionToolStripMenuItem.Visible = (role == "admin" || role == "teacher");
            searchStudentToolStripMenuItem.Visible = (role == "admin" || role == "teacher");
            updateDetailsToolStripMenuItem.Visible = (role == "admin" || role == "teacher");
            studentsToolStripMenuItem.Visible = (role == "admin" || role == "teacher");
            toolsToolStripMenuItem.Visible = (role == "teacher" || role == "student");
            removeStudentToolStripMenuItem.Visible = (role == "admin");
            teachersToolStripMenuItem.Visible = (role == "admin");
        }

        public frmdashboard()
        {
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display a MessageBox to confirm logout
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                frmlogin frm2 = new frmlogin();
                frm2.Show();
                this.Close();
            }
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaboutus frm3 = new frmaboutus();
            frm3.MdiParent = this;
            frm3.Show();

        }

        private void gradeAverageCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmcalculator frm4 = new Frmcalculator();
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnewadmission frm5 = new frmnewadmission();
            frm5.MdiParent = this;
            frm5.Show();
        }

        private void addTeacherInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmteacherreg frm6 = new frmteacherreg();
            frm6.MdiParent = this;
            frm6.Show();
        }
        private void searchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmteachersearch frm7 = new frmteachersearch();
            frm7.MdiParent = this;
            frm7.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdeletestudent frm8 = new frmdeletestudent();
            frm8.MdiParent = this;
            frm8.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmviewstudents frm9 = new frmviewstudents();
            frm9.MdiParent = this;
            frm9.Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstudentupdate frm10 = new frmstudentupdate();
            frm10.MdiParent = this;
            frm10.Show();
        }

        private void lessonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlessons frm11 = new frmlessons();
            frm11.MdiParent = this;
            frm11.Show();
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmdashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
