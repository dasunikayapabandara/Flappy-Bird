namespace game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.score_lbl = new System.Windows.Forms.Label();
            this.game_time = new System.Windows.Forms.Timer(this.components);
            this.gameOverLable = new System.Windows.Forms.Label();
            this.exLife = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.pipe_top = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipe_bottem = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_bottem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.life3);
            this.panel1.Controls.Add(this.life2);
            this.panel1.Controls.Add(this.life1);
            this.panel1.Location = new System.Drawing.Point(-3, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 37);
            this.panel1.TabIndex = 4;
            // 
            // score_lbl
            // 
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.Location = new System.Drawing.Point(352, 402);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(158, 34);
            this.score_lbl.TabIndex = 5;
            this.score_lbl.Text = "Score";
            this.score_lbl.UseWaitCursor = true;
            // 
            // game_time
            // 
            this.game_time.Enabled = true;
            this.game_time.Interval = 20;
            this.game_time.Tick += new System.EventHandler(this.gametimetickevent);
            // 
            // gameOverLable
            // 
            this.gameOverLable.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gameOverLable.Font = new System.Drawing.Font("Millenium BdEx BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLable.Location = new System.Drawing.Point(-3, 155);
            this.gameOverLable.Name = "gameOverLable";
            this.gameOverLable.Size = new System.Drawing.Size(527, 77);
            this.gameOverLable.TabIndex = 6;
            this.gameOverLable.Text = " ";
            this.gameOverLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameOverLable.Visible = false;
            // 
            // exLife
            // 
            this.exLife.Image = global::game.Properties.Resources.heart_1;
            this.exLife.Location = new System.Drawing.Point(168, 59);
            this.exLife.Name = "exLife";
            this.exLife.Size = new System.Drawing.Size(43, 34);
            this.exLife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exLife.TabIndex = 3;
            this.exLife.TabStop = false;
            this.exLife.Click += new System.EventHandler(this.exLife_Click);
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bird.Image = global::game.Properties.Resources.bird_3;
            this.bird.Location = new System.Drawing.Point(5, 111);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(60, 41);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            this.bird.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // life3
            // 
            this.life3.Image = global::game.Properties.Resources.heart_1;
            this.life3.Location = new System.Drawing.Point(81, 0);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(43, 34);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life3.TabIndex = 2;
            this.life3.TabStop = false;
            // 
            // life2
            // 
            this.life2.Image = global::game.Properties.Resources.heart_1;
            this.life2.Location = new System.Drawing.Point(40, 0);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(44, 34);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life2.TabIndex = 1;
            this.life2.TabStop = false;
            this.life2.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // life1
            // 
            this.life1.Image = global::game.Properties.Resources.heart_1;
            this.life1.Location = new System.Drawing.Point(0, 0);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(43, 34);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life1.TabIndex = 0;
            this.life1.TabStop = false;
            this.life1.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pipe_top
            // 
            this.pipe_top.Image = global::game.Properties.Resources.pipeup3;
            this.pipe_top.Location = new System.Drawing.Point(417, 247);
            this.pipe_top.Name = "pipe_top";
            this.pipe_top.Size = new System.Drawing.Size(93, 108);
            this.pipe_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe_top.TabIndex = 3;
            this.pipe_top.TabStop = false;
            this.pipe_top.Click += new System.EventHandler(this.pipe_top_Click);
            // 
            // ground
            // 
            this.ground.Image = global::game.Properties.Resources.gr;
            this.ground.Location = new System.Drawing.Point(-3, 354);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(527, 126);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // pipe_bottem
            // 
            this.pipe_bottem.Image = global::game.Properties.Resources.pipedown;
            this.pipe_bottem.Location = new System.Drawing.Point(241, 0);
            this.pipe_bottem.Name = "pipe_bottem";
            this.pipe_bottem.Size = new System.Drawing.Size(93, 105);
            this.pipe_bottem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe_bottem.TabIndex = 1;
            this.pipe_bottem.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(522, 484);
            this.Controls.Add(this.exLife);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.gameOverLable);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pipe_top);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipe_bottem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUpEvent);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_bottem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipe_bottem;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipe_top;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Timer game_time;
        private System.Windows.Forms.Label gameOverLable;
        private System.Windows.Forms.PictureBox exLife;
    }
}

