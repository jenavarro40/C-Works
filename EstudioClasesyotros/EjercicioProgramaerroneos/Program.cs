using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EjercicioProgramaerroneos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mistake = 0;
            int arraynumber = 0;
            while (true)
            {
                Console.WriteLine("Initialize Array:");
                if (int.TryParse(Console.ReadLine(), out arraynumber))
                {
                    
                    break;
                }
                else 
                {
                    Console.WriteLine("The input data is not valid try again");
                }
            }
            Console.Clear();
            int[] arrayarray = new int[arraynumber];
            for (int i = 0; i < arraynumber; i++)
            {
                while (true)
                {
                    Console.WriteLine("Input Number between 0 and 10");
                    if (int.TryParse(Console.ReadLine(), out int val) == false)
                    {
                        Console.WriteLine("The input data is not a number try again");
                        mistake++;
                    }
                    else
                    {
                        if (val >= 0 & val < 10)
                        {
                            arrayarray[i] = val;
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("The input data is out of context try again");
                            mistake++;
                        }
                    }
                    
                    
                }
     
            }
            Console.Clear();
            foreach (int avalue in arrayarray)
            {
                Console.Write(avalue + " \t");
            }
            Console.WriteLine("\nErronuos data is:"+ mistake);
            Console.ReadKey();

        }
    }
}
