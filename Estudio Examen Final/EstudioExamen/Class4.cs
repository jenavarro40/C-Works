using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioExamen
{
    internal class Mortage:calculoMortage
    {
        public double Price;
        public double Downp;
        public int Months;
        public double interesRate;
        public double payment;

        public Mortage(double price, double downp,int months): base(price, downp,months) 
        { 
            Price = price;
            Downp = downp;
            Months = months;
        }
        public double mortagecal()
        {
            if (Downp>= 30 && Months == 1)
            {
                interesRate = 4;
            }
            else if (Downp >= 50 && Months == 1)
            {
                interesRate = 3.5;
            }
            else if (Downp >= 70 && Months == 1)
            {
                interesRate = 3;
            }

            if (Downp >= 30 && Months == 2)
            {
                interesRate = 3.5;
            }
            else if (Downp >= 50 && Months == 2)
            {
                interesRate = 3;
            }
            else if (Downp >= 70 && Months == 2)
            {
                interesRate = 3;
            }
            payment= ((price-Downp) * (1+(interesRate/100))) / (12*months);
            return payment;
        }
       
    }
}
