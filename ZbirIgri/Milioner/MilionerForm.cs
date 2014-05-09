using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZbirIgri.Milioner;

namespace ZbirIgri
{
    public partial class MilionerForm : Form
    {

        System.Media.SoundPlayer player;
        public bool pogodenoPrasanje { set; get; }
        public MilionerGame game { set; get; }
        public int brojPogodeniPrasanja { set; get; }
        public Prasanje momentalnoPrasanje { set; get; }
        public int sigurnaSuma { set; get; }

        public DodadiBazaPrasanja dp { set; get; }
        public int vreme { set; get; }
        public Igrach igrac;
        int poeni, maxPoeni;
        String ime;
        public MilionerForm(string Ime)
        {
            InitializeComponent();
            poeni = 0;
            maxPoeni = 0;
            ime = Ime;
            player = new System.Media.SoundPlayer();
            pogodenoPrasanje = false;
            brojPogodeniPrasanja = 0;
            listaSumi.SelectedIndex = listaSumi.Items.Count - 1;
            sigurnaSuma = 0;
            labelaPrasanje.Hide();
            buttonOdgovor1.Hide();
            buttonOdgovor2.Hide();
            buttonOdgovor3.Hide();
            buttonOdgovor4.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            buttonSeOtkazuva.Enabled = false;
            vreme = 0;
            button1.Enabled = false;

        }



        public void pokaziPrasanje(Prasanje prasanje)
        {
            labelaPrasanje.Text = prasanje.tekst;
            Random r = new Random();
            List<int> broevi = new List<int>();
            int brojac = 0;
            while (true)
            {
                int c = r.Next(4);
                if (!broevi.Contains(c))
                {
                    broevi.Add(c);
                    ++brojac;
                }
                if (brojac == 4)
                {
                    break;
                }

            }


            buttonOdgovor1.Text = prasanje.ponudeniOdgovori.ElementAt(broevi.ElementAt(0));
            buttonOdgovor2.Text = prasanje.ponudeniOdgovori.ElementAt(broevi.ElementAt(1));
            buttonOdgovor3.Text = prasanje.ponudeniOdgovori.ElementAt(broevi.ElementAt(2));
            buttonOdgovor4.Text = prasanje.ponudeniOdgovori.ElementAt(broevi.ElementAt(3));
        }

        private void buttonNovaIgra_Click(object sender, EventArgs e)
        {

            novaIgra();

        }
        public void novaIgra()
        {
            buttonSeOtkazuva.Enabled = true;
            DialogResult dr = MessageBox.Show("Дали сакате нова игра?", "Нова игра ", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                timer1.Stop();
                player.Stop();
                playQuestion();
                listaSumi.SelectedIndex = listaSumi.Items.Count - 1;
                labelaPrasanje.Show();
                buttonOdgovor1.Show();
                buttonOdgovor2.Show();
                buttonOdgovor3.Show();
                buttonOdgovor4.Show();
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                pogodenoPrasanje = false;
                brojPogodeniPrasanja = 0;
                game = new MilionerGame();
                dodadiPrasanja();
                game.izgenerirajPrasanja();
                int prvoPrasanje = game.broeviLesniPrasanja.ElementAt(0);
                button1.BackColor = Button.DefaultBackColor;
                button50.BackColor = Button.DefaultBackColor;
                buttonPovikajPrijatel.BackColor = Button.DefaultBackColor;
                pokaziPrasanje(game.Prasanja.ElementAt(prvoPrasanje));
                momentalnoPrasanje = game.Prasanja.ElementAt(prvoPrasanje);
                game.broeviLesniPrasanja.RemoveAt(0);
                pbSlika.BackgroundImage = ZbirIgri.Properties.Resources.thinking_hard;
                button50.Enabled = true;
                buttonPovikajPrijatel.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                Zavrsi();
            }
        }

        public void dodadiPrasanja()
        {
            dp = new DodadiBazaPrasanja(game);
        }

