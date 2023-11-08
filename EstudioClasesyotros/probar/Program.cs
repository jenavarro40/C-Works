using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probar
{
    internal class Program
    {
        static void Main(string[] args)

        {

            int[,] juego = new int[,] { { 1, 1, 1, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0, 0, 1 } };
            int ValidarX = 0;
            int ValidarY = 0;
            String Ganar = "";
            int win = 0;
            int sumay = 0;

            for (int i = 0; i < 9; i += 3)
            {
                ValidarX = 0;
                ValidarY = 0;
                for (int j = 0; j < 3; j++)
                {
                    ValidarX = ValidarX + juego[0, j + i];
                    ValidarY = ValidarY + juego[1, j + i];
                }

            }
            if (ValidarX == 3) { Ganar = "Gana Jugador 1"; win = 1; }
            if (ValidarY == 3) { Ganar = "Gana Jugador 2"; win = 1; }


            for (int i = 0; i < 3; i++)
            {
                ValidarX = 0;
                ValidarY = 0;
                for (int j = 0; j < 9; j += 3)
                {
                    ValidarX = ValidarX + juego[0, j + i];
                    ValidarY = ValidarY + juego[1, j + i];
                }

            }
            if (ValidarX == 3) { Ganar = "Gana Jugador 1"; win = 1; }
            if (ValidarY == 3) { Ganar = "Gana Jugador 2"; win = 1; }
            ValidarX = 0;
            ValidarY = 0;

            for (int i = 0; i < 9; i += 4)
            {
                ValidarX = ValidarX + juego[0, i];
                ValidarY = ValidarY + juego[1, i];
            }
            if (ValidarX == 3) { Ganar = "Gana Jugador 1"; win = 1; }
            if (ValidarY == 3) { Ganar = "Gana Jugador 2"; win = 1; }
            ValidarX = 0;
            ValidarY = 0;

            for (int i = 6; i > 0; i -= 2)
            {
                ValidarX = ValidarX + juego[0, i];
                ValidarY = ValidarY + juego[1, i];
            }
            if (ValidarX == 3) { Ganar = "Gana Jugador 1"; win = 1; }
            if (ValidarY == 3) { Ganar = "Gana Jugador 2"; win = 1; }
            for (int i = 0;i < 2;i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(juego[i,j]);
                }
                Console.WriteLine("otro");
            }
            Console.ReadKey();
        }   
    }
}
