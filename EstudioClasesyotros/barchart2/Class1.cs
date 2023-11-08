using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barchart2
{
    internal class input_char_bart
    {
        public int[] input_Array_chart()
        {
            int _exit_n_chart;
            int _area_n_chart;
            while (true)
            {
                Console.WriteLine("Please input the number values to check:");
                if (int.TryParse(Console.ReadLine(), out _exit_n_chart) == false)
                {
                    Console.WriteLine("Wrong input please try again");
                }
                else
                {
                    break;
                }

            }
            int[] chart_input = new int[_exit_n_chart];

            for (int i = 0; i < chart_input.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine("Please input the {0}", i + 1);
                    if (int.TryParse(Console.ReadLine(), out _area_n_chart) == false)
                    {
                        Console.WriteLine("Wrong value please try again");
                    }
                    else
                    {
                        if (_area_n_chart >= 0 & _area_n_chart < 11)
                        {
                            chart_input[i] = _area_n_chart;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wrong number please try again");
                        }

                    }
                }
            }
            Console.Clear();
            return chart_input;
        }
    }
}
