using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZbirIgri
{
    public class Prasanje
    {
        public string tekst { set; get; }
        public string tocenOdgovor { set; get; }
        public string kategorija { set; get; }
        public List<String> ponudeniOdgovori { set; get; }


        public Prasanje(string text, string correctAnswer, string category, string pon1, string pon2, string pon3, string pon4)
        {
            this.tekst = text;
            this.tocenOdgovor = correctAnswer;
            this.kategorija = category;
            ponudeniOdgovori = new List<string>();
            ponudeniOdgovori.Add(pon1);
            ponudeniOdgovori.Add(pon2);
            ponudeniOdgovori.Add(pon3);
            ponudeniOdgovori.Add(pon4);
        }
        public override string ToString()
        {
            return string.Format("{0}", tekst);
        }
    }
}
