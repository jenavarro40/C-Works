using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Symbol");
            string value1=Console.ReadLine();
            Console.WriteLine("Write number of times");
            int value2=int.Parse(Console.ReadLine());
            int value3 = value2;
            //value2 = 0;
            for (int i = 0;i<value3+1;i++)
               
            {
                for (int j = 0; j < value2 + 1; j++)
                {
                    Console.Write("{0}", value1);


                }
                value2--;
                
                Console.Write(Environment.NewLine);

            }

            Console.ReadKey();

        }
    }
}
