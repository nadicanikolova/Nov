using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ZbirIgri
{
    public class Zmija
    {
        public List<Krug> snake;
  

        public Zmija() {
            snake = new List<Krug>();
            
        }

        public void addCircle() {
            Krug kr;
            if (snake.Count == 0)
                kr = new Krug(60, 20);
            else kr = new Krug(snake[snake.Count - 1].X - 20,20);
            snake.Add(kr);
        }
    }
}
