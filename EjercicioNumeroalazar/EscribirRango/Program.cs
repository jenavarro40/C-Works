using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscribirRango
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write 2 numbers ");
            int Value1=int.Parse(Console.ReadLine());
            int Value2=int.Parse(Console.ReadLine());
            int j = Value1;
            float Value3;

            for (j=Value1;j<Value2+1;j++)
            {
                Value3 = (float)(Math.Pow(j, 2) + (2 * j) + 1);
                Console.Write("{0} ",Value3);
            }
            Console.ReadKey();
        }
    }
}