        public void skrijOdgovoriLabeli()
        {
            buttonOdgovor1.Hide();
            buttonOdgovor2.Hide();
            buttonOdgovor3.Hide();
            buttonOdgovor4.Hide();
            labelaPrasanje.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();

        }
        private void buttonOdgovor1_Click(object sender, EventArgs e)
        {
            if (buttonOdgovor1.Text == momentalnoPrasanje.tocenOdgovor)
            {
                player.Stop();
                playCorrect();
                pogodenoPrasanje = true;
                buttonSlednoPrasanje.Enabled = true;
                ++brojPogodeniPrasanja;
                namestiSigurnaSuma();
                pbSlika.BackgroundImage = ZbirIgri.Properties.Resources.money;
            }
            else
            {
                Zavrsi();
            }
        }

        private void buttonOdgovor3_Click(object sender, EventArgs e)
        {
            if (buttonOdgovor3.Text == momentalnoPrasanje.tocenOdgovor)
            {
                player.Stop();
                playCorrect();
                pogodenoPrasanje = true;
                buttonSlednoPrasanje.Enabled = true;
                ++brojPogodeniPrasanja;
                namestiSigurnaSuma();
                pbSlika.BackgroundImage = ZbirIgri.Properties.Resources.money;
            }
            else
            {
                Zavrsi();
            }
        }

        private void buttonOdgovor2_Click(object sender, EventArgs e)
        {
            if (buttonOdgovor2.Text == momentalnoPrasanje.tocenOdgovor)
            {
                player.Stop();
                playCorrect();
                pogodenoPrasanje = true;
                buttonSlednoPrasanje.Enabled = true;
                ++brojPogodeniPrasanja;
                namestiSigurnaSuma();
                pbSlika.BackgroundImage = ZbirIgri.Properties.Resources.money;
            }
            else
            {
                Zavrsi();
            }
        }

        private void buttonOdgovor4_Click(object sender, EventArgs e)
        {
            if (buttonOdgovor4.Text == momentalnoPrasanje.tocenOdgovor)
            {
                player.Stop();
                playCorrect();
                pogodenoPrasanje = true;
                buttonSlednoPrasanje.Enabled = true;
                ++brojPogodeniPrasanja;
                namestiSigurnaSuma();
                pbSlika.BackgroundImage = ZbirIgri.Properties.Resources.money;
            }
            else
            {
                Zavrsi();
            }
        }

        private void buttonSlednoPrasanje_Click(object sender, EventArgs e)
        {

            if (brojPogodeniPrasanja == 15)
            {
                player.Stop();
                player.Stream = ZbirIgri.Properties.Resources.Millionaire;
                player.Load();
                player.PlayLooping();
                MessageBox.Show("Честитки, вие сте новиот милионер. Освоивте 3 000 000 денари!", "Честитка", MessageBoxButtons.OK);
                
                sigurnaSuma = 3000000;
                maxPoeni = sigurnaSuma;
                novaIgra();
            }
            else
               
                
                    if (brojPogodeniPrasanja != 15)
                    {
                        player.Stop();
                        player.Stream = ZbirIgri.Properties.Resources.Question;
                        player.Load();
                        player.PlayLooping();
                        listaSumi.SelectedIndex = listaSumi.Items.Count - brojPogodeniPrasanja - 1;
                        int prvoPrasanje = 0;
                        if (brojPogodeniPrasanja < 5)
                            prvoPrasanje = game.broeviLesniPrasanja.ElementAt(0);
                        else if (brojPogodeniPrasanja >= 5 && brojPogodeniPrasanja < 10)
                        {
                            prvoPrasanje = game.broeviSredniPrasanja.ElementAt(0);
                        }
                        else if (brojPogodeniPrasanja >= 10)
                        {
                            prvoPrasanje = game.broeviTeskiPrasanja.ElementAt(0);
                        }
                      

                        pokaziPrasanje(game.Prasanja.ElementAt(prvoPrasanje));
                        momentalnoPrasanje = game.Prasanja.ElementAt(prvoPrasanje);
                        if (button50.Enabled == false)
                        {
                            buttonOdgovor1.Show();
                            buttonOdgovor2.Show();
                            buttonOdgovor3.Show();
                            buttonOdgovor4.Show();
                        }

                        if (brojPogodeniPrasanja < 5)
                            game.broeviLesniPrasanja.RemoveAt(0);
                        else if (brojPogodeniPrasanja >= 5 && brojPogodeniPrasanja < 10)
                        {
                            game.broeviSredniPrasanja.RemoveAt(0);
                        }
                        else if (brojPogodeniPrasanja >= 10)
                        {
                            game.broeviTeskiPrasanja.RemoveAt(0);
                        }
                        pbSlika.BackgroundImage = ZbirIgri.Properties.Resources.thinking_hard;
                    }
            buttonSlednoPrasanje.Enabled = false;

        }

