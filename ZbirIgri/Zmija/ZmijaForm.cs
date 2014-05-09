using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace ZbirIgri
{
    public partial class ZmijaForm : Form
    {
        Graphics g;
        SnakeGame game;
        float prevX;
        float prevY;
        int time = 0, prevTime = -1;
        bool flag = true;
        Timer timer;
        public int Maxpoeni;
        public Igrach player;
        public string ime;
        public ZmijaForm(string ime)
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick+=new EventHandler(timer_Tick);
            Maxpoeni = 0;
            this.ime = ime;
            g = pictureBox1.CreateGraphics();
            game = new SnakeGame(g);
            prevX = game.snake.snake[0].X;
            prevY = game.snake.snake[0].Y;
            timer.Start();
            timer.Interval = 5000/ game.Speed;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            game.food.Draw(g);
            System.Media.SoundPlayer pl = new System.Media.SoundPlayer();
            if ((game.snake.snake[0].X == game.food.X && game.snake.snake[0].Y == game.food.Y))
            {
                pl.Stream = ZbirIgri.Properties.Resources.bite;
                pl.Play();

                game.snake.addCircle();
                game.NovaKrofna(g);
                game.Poeni++;
                flag = true;
            }
            if (prevTime == time)
                pl.Stop();
            Brush b;
            if (game.dir == SnakeGame.Direction.Right)
            {
                g.FillEllipse(Brushes.Black, game.snake.snake[0].X + 20, game.snake.snake[0].Y, 20, 20);
                prevX = game.snake.snake[0].X;
                prevY = game.snake.snake[0].Y;
                game.snake.snake[0].X += 20;
            }
            else if (game.dir == SnakeGame.Direction.Down)
            {
                g.FillEllipse(Brushes.Black, game.snake.snake[0].X, game.snake.snake[0].Y + 20, 20, 20);
                prevY = game.snake.snake[0].Y;
                prevX = game.snake.snake[0].X;
                game.snake.snake[0].Y += 20;
            }
            else if (game.dir == SnakeGame.Direction.Left)
            {
                g.FillEllipse(Brushes.Black, game.snake.snake[0].X - 20, game.snake.snake[0].Y, 20, 20);
                prevY = game.snake.snake[0].Y;
                prevX = game.snake.snake[0].X;
                game.snake.snake[0].X -= 20;
            }
            else if (game.dir == SnakeGame.Direction.Up)
            {
                g.FillEllipse(Brushes.Black, game.snake.snake[0].X, game.snake.snake[0].Y - 20, 20, 20);
                prevY = game.snake.snake[0].Y;
                prevX = game.snake.snake[0].X;
                game.snake.snake[0].Y -= 20;
            }
            for (int i = 1; i < game.snake.snake.Count; i++)
            {

                b = Brushes.Red;
                g.FillEllipse(b, prevX, prevY, 20, 20);
                float tempx = prevX, tempy = prevY;
                prevX = game.snake.snake[i].X;
                prevY = game.snake.snake[i].Y;
                game.snake.snake[i].X = tempx;
                game.snake.snake[i].Y = tempy;

            }




        }

        private void timer_Tick(object sender, EventArgs e)
        {
            prevTime = time;
            time++;
            pictureBox1.Invalidate(true);
            if (game.snake.snake.Count == 400)
                Pobedi();
            else
            if (GameOver())
            {
                if (game.Poeni > Maxpoeni)
                    Maxpoeni = game.Poeni;
                player = new Igrach(ime,Maxpoeni);
                timer.Stop();
                DialogResult r = MessageBox.Show("Заврши играта. Дали сакате нова игра?", "Нова игра", MessageBoxButtons.YesNo);
                if (r == System.Windows.Forms.DialogResult.Yes)
                    NewGame();
            }
            lblPoeni.Text = game.Poeni.ToString();

            if (flag == true && game.Poeni != 0 && game.Poeni % 10 == 0 && timer.Interval >= 50)
            {
                flag = false;
                timer.Interval = timer.Interval - game.Speed;
            }
        }
        public void NewGame()
        {
            if (game.Poeni > Maxpoeni)
                Maxpoeni = game.Poeni;
            game = new SnakeGame(g);
            timer.Interval = 5000 / game.Speed;
            flag = true;
            timer.Start();
        }
        public bool GameOver()
        {
            if (game.snake.snake[0].X >= pictureBox1.Width - 15 || game.snake.snake[0].Y >= pictureBox1.Height - 15 || game.snake.snake[0].X < 0 || game.snake.snake[0].Y < 0)
            {
                return true;
            }
            for (int i = 1; i < game.snake.snake.Count; i++)
            {
                if (game.snake.snake[0].X == game.snake.snake[i].X && game.snake.snake[0].Y == game.snake.snake[i].Y)
                    return true;
            }
            return false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            if (prevTime != time)
                game.setDir(key);
            prevTime++;
        }

       

       
        private void nova_Click(object sender, EventArgs e)
        {
            timer.Stop();
            DialogResult r = MessageBox.Show("Дали сакате нова игра?", "Нова игра", MessageBoxButtons.YesNo);
            if (r == System.Windows.Forms.DialogResult.Yes)
                NewGame();
            else
                timer.Start();
            
        }

        private void zatvori_Click(object sender, EventArgs e)
        {
            timer.Stop();
            DialogResult r = MessageBox.Show("Дали сакате да го затворите прозорецот?", "Затвори", MessageBoxButtons.YesNo);
            if (r == System.Windows.Forms.DialogResult.Yes)
                Close();
            else
                timer.Start();
        }

        private void nova_MouseEnter(object sender, EventArgs e)
        {
           
            String s = ((Label)sender).Name;
          
            if (s == "nova")
                nova.Image = ZbirIgri.Properties.Resources.gr_butt;
            else
                zatvori.Image = ZbirIgri.Properties.Resources.gr_butt;

        }

        private void nova_MouseLeave(object sender, EventArgs e)
        {
            String s = ((Label)sender).Name;

            if (s == "nova")
                nova.Image = ZbirIgri.Properties.Resources.bl_butt;
            else
                zatvori.Image = ZbirIgri.Properties.Resources.bl_butt;
            
        }

        private void zatvori_MouseDown(object sender, MouseEventArgs e)
        {
            String s = ((Label)sender).Name;

            if (s == "nova")
                nova.Image = ZbirIgri.Properties.Resources.pn_butt;
            else
                zatvori.Image = ZbirIgri.Properties.Resources.pn_butt;
        }

        private void zatvori_MouseUp(object sender, MouseEventArgs e)
        {
            String s = ((Label)sender).Name;

            if (s == "nova")
                nova.Image = ZbirIgri.Properties.Resources.bl_butt;
            else
                zatvori.Image = ZbirIgri.Properties.Resources.bl_butt;

        }



        public void Pobedi() {

            if (game.Poeni > Maxpoeni)
                Maxpoeni = game.Poeni;
            player = new Igrach(ime, Maxpoeni);
            timer.Stop();
            DialogResult r = MessageBox.Show("Победивте!!! Дали сакате нова игра?", "Победа", MessageBoxButtons.YesNo);
            if (r == System.Windows.Forms.DialogResult.Yes)
                NewGame();
        }

       
       

    }
}
