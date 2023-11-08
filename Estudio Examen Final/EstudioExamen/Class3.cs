using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioExamen
{
    internal abstract class calculoMortage
    {
        public double price;
        public double downp;
        public double months;
        public calculoMortage(double price, double downp, int months)
        {
            this.price = price;
            this.downp = downp;
            this.months = months;
        }

    }
}
    