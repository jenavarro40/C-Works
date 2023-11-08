using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFacildeLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string salida="";
            
            int correct=0;
            int incorrect=0;
            while (!(salida == "s"|| salida == "S"))
            {
                Console.WriteLine("Enter de value Between 1 and 100:");
                salida = Console.ReadLine();
                if (int.TryParse(salida, out int value))
                {
                    if (value >= 1 & value <= 100)
                    {
                        correct++;
                        Console.Clear();
                        Console.WriteLine("Correct Value");
                        

                    }
                    else
                    {
                        incorrect++;
                        Console.Clear();
                        Console.WriteLine("inCorrect Value");
                        
                    }
                }
                else
                {
                    incorrect++;
                    Console.Clear();
                    Console.WriteLine("inCorrect Value");
                    

                }

            }
            Console.WriteLine("Correct Value {0} and incorrect value {1}", correct, incorrect);
            Console.ReadKey();
           
        }
    }
}
