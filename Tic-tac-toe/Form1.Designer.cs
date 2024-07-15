namespace Tic_tac_toe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Start = new Button();
            panel1 = new Panel();
            Exit = new Button();
            panel2 = new Panel();
            Game_Name = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Start
            // 
            Start.BackColor = Color.Black;
            Start.Cursor = Cursors.Hand;
            Start.FlatAppearance.BorderColor = Color.Black;
            Start.FlatStyle = FlatStyle.Flat;
            Start.Font = new Font("Goudy Stout", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Start.ForeColor = Color.White;
            Start.Location = new Point(307, 286);
            Start.Name = "Start";
            Start.Size = new Size(196, 44);
            Start.TabIndex = 0;
            Start.Text = "Start";
            Start.TextImageRelation = TextImageRelation.TextBeforeImage;
            Start.UseVisualStyleBackColor = false;
            Start.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(Exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 81);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.Black;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Exit.ForeColor = Color.Red;
            Exit.Location = new Point(743, 3);
            Exit.Name = "Exit";
            Exit.Size = new Size(37, 40);
            Exit.TabIndex = 0;
            Exit.Text = "X";
            Exit.TextAlign = ContentAlignment.TopRight;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(Game_Name);
            panel2.Location = new Point(188, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 84);
            panel2.TabIndex = 3;
            // 
            // Game_Name
            // 
            Game_Name.Dock = DockStyle.Fill;
            Game_Name.Font = new Font("MV Boli", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Game_Name.ForeColor = Color.White;
            Game_Name.Location = new Point(0, 0);
            Game_Name.Name = "Game_Name";
            Game_Name.Size = new Size(428, 84);
            Game_Name.TabIndex = 0;
            Game_Name.Text = "TIC-TAC-TOE";
            Game_Name.TextAlign = ContentAlignment.MiddleCenter;
            Game_Name.Click += Game_Name_Click;
            Game_Name.MouseDown += Game_Name_MouseDown;
            Game_Name.MouseMove += Game_Name_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Script MT Bold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(593, 419);
            label1.Name = "label1";
            label1.Size = new Size(125, 22);
            label1.TabIndex = 4;
            label1.Text = "Created by Orca";
            label1.MouseDown += label1_MouseDown;
            label1.MouseMove += label1_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(724, 396);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(783, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Start);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Start;
        private Panel panel1;
        private Panel panel2;
        private Label Game_Name;
        private Button Exit;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
