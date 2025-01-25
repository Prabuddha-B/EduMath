namespace EduMath
{
    partial class frmdashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdashboard));
            menuStrip1 = new MenuStrip();
            admissionToolStripMenuItem = new ToolStripMenuItem();
            newAdmissionToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            searchStudentToolStripMenuItem = new ToolStripMenuItem();
            updateDetailsToolStripMenuItem = new ToolStripMenuItem();
            removeStudentToolStripMenuItem = new ToolStripMenuItem();
            teachersToolStripMenuItem = new ToolStripMenuItem();
            addTeacherInformationToolStripMenuItem = new ToolStripMenuItem();
            searchDetailsToolStripMenuItem = new ToolStripMenuItem();
            lessonsToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            gradeAverageCalculatorToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SteelBlue;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { admissionToolStripMenuItem, studentsToolStripMenuItem, teachersToolStripMenuItem, lessonsToolStripMenuItem, toolsToolStripMenuItem, aboutUsToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1282, 78);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // admissionToolStripMenuItem
            // 
            admissionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newAdmissionToolStripMenuItem });
            admissionToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            admissionToolStripMenuItem.Image = (Image)resources.GetObject("admissionToolStripMenuItem.Image");
            admissionToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            admissionToolStripMenuItem.Name = "admissionToolStripMenuItem";
            admissionToolStripMenuItem.Size = new Size(183, 74);
            admissionToolStripMenuItem.Text = "Admission";
            admissionToolStripMenuItem.Click += admissionToolStripMenuItem_Click;
            // 
            // newAdmissionToolStripMenuItem
            // 
            newAdmissionToolStripMenuItem.Name = "newAdmissionToolStripMenuItem";
            newAdmissionToolStripMenuItem.Size = new Size(228, 30);
            newAdmissionToolStripMenuItem.Text = "New Admission";
            newAdmissionToolStripMenuItem.Click += newAdmissionToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchStudentToolStripMenuItem, updateDetailsToolStripMenuItem, removeStudentToolStripMenuItem });
            studentsToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            studentsToolStripMenuItem.Image = (Image)resources.GetObject("studentsToolStripMenuItem.Image");
            studentsToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            studentsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(170, 74);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // searchStudentToolStripMenuItem
            // 
            searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            searchStudentToolStripMenuItem.Size = new Size(285, 30);
            searchStudentToolStripMenuItem.Text = "Search Student Details";
            searchStudentToolStripMenuItem.Click += searchStudentToolStripMenuItem_Click;
            // 
            // updateDetailsToolStripMenuItem
            // 
            updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            updateDetailsToolStripMenuItem.Size = new Size(285, 30);
            updateDetailsToolStripMenuItem.Text = "Update Details";
            updateDetailsToolStripMenuItem.Click += updateDetailsToolStripMenuItem_Click;
            // 
            // removeStudentToolStripMenuItem
            // 
            removeStudentToolStripMenuItem.Name = "removeStudentToolStripMenuItem";
            removeStudentToolStripMenuItem.Size = new Size(285, 30);
            removeStudentToolStripMenuItem.Text = "Remove Student";
            removeStudentToolStripMenuItem.Click += removeStudentToolStripMenuItem_Click;
            // 
            // teachersToolStripMenuItem
            // 
            teachersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addTeacherInformationToolStripMenuItem, searchDetailsToolStripMenuItem });
            teachersToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            teachersToolStripMenuItem.Image = (Image)resources.GetObject("teachersToolStripMenuItem.Image");
            teachersToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            teachersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            teachersToolStripMenuItem.Size = new Size(166, 74);
            teachersToolStripMenuItem.Text = "Teachers";
            teachersToolStripMenuItem.Click += teachersToolStripMenuItem_Click;
            // 
            // addTeacherInformationToolStripMenuItem
            // 
            addTeacherInformationToolStripMenuItem.Name = "addTeacherInformationToolStripMenuItem";
            addTeacherInformationToolStripMenuItem.Size = new Size(303, 30);
            addTeacherInformationToolStripMenuItem.Text = "Add Teacher Information";
            addTeacherInformationToolStripMenuItem.Click += addTeacherInformationToolStripMenuItem_Click;
            // 
            // searchDetailsToolStripMenuItem
            // 
            searchDetailsToolStripMenuItem.Name = "searchDetailsToolStripMenuItem";
            searchDetailsToolStripMenuItem.Size = new Size(303, 30);
            searchDetailsToolStripMenuItem.Text = "Search Details";
            searchDetailsToolStripMenuItem.Click += searchDetailsToolStripMenuItem_Click;
            // 
            // lessonsToolStripMenuItem
            // 
            lessonsToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lessonsToolStripMenuItem.Image = (Image)resources.GetObject("lessonsToolStripMenuItem.Image");
            lessonsToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            lessonsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            lessonsToolStripMenuItem.Name = "lessonsToolStripMenuItem";
            lessonsToolStripMenuItem.Size = new Size(161, 74);
            lessonsToolStripMenuItem.Text = "Lessons";
            lessonsToolStripMenuItem.Click += lessonsToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gradeAverageCalculatorToolStripMenuItem });
            toolsToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            toolsToolStripMenuItem.Image = (Image)resources.GetObject("toolsToolStripMenuItem.Image");
            toolsToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            toolsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(139, 74);
            toolsToolStripMenuItem.Text = "Tools";
            toolsToolStripMenuItem.Click += toolsToolStripMenuItem_Click;
            // 
            // gradeAverageCalculatorToolStripMenuItem
            // 
            gradeAverageCalculatorToolStripMenuItem.Name = "gradeAverageCalculatorToolStripMenuItem";
            gradeAverageCalculatorToolStripMenuItem.Size = new Size(309, 30);
            gradeAverageCalculatorToolStripMenuItem.Text = "Grade Average Calculator";
            gradeAverageCalculatorToolStripMenuItem.Click += gradeAverageCalculatorToolStripMenuItem_Click;
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            aboutUsToolStripMenuItem.Image = (Image)resources.GetObject("aboutUsToolStripMenuItem.Image");
            aboutUsToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            aboutUsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(174, 74);
            aboutUsToolStripMenuItem.Text = "About Us";
            aboutUsToolStripMenuItem.Click += aboutUsToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            logoutToolStripMenuItem.Image = (Image)resources.GetObject("logoutToolStripMenuItem.Image");
            logoutToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            logoutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(156, 74);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // frmdashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1282, 853);
            ControlBox = false;
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmdashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += frmdashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem admissionToolStripMenuItem;
        private ToolStripMenuItem newAdmissionToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem searchStudentToolStripMenuItem;
        private ToolStripMenuItem removeStudentToolStripMenuItem;
        private ToolStripMenuItem teachersToolStripMenuItem;
        private ToolStripMenuItem addTeacherInformationToolStripMenuItem;
        private ToolStripMenuItem searchDetailsToolStripMenuItem;
        private ToolStripMenuItem lessonsToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem gradeAverageCalculatorToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem updateDetailsToolStripMenuItem;
    }
}