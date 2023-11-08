using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meta los numeros: ");
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            input2=input1 + input2;
            Console.WriteLine( "el resultado de la suma " + input2);
           
        }
    }
}
