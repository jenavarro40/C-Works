using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barchart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            input_char_bart barchar = new input_char_bart();
            int[] values_chart = barchar.input_Array_chart();
            for (int i=10;i>0;i--)
            {
                for (int j=0;j<values_chart.Length;j++) 
                {
                    if (values_chart[j] >= i)
                    { 
                        if (values_chart[j] == 10)
                            Console.Write(" *\t");
                        else
                            Console.Write("*\t");
                    }
                    else
                    {
                        if (values_chart[j] == 10)
                            Console.Write("  \t");
                        else
                            Console.Write(" \t");
                    }
                    
                }
                Console.Write(" \n");
               
            }
            for (int j = 0; j < values_chart.Length; j++)
            {
                Console.Write("{0}\t", values_chart[j]);
            }
            Console.ReadKey();
        }
    }
}
