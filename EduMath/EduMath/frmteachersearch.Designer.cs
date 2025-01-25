namespace EduMath
{
    partial class frmteachersearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmteachersearch));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnexit = new Button();
            btntsearch = new Button();
            txtenterid = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btnclear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(455, 51);
            label1.Name = "label1";
            label1.Size = new Size(404, 41);
            label1.TabIndex = 2;
            label1.Text = "Teacher Information Search";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(372, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 80);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.SteelBlue;
            btnexit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.Location = new Point(1075, 167);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(140, 41);
            btnexit.TabIndex = 36;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // btntsearch
            // 
            btntsearch.BackColor = Color.SteelBlue;
            btntsearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btntsearch.Location = new Point(719, 167);
            btntsearch.Name = "btntsearch";
            btntsearch.Size = new Size(140, 41);
            btntsearch.TabIndex = 34;
            btntsearch.Text = "Search";
            btntsearch.UseVisualStyleBackColor = false;
            btntsearch.Click += btntsearch_Click;
            // 
            // txtenterid
            // 
            txtenterid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtenterid.Location = new Point(427, 174);
            txtenterid.Name = "txtenterid";
            txtenterid.Size = new Size(260, 34);
            txtenterid.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(70, 167);
            label2.Name = "label2";
            label2.Size = new Size(301, 41);
            label2.TabIndex = 38;
            label2.Text = "Enter the Teacher ID";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(70, 307);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1145, 323);
            dataGridView1.TabIndex = 39;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.SteelBlue;
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnclear.Location = new Point(894, 167);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(140, 41);
            btnclear.TabIndex = 40;
            btnclear.Text = "Clear Field";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // frmteachersearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1243, 674);
            ControlBox = false;
            Controls.Add(btnclear);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(txtenterid);
            Controls.Add(btnexit);
            Controls.Add(btntsearch);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmteachersearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmteachersearch";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnexit;
        private Button btntsearch;
        private TextBox txtenterid;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btnclear;
    }
}