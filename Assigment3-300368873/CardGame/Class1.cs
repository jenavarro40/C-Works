using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CardGame
{
    internal class Card

    {
        private Random random = new Random();
        public (string,string) cardsid(int cardNum,int cardTypenum)
        {
            string cardNumString="";
            string cardType="";
            if (cardNum > 9) 
            { 
                switch (cardNum)
                {
                    case 10: cardNumString = "J";break;
                    case 11: cardNumString = "Q"; break;
                    case 12: cardNumString = "K"; break;
                }
            }
            else
            {
                if (cardNum == 1) cardNumString = "A";
                else cardNumString = cardNum.ToString();
            }
            switch(cardTypenum)
            {
                case 1:cardType ="Heart";break;
                case 2: cardType = "Spead"; break;
                case 3: cardType = "Club"; break;
                default: cardType = "Diamonds"; break;
            }

            return (cardNumString, cardType);
        }
        public (int,int) cardsgenerator()
        {
       
            
            int card1 = random.Next(1, 13);
            int card2=random.Next(1, 5);
            return (card1, card2);
        }
        public string win(int[,] cards) 

        {

            string win;
            double sum1 = 0;
            double sum2 = 0;
            int blast1 = 0;
            int blast2 = 0;
            for (int i=0;i<cards.GetLength(1);i++)
            {
                if (cards[0, i] > 9) sum1 = sum1 + 0.5;
                else sum1 = sum1 + cards[0, i];
            }
            for (int i = 0; i < cards.GetLength(1); i++)
            {
                if(cards[1, i]>9) sum2 = sum2 + 0.5;
                else sum2 = sum2 + cards[1, i];
            }
            if (sum1 < 10) blast1 = 1;
            if (sum2 < 10) blast2 = 1;
            if (blast1 == 1 && blast2 == 1) win = "Both Blast Computer Win";
            else if (blast1 == 0 && blast2 == 1) win = "You Blast Computer Win";
            else if (blast1 == 1 && blast2 == 0) win = "Computer Blast Player Win";
            else if (sum1>sum2) win = "The winner is Computer";
            else win = "The winner is Player";

            return (win);
        }
        public (int[,], int[,]) initcard()
        {
            int[,] _cards=new int[2,4];
            int[,] _figure = new int[2, 4];
            for (int i = 0; i < _cards.GetLength(0); i++)
            {
                for (int j = 0; j < _cards.GetLength(1); j++)
                {
                    _cards[i, j] = 0;
                    _figure[i, j] = 0;
                }

            }
            return (_cards, _figure);

        }

    }
    
}
