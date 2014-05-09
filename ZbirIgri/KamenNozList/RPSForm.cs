using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZbirIgri
{
    public partial class RPSForm : Form
    {
        //Ova e formata za igrata Kamen,Nozici,List
        public List<String> listaRezultat { set; get; }//lista od string-ovi vo koi kje se cuvaat site rezultati dosegasni
        public Boolean playerChosed = false;//boolean promenliva so koja kje se sledi redosledot na igrac/kompjuter
        public string igracotIzbra, kompjuterotIzbra;// string-ovi koi ni sluzat da gi primenime pravilata
        public int poeniIgrac, poeniKompjuter;//poeni na igracot, poeni na kompjuterot
        public int brojIgri;//broi kolku pati se izigrala igrata
        public Igrach player;// instanca od klasata Igrach 
        int maxpoeni;//maksimalno osvoeni poeni na igracot
        string ImeP;//ime na igracot
        System.Media.SoundPlayer pl;
        
        public RPSForm(string Ime)
        {
            //vo Konstruktorot ja iniciralizirame listata, poenite na igracot pri pocetok na sekoja nova igra se 0
            // isto i max poenite i brojot na igri e 0
            InitializeComponent();
            pl = new System.Media.SoundPlayer();
            
            ImeP = Ime;
            listaRezultat=new List<String>();
            poeniIgrac = 0;
            poeniKompjuter = 0;
            brojIgri = 0;
            maxpoeni = 0;
            
        }

        private void btRock_Click(object sender, EventArgs e)
        {
            //Se obrabotuva Click eventot na kopceto koe sodrzi slika so kamen
            if (playerChosed == false)
            {
                playerChosed = true;
                Image pic = btRock.Image;
                pbMyChoise.Image = pic;
                computerChoose();
                igracotIzbra = "Rock";
                proveriRezultat();
                ++brojIgri;
            }
            playerChosed = false;
            
        }

        private void btScissors_Click(object sender, EventArgs e)
        {
            //Se obrabotuva Click eventot na igracot koj izbral Nozici
            if (playerChosed == false)
            {
                playerChosed = true;
                Image pic = btScissors.Image;
                pbMyChoise.Image = pic;
                computerChoose();
                igracotIzbra = "Scissors";
                proveriRezultat();
                ++brojIgri;
            }
            playerChosed = false;
            
        }

        private void btPaper_Click(object sender, EventArgs e)
        {
            // se Obrabotuva Click Eventot na igracot koj izbral List
            if (playerChosed == false)
            {
                playerChosed = true;
                Image pic = btPaper.Image;
                pbMyChoise.Image = pic;
                computerChoose();
                igracotIzbra = "Paper";
                proveriRezultat();
                ++brojIgri;
                
            }
            playerChosed = false;
        }

        public void computerChoose()
        {
            //Metod koj se povikuva vo site tri Click eventi i simulira izbor na Kompjuterot
            Random r = new Random();
            int izbor = r.Next();
            Image izbranaSlika;
            if (izbor % 3 == 0)
            {
                izbranaSlika = btRock.Image;
                kompjuterotIzbra = "Rock";
            }
            else if (izbor % 3 == 1)
            {
                izbranaSlika = btScissors.Image;
                kompjuterotIzbra = "Scissors";
            }
            else
            {
                izbranaSlika = btPaper.Image;
                kompjuterotIzbra = "Paper";
            }
            pbComputerChoise.Image = izbranaSlika;

        }
        private void proveriRezultat()
        {
            //Metod koj dodava rezultat vo ListBox
            if (igracotIzbra == kompjuterotIzbra)
            {
                listaRezultat.Add("Нерешено");
                labelaWinner.Text = "Нерешено";

            }
            else if (igracotIzbra == "Rock" && kompjuterotIzbra == "Scissors")
            {
                pl.Stream = ZbirIgri.Properties.Resources.correct;
                pl.Play();
            
                listaRezultat.Add("Играчот победил");
                labelaWinner.Text = "Играчот";
                ++poeniIgrac;
            }
            else if (igracotIzbra == "Scissors" && kompjuterotIzbra == "Paper")
            {
                pl.Stream = ZbirIgri.Properties.Resources.correct;
                pl.Play();
                listaRezultat.Add("Играчот победил");
                labelaWinner.Text = "Играчот";
                ++poeniIgrac;
            }
            else if (igracotIzbra == "Paper" && kompjuterotIzbra == "Rock")
            {
                pl.Stream = ZbirIgri.Properties.Resources.correct;
                pl.Play();
                listaRezultat.Add("Играчот победил");
                labelaWinner.Text = "Играчот";
                ++poeniIgrac;
            }
            else if (igracotIzbra == "Scissors" && kompjuterotIzbra == "Rock")
            {
                pl.Stream = ZbirIgri.Properties.Resources.error;
                pl.Play();
                listaRezultat.Add("Компјутерот победил");
                labelaWinner.Text = "Компјутерот";
                ++poeniKompjuter;
            }
            else if (igracotIzbra == "Paper" && kompjuterotIzbra == "Scissors")
            {
                pl.Stream = ZbirIgri.Properties.Resources.error;
                pl.Play();
                listaRezultat.Add("Компјутерот победил");
                labelaWinner.Text = "Компјутерот";
                ++poeniKompjuter;
            }
            else if (igracotIzbra == "Rock" && kompjuterotIzbra == "Paper")
            {
                pl.Stream = ZbirIgri.Properties.Resources.error;
                pl.Play();
                listaRezultat.Add("Компјутерот победил");
                labelaWinner.Text = "Компјутерот";
                ++poeniKompjuter;
            }
            poeniPlayer.Text = poeniIgrac + "";
            poeniPC.Text = poeniKompjuter + "";

            listaRezultati.Items.Clear();
            foreach (string s in listaRezultat)
            {
                listaRezultati.Items.Add(s);
            }
        }


        private void btReset_Click(object sender, EventArgs e)
        {
            //Click event za Kopceto Reset
            if (poeniIgrac > maxpoeni)
                maxpoeni = poeniIgrac;
            playerChosed = false;
            listaRezultati.Items.Clear();
            listaRezultat.Clear();
            labelaWinner.Text = "";
            poeniKompjuter = 0;
            poeniIgrac = 0;
            poeniPC.Text = "0";
            poeniPlayer.Text = "0";
        }

        private void zatvori_Click(object sender, EventArgs e)
        {
            //Click event za kopceto Zatvori prozorec
            if (poeniIgrac > maxpoeni)
                maxpoeni = poeniIgrac;
            DialogResult r = MessageBox.Show("Дали сакате да го затворите прозорецот?", "Затвори", MessageBoxButtons.YesNo);
            if (r == System.Windows.Forms.DialogResult.Yes)
            {
                player = new Igrach(ImeP,maxpoeni);
                Close();
            }
        }

        
       
       
     

        
     
    }
}
