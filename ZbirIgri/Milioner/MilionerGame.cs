using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZbirIgri
{
    public class MilionerGame
    {
        public List<Prasanje> Prasanja { set; get; }
       

        public List<int> broeviLesniPrasanja { set; get; }
        public List<int> broeviTeskiPrasanja { set; get; }
        public List<int> broeviSredniPrasanja { set; get; }

        public MilionerGame()
        {
           Prasanja = new List<Prasanje>();
           
            broeviLesniPrasanja = new List<int>();
            broeviSredniPrasanja = new List<int>();
            broeviTeskiPrasanja = new List<int>();
           // izgenerirajPrasanja();
        }


        public void izgenerirajPrasanja()
        {
            Random r = new Random();
            int brojac = 0;
            while (true)
            {
                int chosen = r.Next(0,Prasanja.Count-1);
                if (!broeviLesniPrasanja.Contains(chosen) && Prasanja.ElementAt(chosen).kategorija == "Lesna") 
                {
                    broeviLesniPrasanja.Add(chosen);
                    ++brojac;
                }
                if (brojac == 5) break;
            }
            brojac = 0;
            while (true)
            {
                int chosen = r.Next(0,Prasanja.Count);
                if (!broeviSredniPrasanja.Contains(chosen) && Prasanja.ElementAt(chosen).kategorija == "Sredna")
                {
                    broeviSredniPrasanja.Add(chosen);
                    ++brojac;
                }
                if (brojac == 5) break;
            }
            brojac = 0;
            while (true)
            {
                int chosen = r.Next(0,Prasanja.Count);
                if (!broeviTeskiPrasanja.Contains(chosen) && Prasanja.ElementAt(chosen).kategorija == "Teska" )
                {
                    broeviTeskiPrasanja.Add(chosen);
                    ++brojac;
                }
                if (brojac == 5) break;
            }

        }
        public void addQuestion(Prasanje prasanje)
        {
            Prasanja.Add(prasanje);  
        }
            

        }


    }

