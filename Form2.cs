using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project___Hans_Legaspi
{
    public partial class Form2 : Form
    {
        //global variables
        int gravityCtr;
        int gravity;
        bool gravityInvert = false;
        int gameHighScore = 0;
        int gameScore = 0;
        bool gameIsOver = false;
        int speed = 10;
        int originalPlayerTop;
        int originalPlayerLeft;
        int originalObstacleTTop;
        int originalObstacleTLeft;
        int originalObstacleBTop;
        int originalObstacleBLeft;
        int originalObstacleMTop;
        int originalObstacleMLeft;
        Random rnd = new Random();
        public Form2()
        {
            InitializeComponent();
            //set the player and obstacles original location
            originalPlayerTop = player.Top;
            originalPlayerLeft = player.Left;
            originalObstacleTTop = obstacleTop.Top;
            originalObstacleTLeft = obstacleTop.Left;
            originalObstacleBTop = obstacleBottom.Top;
            originalObstacleBLeft = obstacleBottom.Left;
            originalObstacleMTop = obstacleMiddle.Top;
            originalObstacleMLeft = obstacleMiddle.Left;
            StartGame();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            gameScore += speed / 10;
            score.Text = "Score : " + gameScore;
            player.Top += gravity;

            //if the player character lands on the platform
            if(player.Bounds.IntersectsWith(platformTop.Bounds))
            {
                gravity = 0;
            }
            else if(player.Bounds.IntersectsWith(platformBottom.Bounds))
            {
                gravity = 0;
            }
            //allows movement for the obstacle
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= speed;
                    if(x.Left < -30)
                    {
                        //set the obstacles in random location
                        x.Left = rnd.Next(1737, 1800);
                    }
                }
                // Check if player hits the left side of the obstacle
                if (player.Bounds.IntersectsWith(x.Bounds) && player.Left < x.Left)
                {
                    player.Left -= speed;
                }
            }
            //as the game progresses, the speed and gravity also increases
            if(gameScore % 1000 == 0)
            {
                speed++;
                gravityCtr++;
            }
            //if the player became out of bounds due to the collision with the obstacle, the game will end
            if(player.Left < -20)
            {
                gameTimer.Stop();
                score.Text = "GAME OVER : Please press ENTER to Restart the game.";
                gameIsOver = true;

                if(gameScore > gameHighScore)
                {
                    gameHighScore = gameScore;
                    highscore.Text = "Highscore : " + gameHighScore;
                }
            }
        }

        private void ControlPressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                //to make sure that the player character must be at the platform in order for the player to press the control again.
                if(!gravityInvert && gravity == 0)
                {
                    //switch the gravity
                    gravity = gravityCtr*-1;
                    //rotate the image
                    player.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    gravityInvert = true;
                }
                else if(gravityInvert && gravity == 0)
                {
                    //switch the gravity
                    gravity = gravityCtr;
                    //rotate the image
                    player.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    gravityInvert = false;
                }
            }
            //if the game is already over, the player can choose to play again by pressing the enter key
            if(e.KeyCode == Keys.Enter && gameIsOver)
            {
                gameIsOver = false;
                StartGame();
            }
        }
        private void StartGame()
        {
            //setting the starting variables
            gravityCtr = 10;
            gameScore = 0;
            gravity = gravityCtr;
            speed = 10;
            gravityInvert = false;
            //if the game is restarted, the character image must be return to it's starting image.
            player.Image = Properties.Resources._123;

            //to make sure that if the game is restarted, the player and obsacle will return to their original position
            player.Top = originalPlayerTop;
            player.Left = originalPlayerLeft;
            obstacleTop.Top = originalObstacleTTop;
            obstacleTop.Left = originalObstacleTLeft;
            obstacleBottom.Top = originalObstacleBTop;
            obstacleBottom.Left = originalObstacleBLeft;
            obstacleMiddle.Top = originalObstacleMTop;
            obstacleMiddle.Left = originalObstacleMLeft;
            //start the game timer
            gameTimer.Start();
        }
    }
}
