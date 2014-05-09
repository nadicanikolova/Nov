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
        Random rand_X;
        Random rand_Y;
        int pozX;
        int pozY;
        public SnakeGame(Graphics g) {
            snake = new Zmija();
            dir = Direction.Right;
            snake.addCircle();
            snake.addCircle();
            snake.addCircle();
            rand_X = new Random();
            rand_Y = new Random();
            pozX =(rand_X.Next(0,((int)g.DpiX-20)%20+1)*20);
            pozY = (rand_Y.Next(0,((int)g.DpiY-20)%20+1)*20);
            food = new Krofna(pozX,pozY);
            Speed = 25;
            Poeni = 0;

        }
        public void NovaKrofna(Graphics g)
        {
            rand_X = new Random();
            rand_Y = new Random();
            if ((((int)g.DpiX - 20) % 20 + 1) * 20 == 400)
            pozX = (rand_X.Next(0, 380));
            else
            pozX = (rand_X.Next(0, ((int)g.DpiX - 20) % 20 + 1) * 20);
            if ((((int)g.DpiY - 20) % 20 + 1) * 20==400)
            pozY = (rand_Y.Next(0, 380));
            pozY = (rand_Y.Next(0, ((int)g.DpiY - 20) % 20 + 1) * 20);
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
