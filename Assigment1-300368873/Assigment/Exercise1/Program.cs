using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{


    internal class Program
    {
        static void Main(string[] args)
        {
            // len=12 ft 2 in w=14 ft 7 in
           
            double len = 0;
            double width = 0;
            double ValueBerber = 0;
            double ValuePile = 0;

            //1. convert len and widdt to feet
            measurement_LW(ref len, ref width);

            //2. calculate area
            //3. calculate change to sqyd
            //4.Calculate the value
            calculus(ref len, ref width, ref ValueBerber, ref ValuePile);

            Console.WriteLine("Berber {0} Pile {1} ", ValueBerber, ValuePile);
            Console.WriteLine("Hello World")
            Console.ReadKey();
        }
        static void measurement_LW(ref double Len, ref double Width)
        {
            int lenFT = 12;
            int lenIN = 2;
            int widhtFT = 14;
            int widthIN = 7;
            const int Inches_per_feet = 12;
            Len = lenFT + (double)lenIN / Inches_per_feet;
            Width = widhtFT + (double)widthIN / Inches_per_feet;
        }
        static void calculus(ref double Len, ref double Width,ref double valueberber,ref double valuepile)
        {
            const int sqft_per_sqyd = 9;
            double areaSQFT;
            double areaSQYD;
            areaSQFT = Len* Width;
            //3. calculate change to sqyd
            areaSQYD = areaSQFT / sqft_per_sqyd;
            //4.Calculate the value
            valueberber = areaSQYD* 27.95;
            valuepile = areaSQYD* 15.95;
            
        }




}
}