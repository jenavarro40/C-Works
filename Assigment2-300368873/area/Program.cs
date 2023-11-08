using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int key;
            string yes = "y";
            while (yes != "n")
            {
                Console.WriteLine("Wich figure do you want calculate?");
                Console.WriteLine("1. Area Rectangule");
                Console.WriteLine("2. Area Circle");
                Console.WriteLine("3. Surface Area Cylinder");

                while (true)

                {
                    Console.WriteLine("Write Choose:");
                    if (int.TryParse(Console.ReadLine(), out key) == false) Console.WriteLine("Wrong data try again");
                    else
                    {

                        if (key > 0 && key < 4) break;
                        else Console.WriteLine("Wrong data try again");
                    }
                }

                figures figures = new figures();
                switch (key)
                {
                    case 1: figures.Rectangule(); break;
                    case 2: figures.circle(); break;
                    case 3: figures.circle2(); break;
                }
                while (true)
                {
                    Console.WriteLine("Do you want to continue? write y or n");
                    yes = Console.ReadLine();
                    if (yes == "y" || yes == "n") break;
                    else Console.WriteLine("Try Again");
                    
                }
            }
                    
        }
    }
}
