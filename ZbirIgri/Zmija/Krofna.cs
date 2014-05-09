using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace ZbirIgri
{
    public class Krofna
    {
        public Image Krof = ZbirIgri.Properties.Resources.krofna;
        public float X { get; set; }
        public float Y { get; set; }

        public Krofna(float x, float y) {
            X = x;
            Y = y;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Krof, X, Y, 20, 20);
        }
    }
}
