using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salida = 0;
            Circulo micirculo= new Circulo();
            double radio = micirculo.inputdatos();
            micirculo.CalculoArea(radio, ref salida);
            Console.WriteLine("El Area es " + salida);
            //micirculo.asignarpi = 31.416;
            micirculo.CalculoArea(radio, ref salida);
            Console.WriteLine("El Area2 es " + salida);
            Console.ReadKey();
        }
    }
}