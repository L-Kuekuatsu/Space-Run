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
    public partial class Form3 : Form
    {
        //global variables
        int gravityCtr;
        int gravity1;
        int gravity2;
        bool player1GravityInvert = false;
        bool player2GravityInvert = false;
        int scorePlayer1 = 0;
        int scorePlayer2 = 0;
        bool gameIsOver = false;
        int speed = 10;
        int speedCtr;
        int originalPlayer1Top;
        int originalPlayer1Left;
        int originalPlayer2Top;
        int originalPlayer2Left;
        int originalObstacleTTop;
        int originalObstacleTLeft;
        int originalObstacleBTop;
        int originalObstacleBLeft;
        int originalObstacleMTop;
        int originalObstacleMLeft;
        Random rnd = new Random();

        public Form3()
        {
            InitializeComponent();
            //set the player and obstacles original location
            originalPlayer1Top = player1.Top;
            originalPlayer1Left = player1.Left;
            originalPlayer2Top = player2.Top;
            originalPlayer2Left = player2.Left;
            originalObstacleTTop = obstacleTop.Top;
            originalObstacleTLeft = obstacleTop.Left;
            originalObstacleBTop = obstacleBottom.Top;
            originalObstacleBLeft = obstacleBottom.Left;
            originalObstacleMTop = obstacleMiddle.Top;
            originalObstacleMLeft = obstacleMiddle.Left;
            StartGame();
        }

        private void gameTimerEvent_Tick(object sender, EventArgs e)
        {
            player1.Top += gravity1;
            player2.Top += gravity2;
            speedCtr += speed / 10;
            //if the player character lands on the platform
            if (player1.Bounds.IntersectsWith(platformTop.Bounds))
            {
                gravity1 = 0;
            }
            else if (player1.Bounds.IntersectsWith(platformBottom.Bounds))
            {
                gravity1 = 0;
            }
            if (player2.Bounds.IntersectsWith(platformTop.Bounds))
            {
                gravity2 = 0;
            }
            else if (player2.Bounds.IntersectsWith(platformBottom.Bounds))
            {
                gravity2 = 0;
            }
            //allows movement for the obstacle
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= speed;
                    if (x.Left < -30)
                    {
                        //set the obstacles in random location
                        x.Left = rnd.Next(1737, 1800);
                    }
                }
                // Check if player hits the left side of the obstacle
                if (player1.Bounds.IntersectsWith(x.Bounds) && player1.Left < x.Left)
                {
                    player1.Left -= speed;
                }
                if (player2.Bounds.IntersectsWith(x.Bounds) && player2.Left < x.Left)
                {
                    player2.Left -= speed;
                }
                //as the game progresses, the speed also increases
                if (speedCtr % 1000 == 0)
                {
                    speed++;
                }
                //if the player became out of bounds due to the collision with the obstacle, then the player who didn't go out of bounds will win a score and the game will end
                if (player1.Left < -20)
                {
                    gameTimerEvent.Stop();
                    gameOverText.Text = "GAME OVER : Please press ENTER to Restart the game.";
                    gameIsOver = true;
                    scorePlayer2 += 1;
                    player2Score.Text = "Player 2 : " + scorePlayer2/4;
                }else if (player2.Left < -20)
                {
                    gameTimerEvent.Stop();
                    gameOverText.Text = "GAME OVER : Please press ENTER to Restart the game.";
                    gameIsOver = true;
                    scorePlayer1 += 1;
                    player1Score.Text = "Player 1 : " + scorePlayer1/4;
                }
            }
        }

        private void ControlPressed(object sender, KeyEventArgs e)
        {
            //Player 1 Control
            if (e.KeyCode == Keys.Space)
            {
                //to make sure that the player character must be at the platform in order for the player to press the control again.
                if (!player1GravityInvert && gravity1 == 0)
                {
                    //switch the gravity
                    gravity1 = gravityCtr;
                    //rotate the image
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player1GravityInvert = true;
                }
                else if (player1GravityInvert && gravity1 == 0)
                {
                    //switch the gravity
                    gravity1 = gravityCtr*-1;
                    //rotate the image
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player1GravityInvert = false;
                }
            }
            //Player 2 Control
            if (e.KeyCode == Keys.W)
            {
                //to make sure that the player character must be at the platform in order for the player to press the control again.
                if (!player2GravityInvert && gravity2 == 0)
                {
                    //switch the gravity
                    gravity2 = gravityCtr*-1;
                    //rotate the image
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player2GravityInvert = true;
                }
                else if (player2GravityInvert && gravity2 == 0)
                {
                    //switch the gravity
                    gravity2 = gravityCtr;
                    //rotate the image
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player2GravityInvert = false;
                }
            }
            //if the game is already over, the player can choose to play again by pressing the enter key
            if (e.KeyCode == Keys.Enter && gameIsOver)
            {
                gameIsOver = false;
                gameOverText.Text = "";
                StartGame();
            }
        }

        private void StartGame()
        {
            //setting the starting variables
            gravityCtr = 10;
            gravity1 = gravityCtr*-1;
            gravity2 = gravityCtr;
            speed = 10;
            speedCtr = 0;
            player1GravityInvert = false;
            player2GravityInvert = false;
            //if the game is restarted, the character image must be return to it's starting image.
            player1.Image = Properties.Resources._123asd;
            player2.Image = Properties.Resources._1234;

            //to make sure that if the game is restarted, the player and obsacle will return to their original position
            player1.Top = originalPlayer1Top;
            player1.Left = originalPlayer1Left;
            player2.Top = originalPlayer2Top;
            player2.Left = originalPlayer2Left;
            obstacleTop.Top = originalObstacleTTop;
            obstacleTop.Left = originalObstacleTLeft;
            obstacleBottom.Top = originalObstacleBTop;
            obstacleBottom.Left = originalObstacleBLeft;
            obstacleMiddle.Top = originalObstacleMTop;
            obstacleMiddle.Left = originalObstacleMLeft;
            //start the game timer
            gameTimerEvent.Start();
        }
    }
}
