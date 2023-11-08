using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concatfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el Caracter: ");
            char caracter=char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero del triangulo: ");
            int triangulo= int.Parse(Console.ReadLine());
            
            for (int i=1;i<=triangulo;i++) 
            {
                
                Console.WriteLine(new string(caracter,i));
                
            }
            for (int i= triangulo-1;i>=1;i--)
            {

                Console.WriteLine(new string(caracter, i));

            }
            Console.ReadLine();
        }
        
    }
}
