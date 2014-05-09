using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZbirIgri
{
    public class SimonGame
    {
        public string[] Niza { get; set; }
        public int momIndeks = 0,br=0;
        Random ran ;
        public void addNiza() {

            br = ran.Next();
            br = br % 4;
            switch (br)
            {
                case 0: { Niza[momIndeks] = "red"; break; }
                case 1: { Niza[momIndeks] = "blue"; break; }
                case 2: { Niza[momIndeks] = "green"; break; }
                case 3: { Niza[momIndeks] = "yellow"; break; }
            }
            momIndeks++;
        }
        public SimonGame() {
            ran =  new Random();
            Niza = new string[20];
            momIndeks = 0;
        
        }
    }
}
