using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Radio_esfera_String;
            double Radio_esfera_Double;
            double superficie;
            double volumen;
            Console.WriteLine("What is your radio of esfera");
            Radio_esfera_String = Console.ReadLine();
            Radio_esfera_Double = Convert.ToDouble(Radio_esfera_String);
            superficie = 4.0 * 3.14 * Radio_esfera_Double * Radio_esfera_Double;
            volumen = (4 / 3) * 3.14 * Radio_esfera_Double * Radio_esfera_Double * Radio_esfera_Double;
            Console.WriteLine("Suffers is: {0} and Volumen is {1}:", (superficie), (volumen));
            //SEGUNDO PROGRAMA
            int Entrada1;
            int Entrada2;
            int Result;
            string Entrada1_string;
            string Entrada2_string;
            Console.WriteLine("Write numbers and press enter");
            Entrada1_string = Console.ReadLine();
            Entrada2_string = Console.ReadLine();
            Entrada1 = Convert.ToInt32(Entrada1_string);
            Entrada2 = Convert.ToInt32(Entrada2_string);
            Result = Entrada1 * Entrada2;
            Console.WriteLine("Multiplication from: {0} and {1} is: {2}", (Entrada1), (Entrada2), (Result));
            Result = Entrada1 / Entrada2;
            Console.WriteLine("Division from: {0} and {1} is: {2}", (Entrada1), (Entrada2), (Result));
            Result = Entrada1 + Entrada2;
            Console.WriteLine("Sum from: {0} and {1} is: {2}", (Entrada1), (Entrada2), (Result));
            Result = Entrada1 - Entrada2;
            Console.WriteLine("Rest from: {0} and {1} is: {2}", (Entrada1), (Entrada2), (Result));
            Result = Entrada1 % Entrada2;
            Console.WriteLine("Mod from: {0} and {1} is: {2}", (Entrada1), (Entrada2), (Result));

            Console.ReadKey();
        }


    }
}
