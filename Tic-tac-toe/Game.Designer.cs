namespace Tic_tac_toe
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            panel1 = new Panel();
            label1 = new Label();
            Exit = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1942, 117);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Stout", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(455, 3);
            label1.Name = "label1";
            label1.Size = new Size(988, 110);
            label1.TabIndex = 16;
            label1.Text = "TIC-TAC-TOE";
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.Black;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Exit.ForeColor = Color.Red;
            Exit.Location = new Point(1867, 3);
            Exit.Name = "Exit";
            Exit.Size = new Size(47, 52);
            Exit.TabIndex = 0;
            Exit.Text = "X";
            Exit.TextAlign = ContentAlignment.TopRight;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(39, 31);
            button1.Name = "button1";
            button1.Size = new Size(125, 125);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 48F);
            button2.Location = new Point(235, 31);
            button2.Name = "button2";
            button2.Size = new Size(125, 125);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 48F);
            button3.Location = new Point(439, 31);
            button3.Name = "button3";
            button3.Size = new Size(125, 125);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Rounded MT Bold", 48F);
            button4.Location = new Point(39, 220);
            button4.Name = "button4";
            button4.Size = new Size(125, 125);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Rounded MT Bold", 48F);
            button5.Location = new Point(235, 220);
            button5.Name = "button5";
            button5.Size = new Size(125, 125);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DimGray;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial Rounded MT Bold", 48F);
            button6.Location = new Point(439, 220);
            button6.Name = "button6";
            button6.Size = new Size(125, 125);
            button6.TabIndex = 9;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.DimGray;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Arial Rounded MT Bold", 48F);
            button7.Location = new Point(39, 423);
            button7.Name = "button7";
            button7.Size = new Size(125, 125);
            button7.TabIndex = 10;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DimGray;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial Rounded MT Bold", 48F);
            button8.Location = new Point(235, 423);
            button8.Name = "button8";
            button8.Size = new Size(125, 125);
            button8.TabIndex = 11;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.DimGray;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Arial Rounded MT Bold", 48F);
            button9.Location = new Point(439, 423);
            button9.Name = "button9";
            button9.Size = new Size(125, 125);
            button9.TabIndex = 12;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(658, 258);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 600);
            panel2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(99, 258);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1425, 258);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(391, 600);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1942, 909);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Game";
            Text = "Game";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Exit;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}