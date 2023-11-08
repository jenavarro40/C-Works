using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplolista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> milista = new List<int>();

            Console.WriteLine(milista.Count);
            Console.WriteLine(milista.Capacity);
            milista.Capacity = 10;
            for(int i = 0; i < milista.Capacity; i++)
            {
                Random random = new Random();
                milista.Add(random.Next(0,99));
                Console.Write(milista[i]);
            }
            Console.WriteLine();
            Console.WriteLine(milista.Count);
            Console.WriteLine(milista.Capacity);

            Console.ReadKey();

        }
    }
}
