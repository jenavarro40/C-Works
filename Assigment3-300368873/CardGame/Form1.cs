using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class GameForm : Form
    {

        int[,] cards = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        int[,] figure = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        int count = 0;
        public GameForm()
        {
            InitializeComponent();
        }

        private void Donebutton_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            if (count > 0 && count < 3)
            {
                string win = card.win(cards);
                MessageBox.Show(win);
                count = 4;
                (cards, figure) = card.initcard();
            }
            else if (count == 4) MessageBox.Show("Game Finish, Please push new Game");
            else if (count == 0) MessageBox.Show("you do not bet,Please push Bet");

        }

        private void Betbutton_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            string win;
            string cardsshow1;
            string typesshow1;
            string cardsshow2;
            string typesshow2;
            if (count < 4)
            {
                (cards[0, count], figure[0, count]) = card.cardsgenerator();
                (cardsshow1, typesshow1) = card.cardsid(cards[0, count], figure[0, count]);
                if (count == 0) { Compbutton1.Text = cardsshow1; Complabel1.Text = typesshow1; }
                else if (count == 1) { Compbutton2.Text = cardsshow1; Complabel2.Text = typesshow1; }
                else if (count == 2) { Compbutton3.Text = cardsshow1; Complabel3.Text = typesshow1; }
                else if (count == 3) { Compbutton4.Text = cardsshow1; Complabel4.Text = typesshow1; }
                (cards[1, count], figure[1, count]) = card.cardsgenerator();
                (cardsshow2, typesshow2) = card.cardsid(cards[1, count], figure[1, count]);
                if (count == 0) { Playerbutton1.Text = cardsshow2; Playerlabel1.Text = typesshow2; }
                else if (count == 1) { Playerbutton2.Text = cardsshow2; Playerlabel2.Text = typesshow2; }
                else if (count == 2) { Playerbutton3.Text = cardsshow2; Playerlabel3.Text = typesshow2; }
                else if (count == 3) { Playerbutton4.Text = cardsshow2; Playerlabel4.Text = typesshow2; }
                if (cards[0, count] == cards[1, count] && figure[0, count] == figure[1, count])
                {
                    MessageBox.Show("Be aware of cheating!");
                }


                count++;
                if (count == 4)
                {
                    win = card.win(cards);
                    MessageBox.Show(win);
                }
            }
            else
            {
                MessageBox.Show("Game Finish, Please push new Game");
            }
        }

        private void Newbutton_Click(object sender, EventArgs e)
        {
            Card card = new Card();

            count = 0;
            (cards, figure) = card.initcard();
            Compbutton1.Text = "";
            Compbutton2.Text = "";
            Compbutton3.Text = "";
            Compbutton4.Text = "";
            Complabel1.Text = "";
            Complabel2.Text = "";
            Complabel3.Text = "";
            Complabel4.Text = "";
            Playerbutton1.Text = "";
            Playerbutton2.Text = "";
            Playerbutton3.Text = "";
            Playerbutton4.Text = "";
            Playerlabel1.Text = "";
            Playerlabel2.Text = "";
            Playerlabel3.Text = "";
            Playerlabel4.Text = "";

        }
    }
}
