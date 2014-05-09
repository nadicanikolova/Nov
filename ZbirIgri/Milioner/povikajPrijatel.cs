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
        public povikajPrijatel()
        {
            InitializeComponent();
            timer1.Start();
            generiraj();
            
        }
        public void generiraj ()
        {
            Random r=new Random();
            odgovor=r.Next(4);
            procent = r.Next(100);
            
            if (odgovor == 0)
            {
                answer = "A";
            }
            else if (odgovor == 1)
            {
                answer = "B";
               
            }
            else if (odgovor == 2)
            {
                answer = "C";
            }
            else if (odgovor == 3)
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
