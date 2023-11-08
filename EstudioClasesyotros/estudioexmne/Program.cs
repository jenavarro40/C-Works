using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudioexmne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aValue = 1000;
            int bvalue= 7;

            int result = aValue > bvalue + 100 ? 1000 : 2000;
            Console.WriteLine(result);
            Console.ReadKey();
        }   
    }
}
        