using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird_Game
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 3;
        int gravity = 15;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e) 
        {
            flappyBird.Top += gravity;
            pipeUp.Left -= pipeSpeed;
            pipeDown.Left -= pipeSpeed;
            scoreText.Text = "Score" + score;

            if(pipeDown.Left < -65 )
            {
                pipeDown.Left = 900;
                score++;
            }
            if(pipeUp.Left < -80)
            {
                pipeUp.Left = 950;
                score++;
            }
            if (flappyBird.Bounds.IntersectsWith(pipeDown.Bounds) || flappyBird.Bounds.IntersectsWith(pipeUp.Bounds)
               || flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25
                )
            {
                endGame();
            }
            if(score > 5)
            {
                pipeSpeed = 15;
            }
           
        }      

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
            if (e.KeyCode == Keys.Enter)
            {
                gameTimer.Start();
            }

        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "Game Over";
        }


        private void restart()
        {
            gameTimer.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pipeTop(object sender, EventArgs e) 
        {

        }
    }
}
