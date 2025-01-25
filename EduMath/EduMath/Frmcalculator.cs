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
    public partial class Frmcalculator : Form
    {
        public Frmcalculator()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get inputs from the Text boxes

                float part1marks = float.Parse(txtpart1marks.Text);
                float part2Amarks = float.Parse(txtpart2Amarks.Text);
                float part2Bmarks = float.Parse(txtpart2Bmarks.Text);
                float part3marks = float.Parse(txtpart3marks.Text);

                // Using IF for ensure user do not enter marks higher than 100

                if (part1marks > 100 || part2Amarks > 100 || part2Bmarks > 100 || part3marks > 100)
                {
                    MessageBox.Show("Invalid input. Marks cannot exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpart1marks.Clear();
                    txtpart2Amarks.Clear();
                    txtpart2Bmarks.Clear();
                    txtpart3marks.Clear();
                    txttotal.Clear();
                    txtaverage.Clear();
                    txtgrade.Clear();
                }

                else
                {
                    // Calculation Part

                    float total = part1marks + part2Amarks + part2Bmarks + part3marks;
                    float average = total / 4;

                    // Using if for grading system

                    string grade;

                    if (average >= 75)
                    {
                        grade = "A";
                    }
                    else if (average >= 65)
                    {
                        grade = "B";
                    }
                    else if (average >= 55)
                    {
                        grade = "C";
                    }
                    else if (average >= 45)
                    {
                        grade = "S";
                    }
                    else
                    {
                        grade = "FAIL";
                    }

                    // Displaying the Calculated outputs

                    txttotal.Text = total.ToString();
                    txtaverage.Text = average.ToString();
                    txtgrade.Text = grade.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // Display a clear confirmation messeage box 
            DialogResult result = MessageBox.Show("Are you sure you want to clear the fields", "Clear Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtpart1marks.Clear();
                txtpart2Amarks.Clear();
                txtpart2Bmarks.Clear();
                txtpart3marks.Clear();
                txttotal.Clear();
                txtaverage.Clear();
                txtgrade.Clear();
            }
        }

        private void btnexitcalculator_Click(object sender, EventArgs e)
        {
            // Display a exit confirmation messeage box 
            DialogResult result = MessageBox.Show("Are you sure you want to exit the calculator", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
