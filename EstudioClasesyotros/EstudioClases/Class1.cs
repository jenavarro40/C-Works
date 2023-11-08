using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EstudioClases
{
    internal class Circulo
    {
        private const double pi = 3.1416;

        public double inputdatos()
        {

            
            double radioinput=0;
            bool entradaValida=false;
            while (!entradaValida)
            {
                Console.WriteLine("Ingrese el radio:");
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out radioinput))
                {
                    Console.WriteLine("Radio es: " + radioinput);

                    entradaValida = true;
                    
                    
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número valido.");
                }
            }
            return radioinput;



        }

        /* public double asignarpi
         {
             get { return pi; }
             set { pi=value; }
         }*/


        public void CalculoArea (double radio,ref double salida)
        {

            salida = pi * pi * radio;
        
        }

         

    }
}
