using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "Javier", "Sara", "Carolina", "Teresa", "Raul", "Angela" };
            foreach (string nVal in names)
                Console.Write(nVal + "\n");
            Console.ReadLine();
            Console.WriteLine("Ordenado\n");
            Array.Sort(names);
            foreach (string nVal in names)
                Console.Write(nVal + "\n");
            Console.ReadLine();
        }
    }
}
