using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCarpet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // len=12 ft 2 in w=14 ft 7 in
            const int Inches_per_feet = 12;
            const int sqft_per_sqyd = 9;


            int lenFT = 12;
            int lenIN = 2;
            int widhtFT = 14;
            int widthIN = 7;

            double len;
            double width;
            double areaSQFT;
            double areaSQYD;
            double ValueBerber;
            double ValuePile;





            //1. convert len and widdt to feet
            len = lenFT + (double)lenIN / Inches_per_feet;
            width = widhtFT + (double)widthIN / Inches_per_feet;
            //2. calculate area
            areaSQFT = len * width;
            //3. calculate change to sqyd
            areaSQYD = areaSQFT / sqft_per_sqyd;
            //4.Calculate the value
            ValueBerber = areaSQYD * 27.95;
            ValuePile = areaSQYD * 15.95;
            Console.WriteLine("Berber {0} Pile {1} ", ValueBerber, ValuePile);
            Console.ReadKey();
        }


    }
}
