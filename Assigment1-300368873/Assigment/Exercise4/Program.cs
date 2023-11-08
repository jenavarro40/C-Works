using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal input_miles = 4.50M;
            decimal feet_output = input_miles * 5280.00M;
            decimal Meters_output = input_miles * 1604.39M;
            decimal Km_output = Meters_output / 1000.00M;
            input_miles = Math.Round(input_miles, 2);
            feet_output= Math.Round(feet_output, 0);
            Meters_output= Math.Round(Meters_output, 2);
            Km_output = Math.Round(Km_output, 2);
            
            Console.WriteLine("The value {0} in miles is equivalent to {1} in feet,", input_miles, feet_output);
            Console.WriteLine("{0} in meters, and {1} in Km", Meters_output, Km_output);
            Console.WriteLine("Hello World");
            Console.ReadKey();
            
        }
    }
}
