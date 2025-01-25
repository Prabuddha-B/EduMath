namespace EduMath
{
    partial class frmlessons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlessons));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btndashboard = new Button();
            btnsets = new Button();
            btnalgebra = new Button();
            btnmatrix = new Button();
            btngraph = new Button();
            btntrig = new Button();
            btnpro = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(589, 23);
            label1.Name = "label1";
            label1.Size = new Size(124, 41);
            label1.TabIndex = 4;
            label1.Text = "Lessons";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(506, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 77);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btndashboard
            // 
            btndashboard.BackColor = Color.SteelBlue;
            btndashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btndashboard.Location = new Point(1065, 9);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(196, 41);
            btndashboard.TabIndex = 42;
            btndashboard.Text = "Go To Dashboard";
            btndashboard.UseVisualStyleBackColor = false;
            btndashboard.Click += btndashboard_Click;
            // 
            // btnsets
            // 
            btnsets.BackColor = Color.Transparent;
            btnsets.Image = (Image)resources.GetObject("btnsets.Image");
            btnsets.Location = new Point(12, 139);
            btnsets.Name = "btnsets";
            btnsets.Size = new Size(389, 229);
            btnsets.TabIndex = 43;
            btnsets.UseVisualStyleBackColor = false;
            btnsets.Click += btnsets_Click;
            // 
            // btnalgebra
            // 
            btnalgebra.Image = (Image)resources.GetObject("btnalgebra.Image");
            btnalgebra.Location = new Point(445, 139);
            btnalgebra.Name = "btnalgebra";
            btnalgebra.Size = new Size(389, 229);
            btnalgebra.TabIndex = 44;
            btnalgebra.UseVisualStyleBackColor = true;
            btnalgebra.Click += btnalgebra_Click;
            // 
            // btnmatrix
            // 
            btnmatrix.BackgroundImage = (Image)resources.GetObject("btnmatrix.BackgroundImage");
            btnmatrix.Location = new Point(860, 139);
            btnmatrix.Name = "btnmatrix";
            btnmatrix.Size = new Size(389, 229);
            btnmatrix.TabIndex = 45;
            btnmatrix.UseVisualStyleBackColor = true;
            btnmatrix.Click += btnmatrix_Click;
            // 
            // btngraph
            // 
            btngraph.Image = (Image)resources.GetObject("btngraph.Image");
            btngraph.Location = new Point(860, 421);
            btngraph.Name = "btngraph";
            btngraph.Size = new Size(389, 229);
            btngraph.TabIndex = 48;
            btngraph.UseVisualStyleBackColor = true;
            btngraph.Click += btngraph_Click;
            // 
            // btntrig
            // 
            btntrig.Image = (Image)resources.GetObject("btntrig.Image");
            btntrig.Location = new Point(445, 421);
            btntrig.Name = "btntrig";
            btntrig.Size = new Size(389, 229);
            btntrig.TabIndex = 47;
            btntrig.UseVisualStyleBackColor = true;
            btntrig.Click += btntrig_Click;
            // 
            // btnpro
            // 
            btnpro.BackgroundImage = (Image)resources.GetObject("btnpro.BackgroundImage");
            btnpro.Location = new Point(12, 421);
            btnpro.Name = "btnpro";
            btnpro.Size = new Size(389, 229);
            btnpro.TabIndex = 46;
            btnpro.UseVisualStyleBackColor = true;
            btnpro.Click += btnpro_Click;
            // 
            // frmlessons
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1261, 721);
            ControlBox = false;
            Controls.Add(btngraph);
            Controls.Add(btntrig);
            Controls.Add(btnpro);
            Controls.Add(btnmatrix);
            Controls.Add(btnalgebra);
            Controls.Add(btnsets);
            Controls.Add(btndashboard);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmlessons";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmlessons";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btndashboard;
        private Button btnsets;
        private Button btnalgebra;
        private Button btnmatrix;
        private Button btngraph;
        private Button btntrig;
        private Button btnpro;
    }
}