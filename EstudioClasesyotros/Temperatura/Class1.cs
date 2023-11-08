using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    internal class Temperature_Weekly
    {
        public void input_temperature(string[] Week_days, out double[] temperature)
        {
            temperature = new double[7];
            
            for (int i = 0; i < Week_days.Length; i++)
            {
                while (true)
                {


                    Console.WriteLine("Input Temperature {0}", Week_days[i]);
                    if (double.TryParse(Console.ReadLine(), out double outTemp) == false)
                    {
                        Console.WriteLine("Wrong Data Try again");
                    }
                    else
                    {
                        temperature[i] = outTemp;
                        break;

                    }
                }

            }
            Console.Clear();
        }

        public void Mesurements_Temperature(double[] Temperature,out double min,out double max,out double avg,out double avgmin)
        {
            max = -1;
            min = Temperature[0];
            avg = 0;
            avgmin = 0;
            int counter = 0;
            double[] output_measurement = new double[4];

            foreach (double vTemp in Temperature)
            {
                if (max < vTemp)
                {
                    max = vTemp;
                }
                if (min > vTemp)
                {
                    min = vTemp;
                }
                avg = avg + vTemp;
            }
            foreach (double vTemp in Temperature)
            { 
                if (vTemp != min)
                {
                    avgmin = avgmin + vTemp;
                    counter++;

                }
            }
            avg = avg / Temperature.Length;
            avgmin = avgmin / counter;




        }

    }
}
