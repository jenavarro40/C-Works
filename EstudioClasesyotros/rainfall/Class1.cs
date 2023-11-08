using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rainfall
{
    internal class RainFallyear
    {
        public void EnterValues(string[] months,int[] values)
        {
             
            //string[] months = {"January","February","March","April","May","June","July","August","September","October","November","December" };
            //values = new int[months.Length];       
            Boolean whileval = true;
            int outval;
            for (int i = 0; i < months.Length; i++) 
            {
                outval = i;
                while (whileval)
                {
                    Console.WriteLine("Input " + months[i]+ " Rainfall");
                    if ((int.TryParse(Console.ReadLine(), out values[outval]))==false)
                    {
                        Console.WriteLine("Input error Try Again");
                    }
                    else 
                    {

                        break;
                

                    }

                }
            }

            Console.Clear();
        }
        public int average(int[] values) 
        {
            int mean = 0;
            for (int i = 0;i < values.Length;i++) 
            {
                mean = mean + values[i];
            }
            mean=mean/values.Length;
            return mean;
        }
        
    }
}
