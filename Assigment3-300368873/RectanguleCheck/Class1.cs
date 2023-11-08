using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanguleCheck
{
    internal class Rectangule
    {
        public (string,string,string) calculate (double lenght, double widht)
        {
            double calculate = 2 * (lenght + widht);
            string perimeter=calculate.ToString("F2");
            calculate = lenght * widht;
            string area=calculate.ToString("F2");
            calculate=Math.Sqrt(Math.Pow(lenght, 2)+Math.Pow(widht,2));
            string diagonal=calculate.ToString("F2");
            return(perimeter,area,diagonal);

        }
    }
}
