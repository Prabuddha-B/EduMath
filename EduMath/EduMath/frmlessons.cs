using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduMath
{
    public partial class frmlessons : Form
    {
        public frmlessons()
        {
            InitializeComponent();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsets_Click(object sender, EventArgs e)
        {
            string youtubeUrl = "https://www.youtube.com/watch?v=l3-A0O42Lyo";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = youtubeUrl,
                    UseShellExecute = true,

                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening YouTube link: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnalgebra_Click(object sender, EventArgs e)
        {
            string youtubeUrl1 = "https://www.youtube.com/watch?v=OF2GtIinL_s";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = youtubeUrl1,
                    UseShellExecute = true,

                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening YouTube link: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnmatrix_Click(object sender, EventArgs e)
        {
            string youtubeUrl2 = "https://www.youtube.com/watch?v=QXUbFzEd3Ww";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = youtubeUrl2,
                    UseShellExecute = true,

                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening YouTube link: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnpro_Click(object sender, EventArgs e)
        {
            string youtubeUrl3 = "https://www.youtube.com/watch?v=ONoWZ1rzYJA";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = youtubeUrl3,
                    UseShellExecute = true,

                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening YouTube link: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntrig_Click(object sender, EventArgs e)
        {
            string youtubeUrl3 = "https://www.youtube.com/watch?v=T9lt6MZKLck";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = youtubeUrl3,
                    UseShellExecute = true,

                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening YouTube link: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btngraph_Click(object sender, EventArgs e)
        {
            string youtubeUrl3 = "https://www.youtube.com/watch?v=-VgHk7UMPP4";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = youtubeUrl3,
                    UseShellExecute = true,

                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening YouTube link: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
