using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int Second_Input = 0;
            int Output_Hour = 0;
            int Output_Min = 0;
            int Output_Seconds = 0;
            Second_Input = ingressseconds();
            convert_in_hour(ref Second_Input,ref Output_Hour);
            convert_in_min(ref Second_Input, ref Output_Min);
            convert_in_seconds(ref Second_Input, ref Output_Seconds);
            if (Second_Input > 0)
            {
                Console.WriteLine("This time are {0} Hours {1} Minutes {2} Seconds", Output_Hour, Output_Min, Output_Seconds);
            }
            else
            {
                Console.WriteLine("error is not a number");
            }
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
        static int ingressseconds()
        {
            int seconds_input=0;
            Console.WriteLine("Please write a seconds:");
            try
            {
                seconds_input = int.Parse(Console.ReadLine());
            } 
            catch 
            {

                

            }

            return seconds_input;
            
        }
        static void convert_in_hour(ref int second_input,ref int output_hour)
        {
            if (second_input>0)
            {
                output_hour=second_input/3600;
            }
        }
        static void convert_in_min(ref int second_input, ref int output_min)
        {
            if (second_input > 0)
            {
                output_min = second_input % 3600;
                output_min = output_min / 60;

            }
        }
        static void convert_in_seconds(ref int second_input, ref int output_seconds)
        {
            if (second_input > 0)
            {
                output_seconds = second_input % 3600;
                output_seconds = output_seconds % 60;

            }
        }

    }
}
