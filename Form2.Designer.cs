
namespace Final_Project___Hans_Legaspi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.platformTop = new System.Windows.Forms.PictureBox();
            this.platformBottom = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.obstacleBottom = new System.Windows.Forms.PictureBox();
            this.obstacleTop = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.highscore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.obstacleMiddle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.platformTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleMiddle)).BeginInit();
            this.SuspendLayout();
            // 
            // platformTop
            // 
            this.platformTop.BackColor = System.Drawing.Color.Transparent;
            this.platformTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("platformTop.BackgroundImage")));
            this.platformTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.platformTop.Location = new System.Drawing.Point(-129, 69);
            this.platformTop.Name = "platformTop";
            this.platformTop.Size = new System.Drawing.Size(2082, 43);
            this.platformTop.TabIndex = 0;
            this.platformTop.TabStop = false;
            // 
            // platformBottom
            // 
            this.platformBottom.BackColor = System.Drawing.Color.Transparent;
            this.platformBottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("platformBottom.BackgroundImage")));
            this.platformBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.platformBottom.Location = new System.Drawing.Point(-129, 766);
            this.platformBottom.Name = "platformBottom";
            this.platformBottom.Size = new System.Drawing.Size(2068, 77);
            this.platformBottom.TabIndex = 1;
            this.platformBottom.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Final_Project___Hans_Legaspi.Properties.Resources._123;
            this.player.Location = new System.Drawing.Point(685, 690);
            this.player.MaximumSize = new System.Drawing.Size(61, 55);
            this.player.MinimumSize = new System.Drawing.Size(61, 55);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(61, 55);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // obstacleBottom
            // 
            this.obstacleBottom.BackColor = System.Drawing.Color.Transparent;
            this.obstacleBottom.Image = global::Final_Project___Hans_Legaspi.Properties.Resources._41312;
            this.obstacleBottom.Location = new System.Drawing.Point(996, 651);
            this.obstacleBottom.Name = "obstacleBottom";
            this.obstacleBottom.Size = new System.Drawing.Size(29, 127);
            this.obstacleBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacleBottom.TabIndex = 3;
            this.obstacleBottom.TabStop = false;
            this.obstacleBottom.Tag = "obstacle";
            // 
            // obstacleTop
            // 
            this.obstacleTop.BackColor = System.Drawing.Color.Transparent;
            this.obstacleTop.Image = global::Final_Project___Hans_Legaspi.Properties.Resources._41312;
            this.obstacleTop.Location = new System.Drawing.Point(436, 102);
            this.obstacleTop.Name = "obstacleTop";
            this.obstacleTop.Size = new System.Drawing.Size(29, 127);
            this.obstacleTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacleTop.TabIndex = 4;
            this.obstacleTop.TabStop = false;
            this.obstacleTop.Tag = "obstacle";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.Control;
            this.score.Location = new System.Drawing.Point(12, 15);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(158, 40);
            this.score.TabIndex = 5;
            this.score.Text = "Score : 0";
            // 
            // highscore
            // 
            this.highscore.AutoSize = true;
            this.highscore.BackColor = System.Drawing.Color.Transparent;
            this.highscore.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscore.ForeColor = System.Drawing.SystemColors.Control;
            this.highscore.Location = new System.Drawing.Point(12, 841);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(270, 44);
            this.highscore.TabIndex = 6;
            this.highscore.Text = "Highscore : 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 25;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // obstacleMiddle
            // 
            this.obstacleMiddle.BackColor = System.Drawing.Color.Transparent;
            this.obstacleMiddle.Image = global::Final_Project___Hans_Legaspi.Properties.Resources._41312;
            this.obstacleMiddle.Location = new System.Drawing.Point(1531, 349);
            this.obstacleMiddle.Name = "obstacleMiddle";
            this.obstacleMiddle.Size = new System.Drawing.Size(29, 127);
            this.obstacleMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacleMiddle.TabIndex = 8;
            this.obstacleMiddle.TabStop = false;
            this.obstacleMiddle.Tag = "obstacle";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project___Hans_Legaspi.Properties.Resources.desktop_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1815, 896);
            this.Controls.Add(this.obstacleMiddle);
            this.Controls.Add(this.highscore);
            this.Controls.Add(this.score);
            this.Controls.Add(this.obstacleTop);
            this.Controls.Add(this.obstacleBottom);
            this.Controls.Add(this.player);
            this.Controls.Add(this.platformBottom);
            this.Controls.Add(this.platformTop);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1837, 952);
            this.MinimumSize = new System.Drawing.Size(1837, 952);
            this.Name = "Form2";
            this.Text = "Space Run (1 Player)";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ControlPressed);
            ((System.ComponentModel.ISupportInitialize)(this.platformTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleMiddle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox platformTop;
        private System.Windows.Forms.PictureBox platformBottom;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox obstacleBottom;
        private System.Windows.Forms.PictureBox obstacleTop;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label highscore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox obstacleMiddle;
    }
}