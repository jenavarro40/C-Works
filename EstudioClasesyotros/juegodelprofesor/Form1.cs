using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juegodelprofesor
{
    public partial class Form1 : Form
    {
        int card1;
        int card2;
        int card3;
        int win = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Betbutton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            card1 = random.Next(1, 13);
            card3 = random.Next(1, 13);
            card1button.Text = card1.ToString();
            card3button.Text = card3.ToString();
            Playbutton.Visible = true;
            card2button.Text = "E";

        }

        private void Playbutton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            card2 = random.Next(1, 13);
            card2button.Text = card2.ToString();

            if (card1 < card3 && card2 > card1 && card2 < card3) win++;
            else if (card1 > card3 && card2 < card1 && card2 > card3) win++;
            else win--;
            Playbutton.Visible = false;
            WintextBox.Text = win.ToString();
            if(win == 0)
            {
                Betbutton.Enabled = false;
            }
        }

        private void Moneybutton_Click(object sender, EventArgs e)
        {
            win = 10;
            WintextBox.Text = win.ToString();
            Betbutton.Enabled = true;
        }
    }
}
