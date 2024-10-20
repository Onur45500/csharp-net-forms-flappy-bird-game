namespace csharp_net_forms_flappy_bird_game
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
            bird = new PictureBox();
            pipBottom = new PictureBox();
            pipTop = new PictureBox();
            floor = new PictureBox();
            score = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)floor).BeginInit();
            SuspendLayout();
            // 
            // bird
            // 
            bird.Image = Properties.Resources.flappyBird;
            bird.InitialImage = Properties.Resources.flappyBird;
            bird.Location = new Point(47, 200);
            bird.Name = "bird";
            bird.Size = new Size(196, 144);
            bird.TabIndex = 0;
            bird.TabStop = false;
            bird.Click += bird_Click;
            // 
            // pipBottom
            // 
            pipBottom.Image = Properties.Resources.pipeBottom;
            pipBottom.Location = new Point(594, 406);
            pipBottom.Name = "pipBottom";
            pipBottom.Size = new Size(125, 62);
            pipBottom.TabIndex = 1;
            pipBottom.TabStop = false;
            // 
            // pipTop
            // 
            pipTop.Image = Properties.Resources.pipeTop;
            pipTop.Location = new Point(594, 2);
            pipTop.Name = "pipTop";
            pipTop.Size = new Size(125, 202);
            pipTop.TabIndex = 2;
            pipTop.TabStop = false;
            // 
            // floor
            // 
            floor.Location = new Point(1, 469);
            floor.Name = "floor";
            floor.Size = new Size(783, 74);
            floor.TabIndex = 3;
            floor.TabStop = false;
            // 
            // score
            // 
            score.Location = new Point(12, 12);
            score.Name = "score";
            score.Size = new Size(125, 27);
            score.TabIndex = 4;
            score.Text = "I";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(785, 545);
            Controls.Add(score);
            Controls.Add(floor);
            Controls.Add(pipTop);
            Controls.Add(pipBottom);
            Controls.Add(bird);
            Name = "Form1";
            Text = "Flappy Bird Game";
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)floor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bird;
        private PictureBox pipBottom;
        private PictureBox pipTop;
        private PictureBox floor;
        private TextBox score;
    }
}