        private void namestiSigurnaSuma()
        {
            if (brojPogodeniPrasanja == 5)
            {
                sigurnaSuma = 5000;

            }
            else if (brojPogodeniPrasanja == 10)
            {
                sigurnaSuma = 100000;
            }
            else if (brojPogodeniPrasanja == 15)
            {
                sigurnaSuma = 100000;
            }
            poeni = sigurnaSuma;
        }

        private void buttonPovikajPrijatel_Click(object sender, EventArgs e)
        {
            playFriend();
            povikajPrijatel friend = new povikajPrijatel();
            DialogResult r = friend.ShowDialog();
            buttonPovikajPrijatel.Enabled = false;
            if (r == System.Windows.Forms.DialogResult.Cancel)
            {
                player.Stop();
                player.Stream = ZbirIgri.Properties.Resources.Question;
                player.Load();
                player.PlayLooping();
            }

        }

        private void button50_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();

            int tocenOdgovor = 0;
            if (buttonOdgovor1.Text == momentalnoPrasanje.tocenOdgovor)
            {
                tocenOdgovor = 0;
            }
            else if (buttonOdgovor2.Text == momentalnoPrasanje.tocenOdgovor)
            {
                tocenOdgovor = 1;
            }
            else if (buttonOdgovor3.Text == momentalnoPrasanje.tocenOdgovor)
            {
                tocenOdgovor = 2;
            }
            else if (buttonOdgovor4.Text == momentalnoPrasanje.tocenOdgovor)
            {
                tocenOdgovor = 3;
            }

            Random r = new Random();
            List<int> broevi = new List<int>();
            int brojac = 0;
            while (true)
            {
                int c = r.Next(4);
                if (!broevi.Contains(c) && tocenOdgovor != c)
                {
                    broevi.Add(c);
                    ++brojac;
                }
                if (brojac == 2)
                {
                    break;
                }

            }

            if (broevi.ElementAt(0) == 0)
            {
                buttonOdgovor1.Hide();
            }
            else if (broevi.ElementAt(0) == 1)
            {
                buttonOdgovor2.Hide();
            }
            else if (broevi.ElementAt(0) == 2)
            {
                buttonOdgovor3.Hide();
            }
            else if (broevi.ElementAt(0) == 3)
            {
                buttonOdgovor4.Hide();
            }
            if (broevi.ElementAt(1) == 0)
            {
                buttonOdgovor1.Hide();
            }
            else if (broevi.ElementAt(1) == 1)
            {
                buttonOdgovor2.Hide();
            }
            else if (broevi.ElementAt(1) == 2)
            {
                buttonOdgovor3.Hide();
            }
            else if (broevi.ElementAt(1) == 3)
            {
                buttonOdgovor4.Hide();
            }


            button50.Enabled = false;






        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            player.Stream = ZbirIgri.Properties.Resources.Millionaire;
            player.Load();
            player.PlayLooping();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++vreme;
            if (listaSumi.SelectedIndex == listaSumi.Items.Count - 1)
            {
                listaSumi.SelectedIndex = 0;
            }

            listaSumi.SelectedIndex += 1;

        }
        public void playNotCorrect()
        {
            player.Stop();
            player.Stream = ZbirIgri.Properties.Resources.Millionaire;
            player.Load();
            player.PlayLooping();
        }
        public void playFriend()
        {
            player.Stop();
            player.Stream = ZbirIgri.Properties.Resources.Friend;
            player.Load();
            player.PlayLooping();
        }

