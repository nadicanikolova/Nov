using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZbirIgri.Milioner
{
    public partial class PrasajPublika : Form
    {
        public int vreme { set; get; }
        public int procent1 { set; get; }
        public int procent2 { set; get; }
        public int procent3 { set; get; }
        public int procent4 { set; get; }
        public char tocenOdgovor { set; get; }
        public PrasajPublika(char c)
        {
            InitializeComponent();
            timer1.Start();
            tocenOdgovor = c;
        }

        public void izgenerirajProcenti()
        {
            List<int> listaprocenti=new List<int>();

            Random r = new Random();

            if (tocenOdgovor == 'A')
            {
                procent1 = r.Next(90, 100);
                procent2 = r.Next(0, 100 - procent1);
                procent3 = r.Next(0, 100 - (procent2 + procent1));
                procent4 = 100 - (procent2 + procent1 + procent3);

            }

            else if (tocenOdgovor == 'B')
            {
                procent2 = r.Next(90, 100);
                procent1 = r.Next(0, 100 - procent2);
                procent3 = r.Next(0, 100 - (procent2 + procent1));
                procent4 = 100 - (procent2 + procent1 + procent3);

            }

            else   if (tocenOdgovor == 'C')
            {
                procent3 = r.Next(90, 100);
                procent2 = r.Next(0, 100 - procent3);
                procent1 = r.Next(0, 100 - (procent3 + procent2));
                procent4 = 100 - (procent2 + procent1 + procent3);

            }
           
            if (tocenOdgovor == 'D')
            {
                procent4 = r.Next(90, 100);
                procent1 = r.Next(0, 100 - procent4);
                procent2= r.Next(0, 100 - (procent4 + procent1));
                procent3 = 100 - (procent2 + procent1 + procent4);

            }


            if (procent1 < 0)
            {
                procent1 = 0;
            }
            if (procent2 < 0)
            {
                procent2 = 0;
            }
            if (procent3 < 0)
            {
                procent3 = 0;
            }
            if (procent4 < 0)
            {
                procent4 = 0;
            }

            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++vreme;
            label5.Text = String.Format("{0}:{1}", vreme / 60, vreme % 60);
            if (vreme == 15)
            {
                timer1.Stop();
                izgenerirajProcenti();
                progressBar1.Value = procent1;
                progressBar2.Value = procent2;
                progressBar3.Value =  procent3;
                progressBar4.Value = procent4;
                label6.Text = procent1 + "%";
                label7.Text = procent2 + "%";
                label8.Text = procent3 + "%";
                label9.Text = procent4 + "%";
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
