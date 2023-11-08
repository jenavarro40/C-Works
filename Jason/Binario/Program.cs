using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_No2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Digits = new int[2, 100]; // [2, 100] donde 2 es el No de filas y 100 No de columnas

            int a = 4;

            for (int i = 0; i < Digits.GetLength(0); i++) //dimension 1 
            {
                for (int j = 0; j < Digits.GetLength(1); j++)
                {
                    Digits[i, j] = a;
                    Console.Write(Digits[i, j]); //dibuja

                }

                a = a - 2;
                Console.WriteLine("\n"); //dibuja

            }
            int Sum = 0;
            string carry;
            string[] result = new string[Digits.GetLength(1)]; //para inicializa rel array donde ira el resultado
            string carryL;
            string carryR;
            int carryNumber = 0;

            for (int j = Digits.GetLength(1) - 1; j >= 0; j--) // forma para hacer decrecer el numero de iteraciones en las columnas
            {
                for (int i = 0; i < Digits.GetLength(0); i++) // las filas
                {
                    Sum = Sum + Digits[i, j] + carryNumber;
                    carry = Sum.ToString();

                    if (j != 0)
                    {
                        if (carry.Length == 2 && i == 1)
                        {
                            carryL = carry.Substring(0, 1);
                            carryR = carry.Substring(1, 1);
                        }
                        else
                        {
                            carryR = carry;
                            carryL = "0";
                        }
                    }
                    else
                    {
                        carryR = carry;
                        carryL = "0";
                    }

                        carryNumber = int.Parse(carryL);
                    result[j] = carryR;

                   

                }
                Sum = 0;
            }
            Console.WriteLine("=");
            for(int i = 0;i<result.Length;i++)
            {
                Console.Write(result[i]);
            }




            Console.ReadKey();
        }


    }
}