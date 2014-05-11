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
    public partial class povikajPrijatel : Form
    {
        public int procent { set; get; }
        public int odgovor { set; get; }
        public int vreme { set; get; }
        public string answer { set; get; }
        public char tocenOdgovor { set; get; }
        public povikajPrijatel(char c)
        {
            InitializeComponent();
            timer1.Start();
            tocenOdgovor = c;
            
            generiraj();
           
        }
        public void generiraj ()
        {
            Random r=new Random();
            odgovor=r.Next(4);
            procent = r.Next(100);
       
            if (tocenOdgovor=='A')
            {
                answer = "A";
            }
            else if (tocenOdgovor == 'B')
            {
                answer = "B";
               
            }
            else if (tocenOdgovor == 'C')
            {
                answer = "C";
            }
            else if (tocenOdgovor == 'D')
            {
                answer = "D";
               
                
            }

           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++vreme;
            if (vreme == 5)
            {
                label1.Text = "Томче вели : Мислам дека одговорот е под ";
                labelOdgovor.Text = answer;
            }
            if (vreme == 10)
            {
                label2.Text = "Јас: Колку си сигурен?";
            }
            if (vreme == 15)
            {
                labelaProcent.Text = String.Format("Томче вели: {0} проценти",procent);
            }
            if (vreme == 60)
            {
                this.Close(); 
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

       
       
    }
}