        public void playCorrect()
        {
            player.Stop();
            player.Stream = ZbirIgri.Properties.Resources.secena;
            player.Load();
            player.PlayLooping();
        }
        public void playQuestion() {
            player.Stop();
            player.Stream = ZbirIgri.Properties.Resources.Question;
            player.Load();
            player.PlayLooping();
        }

        public void Zavrsi()
        {
            playNotCorrect();
            pogodenoPrasanje = false;
            DialogResult r = MessageBox.Show(String.Format("Овде завршува вашата игра. Освоивте {0} денари", sigurnaSuma), "Алерт", MessageBoxButtons.OK);
            if (r == System.Windows.Forms.DialogResult.OK)
                timer1.Start();
            if (poeni > maxPoeni)
                maxPoeni = poeni;
            poeni = 0;

            pbSlika.BackgroundImage = ZbirIgri.Properties.Resources.fin_mil;

            buttonSlednoPrasanje.IsAccessible = false;
            skrijOdgovoriLabeli();
            button50.Enabled = false;

            buttonPovikajPrijatel.Enabled = false;
            button1.Enabled = false;
            

        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Дали сакате да го затворите прозорецот?", "Затвори", MessageBoxButtons.YesNo);
            if (r == System.Windows.Forms.DialogResult.Yes)
            {
                igrac = new Igrach(ime, maxPoeni);
                Close();
            }
        }

        private void MilionerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult dr= MessageBox.Show("Дали сте сигурни дека сакате да се откажете?", "Откажување", MessageBoxButtons.YesNo);
           if (dr == DialogResult.Yes)
           {
               novaIgra();
           }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            player.Stop();
            playFriend();
            PrasajPublika pb = new PrasajPublika();
            DialogResult r = pb.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.Cancel)
            {
                player.Stop();
                playQuestion();
            }
            button1.Enabled = false;
        }

        private void buttonOdgovor1_MouseHover(object sender, EventArgs e)
        {
            buttonOdgovor1.BackColor = Color.Green;
        }

        private void buttonOdgovor1_MouseLeave(object sender, EventArgs e)
        {
            buttonOdgovor1.BackColor = Color.Beige;
        }

        private void buttonOdgovor3_MouseHover(object sender, EventArgs e)
        {
            buttonOdgovor3.BackColor = Color.Green;
        }

        private void buttonOdgovor3_MouseLeave(object sender, EventArgs e)
        {
            buttonOdgovor3.BackColor = Color.Beige;
        }

        private void buttonOdgovor2_MouseHover(object sender, EventArgs e)
        {
            buttonOdgovor2.BackColor = Color.Green;
        }

        private void buttonOdgovor2_MouseLeave(object sender, EventArgs e)
        {
            buttonOdgovor2.BackColor = Color.Beige;
        }

        private void buttonOdgovor4_MouseHover(object sender, EventArgs e)
        {
            buttonOdgovor4.BackColor = Color.Green;
        }

        private void buttonOdgovor4_MouseLeave(object sender, EventArgs e)
        {
            buttonOdgovor4.BackColor = Color.Beige;
        }

        private void buttonSlednoPrasanje_MouseEnter(object sender, EventArgs e)
        {
            buttonSlednoPrasanje.BackColor = Color.BlueViolet;
        }

        private void buttonSlednoPrasanje_MouseLeave(object sender, EventArgs e)
        {
            buttonSlednoPrasanje.BackColor = Color.Beige;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Tomato;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Beige;
        }

       

        private void button50_MouseMove(object sender, MouseEventArgs e)
        {
            button50.BackColor = Color.Beige;
        }

        private void button50_MouseHover(object sender, EventArgs e)
        {
            button50.BackColor = Color.Tomato;
        }

        private void buttonPovikajPrijatel_MouseHover(object sender, EventArgs e)
        {
            buttonPovikajPrijatel.BackColor = Color.Tomato;

        }

        private void buttonPovikajPrijatel_MouseMove(object sender, MouseEventArgs e)
        {
            buttonPovikajPrijatel.BackColor = Color.Beige;
        }

        
            
        

       


    }
}
