namespace Tic_tac_toe
{
    partial class DRAW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DRAW));
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Castellar", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(314, 225);
            button1.Name = "button1";
            button1.Size = new Size(194, 61);
            button1.TabIndex = 2;
            button1.Text = "Repeat";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Castellar", 13.8F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(314, 333);
            button2.Name = "button2";
            button2.Size = new Size(194, 61);
            button2.TabIndex = 3;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(171, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 120);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("MS Gothic", 72F, FontStyle.Bold);
            label1.Location = new Point(101, 0);
            label1.Name = "label1";
            label1.Size = new Size(294, 120);
            label1.TabIndex = 0;
            label1.Text = "DRAW";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._6;
            pictureBox1.Location = new Point(67, 249);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(566, 249);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 145);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // DRAW
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DRAW";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DRAW";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}