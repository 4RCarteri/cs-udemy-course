using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___JoKenPo
{
    internal class Game
    {
        public enum Result
        {
            Win,
            Lose,
            Draw
        }

        public static Image[] images =
        {
            Image.FromFile("images/Rock.png"),
            Image.FromFile("images/Paper.png"),
            Image.FromFile("images/Scissors.png")
        };

        public Image ImgPC { get; private set; }
        public Image ImgPlayer { get; private set; }

        public Result Play(int player)
        {
            int pc = PCPlay();

            ImgPC = images[pc];
            ImgPlayer = images[player];

            if (player == pc)
            {
                return Result.Draw;
            }
            else if ((player == 0 && pc == 2) || (player == 1 && pc == 0) || (player == 2 && pc == 1))
            {
                return Result.Win;
            }
            else
            {
                return Result.Lose;
            }
        }

        private int PCPlay()
        {
            //Random rnd = new Random();
            //return rnd.Next(0, 3);

            int mil = DateTime.Now.Millisecond;

            switch (mil)
            {
                case int n when (n < 333):
                    return 0;
                case int n when (n < 666):
                    return 1;
                default:
                    return 2;
            }
        }
    }
}
