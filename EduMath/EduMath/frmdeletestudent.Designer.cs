namespace EduMath
{
    partial class frmdeletestudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdeletestudent));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtentertudent = new TextBox();
            btntview = new Button();
            txtfname = new TextBox();
            txtlastname = new TextBox();
            txtgender = new TextBox();
            txttp = new TextBox();
            button1 = new Button();
            btndashboard = new Button();
            btnclear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(410, 41);
            label1.Name = "label1";
            label1.Size = new Size(422, 41);
            label1.TabIndex = 3;
            label1.Text = "Delete Student  Information ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(331, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 70);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 313);
            label2.Name = "label2";
            label2.Size = new Size(130, 31);
            label2.TabIndex = 5;
            label2.Text = "First Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 394);
            label3.Name = "label3";
            label3.Size = new Size(126, 31);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 470);
            label4.Name = "label4";
            label4.Size = new Size(91, 31);
            label4.TabIndex = 7;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(25, 553);
            label5.Name = "label5";
            label5.Size = new Size(191, 31);
            label5.TabIndex = 8;
            label5.Text = "Contact Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(25, 183);
            label6.Name = "label6";
            label6.Size = new Size(128, 31);
            label6.TabIndex = 9;
            label6.Text = "Student ID";
            // 
            // txtentertudent
            // 
            txtentertudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtentertudent.Location = new Point(242, 182);
            txtentertudent.Name = "txtentertudent";
            txtentertudent.Size = new Size(130, 34);
            txtentertudent.TabIndex = 10;
            // 
            // btntview
            // 
            btntview.BackColor = Color.SteelBlue;
            btntview.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btntview.Location = new Point(416, 173);
            btntview.Name = "btntview";
            btntview.Size = new Size(140, 41);
            btntview.TabIndex = 35;
            btntview.Text = "View Record";
            btntview.UseVisualStyleBackColor = false;
            btntview.Click += btntview_Click;
            // 
            // txtfname
            // 
            txtfname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtfname.Location = new Point(242, 310);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(314, 34);
            txtfname.TabIndex = 36;
            // 
            // txtlastname
            // 
            txtlastname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtlastname.Location = new Point(242, 391);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(314, 34);
            txtlastname.TabIndex = 37;
            // 
            // txtgender
            // 
            txtgender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtgender.Location = new Point(242, 471);
            txtgender.Name = "txtgender";
            txtgender.Size = new Size(314, 34);
            txtgender.TabIndex = 38;
            // 
            // txttp
            // 
            txttp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttp.Location = new Point(242, 550);
            txttp.Name = "txttp";
            txttp.Size = new Size(314, 34);
            txttp.TabIndex = 39;
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(953, 536);
            button1.Name = "button1";
            button1.Size = new Size(196, 48);
            button1.TabIndex = 40;
            button1.Text = "Delete Record";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btndashboard
            // 
            btndashboard.BackColor = Color.SteelBlue;
            btndashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btndashboard.Location = new Point(953, 12);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(196, 41);
            btndashboard.TabIndex = 41;
            btndashboard.Text = "Go To Dashboard";
            btndashboard.UseVisualStyleBackColor = false;
            btndashboard.Click += btndashboard_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.SteelBlue;
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnclear.Location = new Point(953, 440);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(196, 48);
            btnclear.TabIndex = 42;
            btnclear.Text = "Clear Fields";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // frmdeletestudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1161, 617);
            ControlBox = false;
            Controls.Add(btnclear);
            Controls.Add(btndashboard);
            Controls.Add(button1);
            Controls.Add(txttp);
            Controls.Add(txtgender);
            Controls.Add(txtlastname);
            Controls.Add(txtfname);
            Controls.Add(btntview);
            Controls.Add(txtentertudent);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmdeletestudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmdeletestudent";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtentertudent;
        private Button btntview;
        private TextBox txtfname;
        private TextBox txtlastname;
        private TextBox txtgender;
        private TextBox txttp;
        private Button button1;
        private Button btndashboard;
        private Button btnclear;
    }
}