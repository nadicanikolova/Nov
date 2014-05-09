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
    public partial class IgraciLista : Form
    {
        public IgraciLista(List<Igrach> igraci1, List<Igrach> igraci2, List<Igrach> igraci3, List<Igrach> igraci4)
        {
            InitializeComponent();
            String []newStr = new String[2];
            ListViewItem item;
            foreach (Igrach ig in igraci1)
            {
                newStr[0] = ig.Ime;
                newStr[1] = ig.Poeni.ToString();
                item = new ListViewItem(newStr);
                lstSimon.Items.Add(item);
                
            }
           
            foreach (Igrach ig in igraci2)
            {
                newStr[0] = ig.Ime;
                newStr[1] = ig.Poeni.ToString();
                item = new ListViewItem(newStr);
                lstMilioner.Items.Add(item);
            }
            foreach (Igrach ig in igraci3)
            {
                newStr[0] = ig.Ime;
                newStr[1] = ig.Poeni.ToString();
                item = new ListViewItem(newStr);
                lstZmija.Items.Add(item);
            }
            foreach (Igrach ig in igraci4)
            {
                newStr[0] = ig.Ime;
                newStr[1] = ig.Poeni.ToString();
                item = new ListViewItem(newStr);
                lstKamen.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

      
        
       

       
    }
}
