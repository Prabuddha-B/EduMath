namespace EduMath
{
    partial class frmteacherreg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmteacherreg));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txttname = new TextBox();
            label2 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            txtteacherid = new TextBox();
            rdbtfemale = new RadioButton();
            rdbtmale = new RadioButton();
            txttcontactno = new TextBox();
            txttnic = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            rtxttadress = new RichTextBox();
            label9 = new Label();
            txttemail = new TextBox();
            label11 = new Label();
            btntback = new Button();
            btntclear = new Button();
            btntsubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(411, 23);
            label1.Name = "label1";
            label1.Size = new Size(459, 41);
            label1.TabIndex = 1;
            label1.Text = "New Teacher Registration Form";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(350, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 55);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txttname
            // 
            txttname.Location = new Point(216, 292);
            txttname.Name = "txttname";
            txttname.Size = new Size(288, 27);
            txttname.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 292);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 11;
            label2.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 214);
            label4.Name = "label4";
            label4.Size = new Size(49, 28);
            label4.TabIndex = 15;
            label4.Text = "Title";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mr.", "Mrs.", "Miss.", "Dr.", "Rev." });
            comboBox1.Location = new Point(216, 218);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 28);
            comboBox1.TabIndex = 17;
            comboBox1.Text = "-Select-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(22, 141);
            label5.Name = "label5";
            label5.Size = new Size(101, 28);
            label5.TabIndex = 18;
            label5.Text = "Teacher ID";
            // 
            // txtteacherid
            // 
            txtteacherid.Location = new Point(216, 145);
            txtteacherid.Name = "txtteacherid";
            txtteacherid.Size = new Size(288, 27);
            txtteacherid.TabIndex = 19;
            // 
            // rdbtfemale
            // 
            rdbtfemale.AutoSize = true;
            rdbtfemale.BackColor = Color.Transparent;
            rdbtfemale.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdbtfemale.ForeColor = Color.White;
            rdbtfemale.Location = new Point(364, 449);
            rdbtfemale.Name = "rdbtfemale";
            rdbtfemale.Size = new Size(89, 29);
            rdbtfemale.TabIndex = 26;
            rdbtfemale.TabStop = true;
            rdbtfemale.Text = "Female";
            rdbtfemale.UseVisualStyleBackColor = false;
            // 
            // rdbtmale
            // 
            rdbtmale.AutoSize = true;
            rdbtmale.BackColor = Color.Transparent;
            rdbtmale.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdbtmale.ForeColor = Color.White;
            rdbtmale.Location = new Point(223, 450);
            rdbtmale.Name = "rdbtmale";
            rdbtmale.Size = new Size(71, 29);
            rdbtmale.TabIndex = 25;
            rdbtmale.TabStop = true;
            rdbtmale.Text = "Male";
            rdbtmale.UseVisualStyleBackColor = false;
            // 
            // txttcontactno
            // 
            txttcontactno.Location = new Point(216, 542);
            txttcontactno.Name = "txttcontactno";
            txttcontactno.Size = new Size(288, 27);
            txttcontactno.TabIndex = 24;
            // 
            // txttnic
            // 
            txttnic.Location = new Point(216, 371);
            txttnic.Name = "txttnic";
            txttnic.Size = new Size(288, 27);
            txttnic.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(22, 541);
            label7.Name = "label7";
            label7.Size = new Size(157, 28);
            label7.TabIndex = 22;
            label7.Text = "Contact Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 449);
            label6.Name = "label6";
            label6.Size = new Size(76, 28);
            label6.TabIndex = 21;
            label6.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 367);
            label8.Name = "label8";
            label8.Size = new Size(121, 28);
            label8.TabIndex = 20;
            label8.Text = "NIC Number";
            // 
            // rtxttadress
            // 
            rtxttadress.Location = new Point(763, 129);
            rtxttadress.Name = "rtxttadress";
            rtxttadress.Size = new Size(376, 89);
            rtxttadress.TabIndex = 30;
            rtxttadress.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(634, 145);
            label9.Name = "label9";
            label9.Size = new Size(82, 28);
            label9.TabIndex = 29;
            label9.Text = "Address";
            // 
            // txttemail
            // 
            txttemail.Location = new Point(216, 611);
            txttemail.Name = "txttemail";
            txttemail.Size = new Size(288, 27);
            txttemail.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(22, 611);
            label11.Name = "label11";
            label11.Size = new Size(83, 28);
            label11.TabIndex = 27;
            label11.Text = "Email ID";
            // 
            // btntback
            // 
            btntback.BackColor = Color.Cornsilk;
            btntback.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btntback.Location = new Point(837, 602);
            btntback.Name = "btntback";
            btntback.Size = new Size(257, 50);
            btntback.TabIndex = 33;
            btntback.Text = "Go to the Dashboard";
            btntback.UseVisualStyleBackColor = false;
            btntback.Click += btntback_Click;
            // 
            // btntclear
            // 
            btntclear.BackColor = Color.Cornsilk;
            btntclear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btntclear.Location = new Point(969, 519);
            btntclear.Name = "btntclear";
            btntclear.Size = new Size(235, 50);
            btntclear.TabIndex = 32;
            btntclear.Text = "Clear Fields";
            btntclear.UseVisualStyleBackColor = false;
            btntclear.Click += btntclear_Click;
            // 
            // btntsubmit
            // 
            btntsubmit.BackColor = Color.Cornsilk;
            btntsubmit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btntsubmit.Location = new Point(707, 519);
            btntsubmit.Name = "btntsubmit";
            btntsubmit.Size = new Size(235, 50);
            btntsubmit.TabIndex = 31;
            btntsubmit.Text = "Submit";
            btntsubmit.UseVisualStyleBackColor = false;
            btntsubmit.Click += btntsubmit_Click;
            // 
            // frmteacherreg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1243, 674);
            ControlBox = false;
            Controls.Add(btntback);
            Controls.Add(btntclear);
            Controls.Add(btntsubmit);
            Controls.Add(rtxttadress);
            Controls.Add(label9);
            Controls.Add(txttemail);
            Controls.Add(label11);
            Controls.Add(rdbtfemale);
            Controls.Add(rdbtmale);
            Controls.Add(txttcontactno);
            Controls.Add(txttnic);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(txtteacherid);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(txttname);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmteacherreg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher Registration Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txttname;
        private Label label2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox txtteacherid;
        private RadioButton rdbtfemale;
        private RadioButton rdbtmale;
        private TextBox txttcontactno;
        private TextBox txttnic;
        private Label label7;
        private Label label6;
        private Label label8;
        private RichTextBox rtxttadress;
        private Label label9;
        private TextBox txttemail;
        private Label label11;
        private Button btntback;
        private Button btntclear;
        private Button btntsubmit;
    }
}