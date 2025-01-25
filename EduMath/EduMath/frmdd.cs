using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduMath
{
    public partial class frmdd : Form
    {
        public frmdd()
        {
            InitializeComponent();
        }

        private void gradeAverageCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmcalculator frm6 = new Frmcalculator();
            frm6.MdiParent = this;
            frm6.Show();
        }
    }
}
