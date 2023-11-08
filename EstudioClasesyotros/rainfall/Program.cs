using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rainfall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            int[] values=new int[12];
            string[] months = { "January", "February", "March", "April","May", "June", "July", "August", "September", "October", "November", "December" };
            RainFallyear rain = new RainFallyear();
            rain.EnterValues(months,values);
            int mean = rain.average(values);
            int variance = 0;
            Console.WriteLine("The average is " + mean);
            for (int i = 0; i < months.Length; i++) 
            {
                variance=Math.Abs(values[i]-mean);
                Console.WriteLine("The Rain is: " + values[i]+ " in "+months[i]+" and the variance is: " + variance);

            }
            
            
            Console.ReadKey();
        }
    }
}
