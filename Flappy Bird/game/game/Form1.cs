using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {

        int gravity = 15;
        int pipeSpeed = 8;
        int gameScore = 0;
        int lifeCount = 3;
        int lifeFreeTime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void gametimetickevent(object sender, EventArgs e)
        {
            birdFadingEffect();
            lifeFreeTime += 20;
            bird.Top = bird.Top + gravity;
            pipe_bottem.Left -= pipeSpeed;
            pipe_top.Left -= pipeSpeed;
            exLife.Left -= pipeSpeed;

            if (pipe_bottem.Left < -150)
            {
                pipe_bottem.Left = 750;
                gameScore++;
            }
            if (pipe_top.Left < -80)
            {
                pipe_top.Left = 950;
                gameScore++;

            }
            if (bird.Bounds.IntersectsWith(pipe_top.Bounds) || bird.Bounds.IntersectsWith(pipe_bottem.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            if (bird.Bounds.IntersectsWith(exLife.Bounds) && lifeCount < 3)
            {
                exLifeFunction();
                

            }
            if(exLife.Left < -10)
            {
                exLife.Left = 10000;
            }
            if(lifeCount == 1)
            {
                life1.Visible = true; 
            }
            if (lifeCount == 2)
            {
                life2.Visible = true;
            }
            if (lifeCount == 3)
            {
                life3.Visible = true;
            }
            score_lbl.Text = "Score : " + gameScore;
        }

        private void keyUpEvent(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }

        }

        private void keyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void endGame()
        {
            if (lifeCount == 0 && lifeFreeTime > 3000)
            {
                game_time.Stop();
                gameOverLable.Text = "Game Over!!!\nYour score is :" + gameScore;
                gameOverLable.Visible = true;
            }
            else
            {
                switch (lifeCount)
                {
                    case 3:
                        if (lifeFreeTime > 2500)
                        {
                            life3.Visible = false;
                            lifeCount--;
                            lifeFreeTime = 0;
                        }

                        break;
                    case 2:
                        if (lifeFreeTime > 2500)
                        {
                            life2.Visible = false;
                            lifeCount--;
                            lifeFreeTime = 0;
                        }

                        break;
                    case 1:
                        if (lifeFreeTime > 2500)
                        {
                            life1.Visible = false;
                            lifeCount--;
                            lifeFreeTime = 0;
                        }

                        break;
                }


            }
        }
        private void birdFadingEffect()
        {
            if (bird.Visible == true & lifeFreeTime < 2500)
            {
                bird.Visible = false;
            }
            else if (bird.Visible == false & lifeFreeTime < 2500)
            {
                bird.Visible = true;
            }
            else
            {
                bird.Visible = true;
            }
        }
        private void exLifeFunction()
        {
            if(lifeCount < 3)
            {
                lifeCount++;
                exLife.Left = 15000; 
            }
            
        }

        private void exLife_Click(object sender, EventArgs e)
        {

        }

        private void pipe_top_Click(object sender, EventArgs e)
        {

        }
    }
}
