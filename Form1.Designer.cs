
namespace Final_Project___Hans_Legaspi
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
            this.label1 = new System.Windows.Forms.Label();
            this.play1Player = new System.Windows.Forms.Button();
            this.play2Player = new System.Windows.Forms.Button();
            this.playHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "- - Space Run - -";
            // 
            // play1Player
            // 
            this.play1Player.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play1Player.Location = new System.Drawing.Point(302, 174);
            this.play1Player.Name = "play1Player";
            this.play1Player.Size = new System.Drawing.Size(193, 47);
            this.play1Player.TabIndex = 1;
            this.play1Player.Text = "1 Player";
            this.play1Player.UseVisualStyleBackColor = true;
            this.play1Player.Click += new System.EventHandler(this.play1Player_Click);
            // 
            // play2Player
            // 
            this.play2Player.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play2Player.Location = new System.Drawing.Point(302, 241);
            this.play2Player.Name = "play2Player";
            this.play2Player.Size = new System.Drawing.Size(193, 47);
            this.play2Player.TabIndex = 2;
            this.play2Player.Text = "2 Player";
            this.play2Player.UseVisualStyleBackColor = true;
            this.play2Player.Click += new System.EventHandler(this.play2Player_Click);
            // 
            // playHelp
            // 
            this.playHelp.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playHelp.Location = new System.Drawing.Point(302, 308);
            this.playHelp.Name = "playHelp";
            this.playHelp.Size = new System.Drawing.Size(193, 47);
            this.playHelp.TabIndex = 3;
            this.playHelp.Text = "Help";
            this.playHelp.UseVisualStyleBackColor = true;
            this.playHelp.Click += new System.EventHandler(this.playHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project___Hans_Legaspi.Properties.Resources.desktop_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playHelp);
            this.Controls.Add(this.play2Player);
            this.Controls.Add(this.play1Player);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(822, 506);
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "Form1";
            this.Text = "Space Run";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button play1Player;
        private System.Windows.Forms.Button play2Player;
        private System.Windows.Forms.Button playHelp;
    }
}

