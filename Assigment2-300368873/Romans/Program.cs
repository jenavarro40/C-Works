using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanosFacil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yes = "y";
            while (yes != "n")
            {
                RomanosFaciles Romanos = new RomanosFaciles();
                decimal DecRoman = Romanos.EntradaDecimal();
                string RomanFines = " ";
                Romanos.Cambio_a_romanos(DecRoman, out RomanFines);
                Console.WriteLine("El numero romano es: " + RomanFines);
                
                
                while(true)
                {
                    Console.WriteLine("Do you Wish continue? please write y or n");
                    yes = Console.ReadLine();
                    if (yes == "y" || yes == "n") break;
                    else Console.WriteLine("Wrong input try again");
                   
                }
                Console.Clear();
            }
            
             
        }
    }
}
