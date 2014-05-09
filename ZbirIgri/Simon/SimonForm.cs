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
using System.Media;

namespace ZbirIgri
{
    public partial class SimonForm : Form
    {
        SimonGame g;
        int i, flag = 0, momentalnaPozicija = 0, countPoeni,maxpoeni;
        string ime;
        public Igrach player;

        public SimonForm(string Ime)
        {

            InitializeComponent();
            g = new SimonGame();
            ime = Ime;
            countPoeni = 0;
            g.addNiza();
            maxpoeni = 0;
            i = 0;
            button1.Tag = "pocetno";
            button2.Tag = "pocetno";
            button3.Tag = "pocetno";
            button4.Tag = "pocetno";
            timer1.Start();

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (!button1.Tag.Equals("web"))
            {
                button1.Tag = "enter";
                button1.Image = ZbirIgri.Properties.Resources.red3;
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            SoundPlayer pl = new SoundPlayer(ZbirIgri.Properties.Resources.Speech_On);
            pl.Play();
            button1.Tag = "down";
            button1.Image = ZbirIgri.Properties.Resources.red2;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Tag = "leave";
            button1.Image = ZbirIgri.Properties.Resources.red;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Tag = "up";
            button1.Image = ZbirIgri.Properties.Resources.red;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            if (!button2.Tag.Equals("web"))
            {
                button2.Tag = "enter";
                button2.Image = ZbirIgri.Properties.Resources.blue2;
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            SoundPlayer pl = new SoundPlayer(ZbirIgri.Properties.Resources.Speech_On);
            pl.Play();
            button2.Tag = "down";
            button2.Image = ZbirIgri.Properties.Resources.blue1;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Tag = "leave";
            button2.Image = ZbirIgri.Properties.Resources.blue;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Tag = "up";
            button2.Image = ZbirIgri.Properties.Resources.blue2;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            if (!button3.Tag.Equals("web"))
            {
                button3.Tag = "enter";

                button3.Image = ZbirIgri.Properties.Resources.green2;
            }
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.Tag = "down";
            SoundPlayer pl = new SoundPlayer(ZbirIgri.Properties.Resources.Speech_On);
            pl.Play();
            button3.Image = ZbirIgri.Properties.Resources.green1;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Tag = "leave";
            button3.Image = ZbirIgri.Properties.Resources.green;
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            button3.Tag = "up";
            button3.Image = ZbirIgri.Properties.Resources.green;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            if (!button4.Tag.Equals("web"))
            {
                button4.Tag = "enter";
                button4.Image = ZbirIgri.Properties.Resources.yellow2;
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            SoundPlayer pl = new SoundPlayer(ZbirIgri.Properties.Resources.Speech_On);
            pl.Play();
            button4.Tag = "down";
            button4.Image = ZbirIgri.Properties.Resources.yellow1;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Tag = "leave";
            button4.Image = ZbirIgri.Properties.Resources.yellow;
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            button4.Tag = "up";
            button4.Image = ZbirIgri.Properties.Resources.yellow;
        }

        public void vratiKopce()
        {
            button1.Tag = "pocetno";
            button2.Tag = "pocetno";
            button3.Tag = "pocetno";
            button4.Tag = "pocetno";
            button1.Image = ZbirIgri.Properties.Resources.red;
            button2.Image = ZbirIgri.Properties.Resources.blue;
            button3.Image = ZbirIgri.Properties.Resources.green;
            button4.Image = ZbirIgri.Properties.Resources.yellow;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (g.Niza[momentalnaPozicija] != null && g.Niza[momentalnaPozicija].Equals("red"))
            {
                if (momentalnaPozicija == g.momIndeks - 1)
                {
                    countPoeni++;
                    g.addNiza();
                    i = 0;
                    timer1.Start();
                    momentalnaPozicija = 0;
                }
                else
                    momentalnaPozicija++;
            }
            else zgresenaNiza();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (g.Niza[momentalnaPozicija] != null && g.Niza[momentalnaPozicija].Equals("blue"))
            {
                if (momentalnaPozicija == g.momIndeks - 1)
                {
                    countPoeni++;
                    g.addNiza();
                    i = 0;
                    timer1.Start();
                    momentalnaPozicija = 0;
                }
                else
                    momentalnaPozicija++;
            }
            else zgresenaNiza();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (g.Niza[momentalnaPozicija] != null && g.Niza[momentalnaPozicija].Equals("green"))
            {
                if (momentalnaPozicija == g.momIndeks - 1)
                {
                    countPoeni++;
                    g.addNiza();
                    i = 0;
                    timer1.Start();
                    momentalnaPozicija = 0;
                }
                else
                    momentalnaPozicija++;
            }
            else zgresenaNiza();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (g.Niza[momentalnaPozicija] != null && g.Niza[momentalnaPozicija].Equals("yellow"))
            {
                if (momentalnaPozicija == g.momIndeks - 1)
                {
                    countPoeni++;
                    g.addNiza();
                    i = 0;
                    timer1.Start();
                    momentalnaPozicija = 0;
                }
                else
                    momentalnaPozicija++;
            }
            else zgresenaNiza();
        }

        public void zgresenaNiza()
        {
            timer1.Stop();

            if (countPoeni > maxpoeni)
            {
                maxpoeni = countPoeni;
                player = new Igrach(ime, maxpoeni);
            }
            lblMax.Text = maxpoeni.ToString();
            momentalnaPozicija = 0;
            countPoeni = 0;
            DialogResult r = MessageBox.Show("Згрешивте. Дали сакате нова игра?", "Грешка", MessageBoxButtons.YesNo);
            if (r == System.Windows.Forms.DialogResult.Yes)
            {
                g = new SimonGame();
                g.addNiza();
                i = 0;
                timer1.Start();
            }
        }

        public void pobedena()
        {
            timer1.Stop();

            if (countPoeni > maxpoeni)
                maxpoeni = countPoeni;
            lblMax.Text = maxpoeni.ToString();
            player = new Igrach(ime,maxpoeni);
            countPoeni = 0;
            momentalnaPozicija = 0;
            DialogResult r = MessageBox.Show("Победивте! Дали сакате нова игра?", "Победа", MessageBoxButtons.YesNo);
            if (r == System.Windows.Forms.DialogResult.Yes)
            {

                g = new SimonGame();
                g.addNiza();
                i = 0;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (flag == 0)
            {
                flag = 1;
                if (g.Niza[i] == null)
                {
                    flag = 0;
                    vratiKopce();
                    i = 0;
                    timer1.Stop();

                }
                else
                {
                    if (g.Niza[i].Equals("red"))
                    {
                        button1.Tag = "web";
                        button1.Image = ZbirIgri.Properties.Resources.red_glow;

                    }
                    else
                        if (g.Niza[i].Equals("blue"))
                        {
                            button2.Tag = "web";
                            button2.Image = ZbirIgri.Properties.Resources.blue_glow;

                        }
                        else
                            if (g.Niza[i].Equals("green"))
                            {
                                button3.Tag = "web";
                                button3.Image = ZbirIgri.Properties.Resources.green_glow;

                            }
                            else
                                if (g.Niza[i].Equals("yellow"))
                                {
                                    button3.Tag = "web";
                                    button4.Image = ZbirIgri.Properties.Resources.yellow_glow;

                                }

                    i++;
                }
                if (i == g.Niza.Length)
                {
                    flag = 0;
                    vratiKopce();
                    pobedena();
                    timer1.Stop();
                }

            }
            else
            {
                flag = 0;
                vratiKopce();
            }
        }

        private void nova_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult r = MessageBox.Show("Дали сакате нова игра?", "Победа", MessageBoxButtons.YesNo);
            if (r == System.Windows.Forms.DialogResult.Yes)
            {
                g = new SimonGame();
                g.addNiza();
                i = 0;
                timer1.Start();
            }
            else timer1.Start();
        }

        private void zatvori_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult r = MessageBox.Show("Дали сакате да го затворите прозорецот?", "Затвори", MessageBoxButtons.YesNo);
            if (r == System.Windows.Forms.DialogResult.Yes)
                Close();
            else
                timer1.Start();
        }

        




    }
}
