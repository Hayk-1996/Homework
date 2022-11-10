using System;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, goUp, goDown;
        int speed = 7;
        public Form1()
        {
            InitializeComponent();
        }
        private void mainGame(object sender, EventArgs e)
        {
            if (goLeft == true && pacMen.Left > 0)
            {
                pacMen.Left -= speed;
            }

            if (goRight == true && pacMen.Right < 735)
            {
                pacMen.Left += speed;
            }

            if (goUp == true && pacMen.Top > 0)
            {
                pacMen.Top -= speed;
            }
            if (goDown == true && pacMen.Bottom < 355)
            {
                pacMen.Top += speed;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }
    }
}
