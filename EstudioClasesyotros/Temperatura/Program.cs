using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] TempWeek = new double [7];
            double _min;
            double _max;
            double _avg;
            double _avgmin;
            string[] Week = { "Monday", "Tuesday", "Wednwsday","Thursday","Friday","Saturday","Sunday" };
            Temperature_Weekly temperature = new Temperature_Weekly();
            temperature.input_temperature(Week, out TempWeek); 
            for (int i = 0; i < TempWeek.Length; i++) 
            {
                Console.WriteLine("Day {0}, the Temperature was:{1} ",Week[i],TempWeek[i]);
            }
            temperature.Mesurements_Temperature(TempWeek,out _min,out _max,out _avg,out _avgmin);
            Console.WriteLine("MIN {0}, MAX {1}, AVG {2}, AVG WITHOUT MIN {3}", _min, _max, _avg, _avgmin);
            Console.ReadKey();
        }
    }
}
