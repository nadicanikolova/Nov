using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace ZbirIgri
{
    public class SnakeGame
    {
        public enum Direction { 
        Up,
        Down,
        Left,
        Right
        }
        public Zmija snake;
        public Krofna food;
        public int Speed { get; set; }
        public int Poeni { get; set; }
        public Direction dir;
        Random rand;
        int pozX;
        int pozY;
        public SnakeGame() {
            snake = new Zmija();
            dir = Direction.Right;
            snake.addCircle();
            snake.addCircle();
            snake.addCircle();
            rand = new Random();
            pozX = rand.Next(0,19)*20;
            pozY = rand.Next(0, 19) * 20;
            food = new Krofna(pozX,pozY);
            Speed = 25;
            Poeni = 0;

        }
        public void NovaKrofna()
        {
            pozX = rand.Next(0, 19) * 20;
            pozY = rand.Next(0, 19) * 20;
            food = new Krofna(pozX, pozY);
        }
        public void setDir(Keys key) {
            if (key == Keys.Up && dir != Direction.Down)
            {
                dir = Direction.Up;
            }
            else if (key == Keys.Down && dir != Direction.Up)
            {
                dir = Direction.Down;
            }
            else if (key == Keys.Left && dir != Direction.Right)
            {
                dir = Direction.Left;
            }
            else if (key == Keys.Right && dir != Direction.Left)
            {
                dir = Direction.Right;
            }
        }

    }
}
