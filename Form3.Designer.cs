
namespace Final_Project___Hans_Legaspi
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.platformBottom = new System.Windows.Forms.PictureBox();
            this.platformTop = new System.Windows.Forms.PictureBox();
            this.obstacleMiddle = new System.Windows.Forms.PictureBox();
            this.obstacleBottom = new System.Windows.Forms.PictureBox();
            this.obstacleTop = new System.Windows.Forms.PictureBox();
            this.player1Score = new System.Windows.Forms.Label();
            this.player2Score = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.gameTimerEvent = new System.Windows.Forms.Timer(this.components);
            this.gameOverText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.platformBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            this.SuspendLayout();
            // 
            // platformBottom
            // 
            this.platformBottom.BackColor = System.Drawing.Color.Transparent;
            this.platformBottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("platformBottom.BackgroundImage")));
            this.platformBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.platformBottom.Location = new System.Drawing.Point(-143, 816);
            this.platformBottom.Name = "platformBottom";
            this.platformBottom.Size = new System.Drawing.Size(2068, 77);
            this.platformBottom.TabIndex = 2;
            this.platformBottom.TabStop = false;
            // 
            // platformTop
            // 
            this.platformTop.BackColor = System.Drawing.Color.Transparent;
            this.platformTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("platformTop.BackgroundImage")));
            this.platformTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.platformTop.Location = new System.Drawing.Point(-143, 72);
            this.platformTop.Name = "platformTop";
            this.platformTop.Size = new System.Drawing.Size(2068, 77);
            this.platformTop.TabIndex = 3;
            this.platformTop.TabStop = false;
            // 
            // obstacleMiddle
            // 
            this.obstacleMiddle.BackColor = System.Drawing.Color.Transparent;
            this.obstacleMiddle.Image = global::Final_Project___Hans_Legaspi.Properties.Resources._41312;
            this.obstacleMiddle.Location = new System.Drawing.Point(1388, 393);
            this.obstacleMiddle.Name = "obstacleMiddle";
            this.obstacleMiddle.Size = new System.Drawing.Size(29, 127);
            this.obstacleMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacleMiddle.TabIndex = 5;
            this.obstacleMiddle.TabStop = false;
            this.obstacleMiddle.Tag = "obstacle";
            // 
            // obstacleBottom
            // 
            this.obstacleBottom.BackColor = System.Drawing.Color.Transparent;
            this.obstacleBottom.Image = global::Final_Project___Hans_Legaspi.Properties.Resources._41312;
            this.obstacleBottom.Location = new System.Drawing.Point(957, 706);
            this.obstacleBottom.Name = "obstacleBottom";
            this.obstacleBottom.Size = new System.Drawing.Size(29, 127);
            this.obstacleBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacleBottom.TabIndex = 6;
            this.obstacleBottom.TabStop = false;
            this.obstacleBottom.Tag = "obstacle";
            // 
            // obstacleTop
            // 
            this.obstacleTop.BackColor = System.Drawing.Color.Transparent;
            this.obstacleTop.Image = global::Final_Project___Hans_Legaspi.Properties.Resources._41312;
            this.obstacleTop.Location = new System.Drawing.Point(250, 132);
            this.obstacleTop.Name = "obstacleTop";
            this.obstacleTop.Size = new System.Drawing.Size(29, 127);
            this.obstacleTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacleTop.TabIndex = 7;
            this.obstacleTop.TabStop = false;
            this.obstacleTop.Tag = "obstacle";
            // 
            // player1Score
            // 
            this.player1Score.AutoSize = true;
            this.player1Score.BackColor = System.Drawing.Color.Transparent;
            this.player1Score.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Score.ForeColor = System.Drawing.SystemColors.Control;
            this.player1Score.Location = new System.Drawing.Point(26, 29);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(198, 40);
            this.player1Score.TabIndex = 8;
            this.player1Score.Text = "Player 1 : 0";
            this.player1Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player2Score
            // 
            this.player2Score.AutoSize = true;
            this.player2Score.BackColor = System.Drawing.Color.Transparent;
            this.player2Score.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Score.ForeColor = System.Drawing.SystemColors.Control;
            this.player2Score.Location = new System.Drawing.Point(920, 29);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(200, 40);
            this.player2Score.TabIndex = 9;
            this.player2Score.Text = "Player 2 : 0";
            this.player2Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.Image = global::Final_Project___Hans_Legaspi.Properties.Resources._123asd;
            this.player1.Location = new System.Drawing.Point(523, 251);
            this.player1.MaximumSize = new System.Drawing.Size(65, 61);
            this.player1.MinimumSize = new System.Drawing.Size(65, 61);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(65, 61);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1.TabIndex = 10;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Transparent;
            this.player2.Image = global::Final_Project___Hans_Legaspi.Properties.Resources._1234;
            this.player2.Location = new System.Drawing.Point(525, 631);
            this.player2.MaximumSize = new System.Drawing.Size(63, 85);
            this.player2.MinimumSize = new System.Drawing.Size(63, 85);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(63, 85);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2.TabIndex = 11;
            this.player2.TabStop = false;
            // 
            // gameTimerEvent
            // 
            this.gameTimerEvent.Enabled = true;
            this.gameTimerEvent.Interval = 25;
            this.gameTimerEvent.Tick += new System.EventHandler(this.gameTimerEvent_Tick);
            // 
            // gameOverText
            // 
            this.gameOverText.AutoSize = true;
            this.gameOverText.BackColor = System.Drawing.Color.Transparent;
            this.gameOverText.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverText.ForeColor = System.Drawing.SystemColors.Control;
            this.gameOverText.Location = new System.Drawing.Point(45, 431);
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.Size = new System.Drawing.Size(0, 68);
            this.gameOverText.TabIndex = 12;
            this.gameOverText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project___Hans_Legaspi.Properties.Resources.desktop_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1815, 896);
            this.Controls.Add(this.gameOverText);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.obstacleTop);
            this.Controls.Add(this.obstacleBottom);
            this.Controls.Add(this.obstacleMiddle);
            this.Controls.Add(this.platformTop);
            this.Controls.Add(this.platformBottom);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1837, 952);
            this.MinimumSize = new System.Drawing.Size(1837, 952);
            this.Name = "Form3";
            this.Text = "Space Run (2 Player)";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ControlPressed);
            ((System.ComponentModel.ISupportInitialize)(this.platformBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox platformBottom;
        private System.Windows.Forms.PictureBox platformTop;
        private System.Windows.Forms.PictureBox obstacleMiddle;
        private System.Windows.Forms.PictureBox obstacleBottom;
        private System.Windows.Forms.PictureBox obstacleTop;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Label player2Score;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Timer gameTimerEvent;
        private System.Windows.Forms.Label gameOverText;
    }
}