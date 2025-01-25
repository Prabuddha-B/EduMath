namespace EduMath
{
    partial class frmlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Welcome = new Label();
            pbxlogo = new PictureBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            panel2 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            btnlogin = new Button();
            btnclearfields = new Button();
            btnexit = new Button();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 0, 89);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Welcome);
            panel1.Controls.Add(pbxlogo);
            panel1.Location = new Point(-64, -68);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 1093);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(179, 777);
            label3.Name = "label3";
            label3.Size = new Size(114, 33);
            label3.TabIndex = 4;
            label3.Text = "System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(76, 729);
            label2.Name = "label2";
            label2.Size = new Size(316, 33);
            label2.TabIndex = 3;
            label2.Text = "Learning Management";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 522);
            label1.Name = "label1";
            label1.Size = new Size(341, 70);
            label1.TabIndex = 2;
            label1.Text = "EduMATH";
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Bookman Old Style", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Welcome.ForeColor = Color.White;
            Welcome.Location = new Point(94, 457);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(270, 52);
            Welcome.TabIndex = 1;
            Welcome.Text = "Welcome to";
            // 
            // pbxlogo
            // 
            pbxlogo.Image = (Image)resources.GetObject("pbxlogo.Image");
            pbxlogo.Location = new Point(94, 186);
            pbxlogo.Name = "pbxlogo";
            pbxlogo.Size = new Size(283, 233);
            pbxlogo.TabIndex = 0;
            pbxlogo.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Handwriting", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(356, 12);
            label4.Name = "label4";
            label4.Size = new Size(438, 29);
            label4.TabIndex = 1;
            label4.Text = "Unlock the power of numbers : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 61);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 81);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 61);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(83, 101);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(245, 27);
            txtusername.TabIndex = 4;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(91, 102);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(245, 27);
            txtpassword.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtusername);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(401, 303);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 181);
            panel2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(112, 34);
            label5.Name = "label5";
            label5.Size = new Size(140, 33);
            label5.TabIndex = 5;
            label5.Text = "Username";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtpassword);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(870, 303);
            panel3.Name = "panel3";
            panel3.Size = new Size(355, 181);
            panel3.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(132, 35);
            label6.Name = "label6";
            label6.Size = new Size(134, 33);
            label6.TabIndex = 6;
            label6.Text = "Password";
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnlogin.Location = new Point(480, 594);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(155, 47);
            btnlogin.TabIndex = 8;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnclearfields
            // 
            btnclearfields.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnclearfields.Location = new Point(722, 594);
            btnclearfields.Name = "btnclearfields";
            btnclearfields.Size = new Size(155, 47);
            btnclearfields.TabIndex = 9;
            btnclearfields.Text = "Clear Fields";
            btnclearfields.UseVisualStyleBackColor = true;
            btnclearfields.Click += btnclearfields_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnexit.Location = new Point(961, 594);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(155, 47);
            btnexit.TabIndex = 10;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(990, 794);
            label7.Name = "label7";
            label7.Size = new Size(206, 26);
            label7.TabIndex = 11;
            label7.Text = "Need Assistance?";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1202, 773);
            button1.Name = "button1";
            button1.Size = new Size(68, 68);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Lucida Handwriting", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(757, 41);
            label8.Name = "label8";
            label8.Size = new Size(513, 29);
            label8.TabIndex = 13;
            label8.Text = "Your Path to Mathematical Mastery!";
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1282, 853);
            ControlBox = false;
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(btnexit);
            Controls.Add(btnclearfields);
            Controls.Add(btnlogin);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmlogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pbxlogo;
        private Label label1;
        private Label Welcome;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private Button btnlogin;
        private Button btnclearfields;
        private Button btnexit;
        private Label label7;
        private Button button1;
        private Label label8;
    }
}