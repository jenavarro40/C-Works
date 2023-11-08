using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showBarChart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            input_char_bart barchar= new input_char_bart();
            int[] values_chart=barchar.input_Array_chart();
            foreach (int value in values_chart)
            {
                if (value == 10)
                {
                    Console.Write(value + ": ");
                }
                else
                {
                    Console.Write(value + ":  ");
                }
                for (int i = 0; i < value; i++)
                {
                    Console.Write("*");

                }
                Console.Write("\n");
                    
                
            }
            Console.ReadKey();

        }
    }
}
