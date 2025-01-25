namespace EduMath
{
    partial class frmviewstudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmviewstudents));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnclear = new Button();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            txtenterstudent = new TextBox();
            btntsearch = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(462, 26);
            label1.Name = "label1";
            label1.Size = new Size(408, 41);
            label1.TabIndex = 3;
            label1.Text = "Student Information Search";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(382, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 79);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.SteelBlue;
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnclear.Location = new Point(875, 128);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(140, 41);
            btnclear.TabIndex = 46;
            btnclear.Text = "Clear Field";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(38, 223);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1193, 323);
            dataGridView2.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 131);
            label2.Name = "label2";
            label2.Size = new Size(389, 41);
            label2.TabIndex = 44;
            label2.Text = "Enter the Student Number";
            // 
            // txtenterstudent
            // 
            txtenterstudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtenterstudent.Location = new Point(424, 135);
            txtenterstudent.Name = "txtenterstudent";
            txtenterstudent.Size = new Size(283, 34);
            txtenterstudent.TabIndex = 43;
            // 
            // btntsearch
            // 
            btntsearch.BackColor = Color.SteelBlue;
            btntsearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btntsearch.Location = new Point(730, 128);
            btntsearch.Name = "btntsearch";
            btntsearch.Size = new Size(140, 41);
            btntsearch.TabIndex = 41;
            btntsearch.Text = "Search";
            btntsearch.UseVisualStyleBackColor = false;
            btntsearch.Click += btntsearch_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1021, 586);
            button1.Name = "button1";
            button1.Size = new Size(188, 41);
            button1.TabIndex = 47;
            button1.Text = "Go To Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1030, 128);
            button2.Name = "button2";
            button2.Size = new Size(188, 41);
            button2.TabIndex = 48;
            button2.Text = "View All ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // frmviewstudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1243, 674);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnclear);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(txtenterstudent);
            Controls.Add(btntsearch);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmviewstudents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmviewstudents";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnclear;
        private DataGridView dataGridView2;
        private Label label2;
        private TextBox txtenterstudent;
        private Button btntsearch;
        private Button button1;
        private Button button2;
    }
}