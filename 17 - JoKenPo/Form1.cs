using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17___JoKenPo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void StartGame(int option)
        {
            labelResult.Visible = false;
            Game game = new Game();

            switch (game.Play(option))
            {
                case Game.Result.Win:
                    picResult.BackgroundImage = Image.FromFile("images/Win.png");
                    labelResult.Text = "You won!";
                    goto default;
                case Game.Result.Lose:
                    picResult.BackgroundImage = Image.FromFile("images/Lose.png");
                    labelResult.Text = "You lose!";
                    goto default;
                case Game.Result.Draw:
                    picResult.BackgroundImage = Image.FromFile("images/Draw.png");
                    labelResult.Text = "Draw!";
                    goto default;
                default:
                    pictureBox1.Image = game.ImgPlayer;
                    pictureBox2.Image = game.ImgPC;
                    break;
            }
        }
    }
}
