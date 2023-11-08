using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNumeroalazar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Entrada1_String;
            string Entrada2_String;
            int Entrada1_Int = 0;
            int Entrada2_Int = 0;
            int value_while = 0;
            int Value_Random;
            Random rnd = new Random();
            while (value_while == 0)
            {
                Console.WriteLine("Write numbers 10 to 20 and press enter");
                Entrada1_Int = int.Parse(Console.ReadLine());
                if (Entrada1_Int>9 && Entrada1_Int<21)
                {
                    value_while = 1;
                }
            }
            value_while = 0;
            while (value_while == 0)
            {
                Console.WriteLine("Write numbers 10 to 20 and press enter");
                Entrada2_Int = int.Parse(Console.ReadLine());
                if (Entrada2_Int > 9 && Entrada2_Int < 21)
                {
                    value_while = 1;
                }
            }
            if (Entrada1_Int>Entrada2_Int)
            {
                value_while = Entrada1_Int;
                Entrada1_Int = Entrada2_Int;
                Entrada2_Int = value_while;
            }
            Value_Random=rnd.Next(Entrada1_Int, Entrada2_Int);
            Console.WriteLine(Value_Random);
            Console.ReadKey();

        }
    }
}
