namespace EduMath
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnclearfields_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // Display a MessageBox to confirm exit
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Display a messegebox for contact hotline (For Spcaes between line = \n)
            MessageBox.Show("Please contact our hotline:+94115548696 .\n\nOur team is here to assist you with any questions or concerns you may have.\n\nYour call is important to us, and we are dedicated to providing you with the information and support you need.", "Welcome to EduMATH Hotline Service", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin1" && txtpassword.Text == "admin1")
            {
                LoginSuccess("admin");
            }
            else if (txtusername.Text == "teacher1" && txtpassword.Text == "teacher1")
            {
                LoginSuccess("teacher");
            }
            else if (txtusername.Text == "student1" && txtpassword.Text == "student1")
            {
                LoginSuccess("student");
            }
            else
            {
                MessageBox.Show("Login Failed. Please check your credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void LoginSuccess(string role)
        {
            MessageBox.Show("Successfully logged in as " + role, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            {
                // Giving access to student dashboard
                frmdashboard frm1 = new frmdashboard(role);
                frm1.Show();
                this.Hide();
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}