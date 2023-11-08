using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leerachivos
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string currentPath = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine("Directorio actual: " + currentPath);
            Console.ReadKey();
        }


    }
}