using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Miprimerprograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a; int b;
            WriteLine( "Escriba el primer numero");
            a =int.Parse(ReadLine());
            
            WriteLine("Escriba el segundo numero");
            b = int.Parse(ReadLine());
            b = a + b;
            WriteLine("El resultado es " + b);
            ReadKey();
        }
    }
}
