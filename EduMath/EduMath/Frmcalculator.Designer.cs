namespace EduMath
{
    partial class Frmcalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcalculator));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtpart1marks = new TextBox();
            txtpart2Amarks = new TextBox();
            txtpart2Bmarks = new TextBox();
            txtpart3marks = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txttotal = new TextBox();
            txtaverage = new TextBox();
            txtgrade = new TextBox();
            btncalculate = new Button();
            btnclear = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnexitcalculator = new Button();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(250, 29);
            label1.Name = "label1";
            label1.Size = new Size(763, 81);
            label1.TabIndex = 0;
            label1.Text = "Grade Average Calculator";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(167, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 76);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1019, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 76);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 186);
            label2.Name = "label2";
            label2.Size = new Size(140, 31);
            label2.TabIndex = 3;
            label2.Text = "Part 1 Marks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 271);
            label3.Name = "label3";
            label3.Size = new Size(155, 31);
            label3.TabIndex = 4;
            label3.Text = "Part 2A Marks";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(43, 350);
            label4.Name = "label4";
            label4.Size = new Size(153, 31);
            label4.TabIndex = 5;
            label4.Text = "Part 2B Marks";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(43, 435);
            label5.Name = "label5";
            label5.Size = new Size(140, 31);
            label5.TabIndex = 6;
            label5.Text = "Part 3 Marks";
            // 
            // txtpart1marks
            // 
            txtpart1marks.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtpart1marks.Location = new Point(262, 186);
            txtpart1marks.Name = "txtpart1marks";
            txtpart1marks.Size = new Size(197, 31);
            txtpart1marks.TabIndex = 7;
            // 
            // txtpart2Amarks
            // 
            txtpart2Amarks.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtpart2Amarks.Location = new Point(262, 271);
            txtpart2Amarks.Name = "txtpart2Amarks";
            txtpart2Amarks.Size = new Size(197, 31);
            txtpart2Amarks.TabIndex = 8;
            // 
            // txtpart2Bmarks
            // 
            txtpart2Bmarks.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtpart2Bmarks.Location = new Point(262, 354);
            txtpart2Bmarks.Name = "txtpart2Bmarks";
            txtpart2Bmarks.Size = new Size(197, 31);
            txtpart2Bmarks.TabIndex = 9;
            // 
            // txtpart3marks
            // 
            txtpart3marks.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtpart3marks.Location = new Point(262, 439);
            txtpart3marks.Name = "txtpart3marks";
            txtpart3marks.Size = new Size(197, 31);
            txtpart3marks.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(744, 186);
            label6.Name = "label6";
            label6.Size = new Size(100, 50);
            label6.TabIndex = 11;
            label6.Text = "Total";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(733, 297);
            label7.Name = "label7";
            label7.Size = new Size(155, 50);
            label7.TabIndex = 12;
            label7.Text = "Average";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(744, 420);
            label8.Name = "label8";
            label8.Size = new Size(120, 50);
            label8.TabIndex = 13;
            label8.Text = "Grade";
            // 
            // txttotal
            // 
            txttotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttotal.Location = new Point(946, 192);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(195, 31);
            txttotal.TabIndex = 14;
            // 
            // txtaverage
            // 
            txtaverage.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtaverage.Location = new Point(946, 308);
            txtaverage.Name = "txtaverage";
            txtaverage.Size = new Size(195, 31);
            txtaverage.TabIndex = 15;
            // 
            // txtgrade
            // 
            txtgrade.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtgrade.Location = new Point(946, 441);
            txtgrade.Name = "txtgrade";
            txtgrade.Size = new Size(195, 31);
            txtgrade.TabIndex = 16;
            // 
            // btncalculate
            // 
            btncalculate.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btncalculate.Location = new Point(215, 590);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(159, 52);
            btncalculate.TabIndex = 17;
            btncalculate.Text = "Calculate";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnclear.Location = new Point(601, 590);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(159, 52);
            btnclear.TabIndex = 18;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(130, 576);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(79, 77);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(515, 576);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 77);
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // btnexitcalculator
            // 
            btnexitcalculator.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnexitcalculator.Location = new Point(993, 590);
            btnexitcalculator.Name = "btnexitcalculator";
            btnexitcalculator.Size = new Size(159, 52);
            btnexitcalculator.TabIndex = 21;
            btnexitcalculator.Text = "Exit";
            btnexitcalculator.UseVisualStyleBackColor = true;
            btnexitcalculator.Click += btnexitcalculator_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(908, 576);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(79, 82);
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // Frmcalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1243, 674);
            ControlBox = false;
            Controls.Add(pictureBox5);
            Controls.Add(btnexitcalculator);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(btnclear);
            Controls.Add(btncalculate);
            Controls.Add(txtgrade);
            Controls.Add(txtaverage);
            Controls.Add(txttotal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtpart3marks);
            Controls.Add(txtpart2Bmarks);
            Controls.Add(txtpart2Amarks);
            Controls.Add(txtpart1marks);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frmcalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grade Average Calculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtpart1marks;
        private TextBox txtpart2Amarks;
        private TextBox txtpart2Bmarks;
        private TextBox txtpart3marks;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txttotal;
        private TextBox txtaverage;
        private TextBox txtgrade;
        private Button btncalculate;
        private Button btnclear;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnexitcalculator;
        private PictureBox pictureBox5;
    }
}