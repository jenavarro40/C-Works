using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num_Binario;
            string Val_Bin;
            int Num_Binario2;
            int Val_Bin2;
            int Acumulado = 0;
            int Val_Bin3 = 0;
            int Bucle = 0;
            int salida = 0;
     

            while (Bucle == 0)
            {
                Console.WriteLine("Input the Binary Number no Longer than 20 Digits:");
                Val_Bin = Console.ReadLine();
                Num_Binario = Val_Bin.Length;
                Num_Binario2 = Num_Binario;


                for (int i = 0; i <= Num_Binario - 1; i++)
                {
                    Val_Bin2 = int.Parse(Val_Bin.Substring(Num_Binario2 - 1, 1));
                    salida = i;

                    if (Val_Bin2 == 0 || Val_Bin2 == 1)
                    {
                        Val_Bin3 = (int)((Val_Bin2) * (Math.Pow(2, i)));
                        Acumulado = Acumulado + Val_Bin3;
                    }

                    else
                    {
                        Console.WriteLine("Number not valid, try Again!");
                        i = Num_Binario + 1;
                    }
                    Num_Binario2--;
                }
                if (salida == Num_Binario-1)
                {
                    Bucle = 1;
                }
            }

            Console.WriteLine("El Numero binario es 0x"+Convert.ToString(Acumulado, 16));
            Console.ReadKey();

        }
    }
}