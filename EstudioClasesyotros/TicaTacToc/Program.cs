using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicaTacToc
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            TicTac tic=new TicTac();
            Boolean Salida = false;
            Boolean win=false;
            int varX;
            int varO;
            int input_class = 0;
            tic.Dibuje_Cuadricula();
            int counterjugadas = 0;

            while (!Salida)
            {
                
                for (int j = 0; j < 2; j++)
                {
                    
                    input_class = j;                  
                    var output = tic.realize_cambios(input_class);
                    int[] var_x = output.val_X;
                    int[] var_o = output.val_O;
                    for (int i = 0; i < 9; i = i + 3)
                    {
                        varX = var_x[i] + var_x[i + 1] + var_x[i + 2];
                        varO = var_o[i] + var_o[i + 1] + var_o[i + 2];
                        if (varX == 3 | varO == 3)
                        {
                            if (varX == 3)
                            {
                                Console.WriteLine("ganador jugador 1\nganador jugador 1\nganador jugador 1");
                                Salida = true;
                                win = true;

                            }
                            else
                            {
                                Console.WriteLine("ganador jugador 2\nganador jugador 2\nganador jugador 2");
                                Salida = true;
                                win = true;
                            }
                        }

                    }

                    for (int i = 0; i < 3; i++)
                    {
                        varX = var_x[i] + var_x[i + 3] + var_x[i + 6];
                        varO = var_o[i] + var_o[i + 3] + var_o[i + 6];
                        if (varX == 3 | varO == 3)
                        {
                            if (varX == 3)
                            {
                                Console.WriteLine("ganador jugador 1\nganador jugador 1\nganador jugador 1");
                                Salida = true;
                                win = true;

                            }
                            else
                            {
                                Console.WriteLine("ganador jugador 2\nganador jugador 2\nganador jugador 2");
                                Salida = true;
                                win = true;
                            }
                        }
                    }
                    varX = var_x[0] + var_x[4] + var_x[8];
                    varO = var_o[0] + var_o[4] + var_o[8];
                    if (varX == 3 | varO == 3)
                    {
                        if (varX == 3)
                        {
                            Console.WriteLine("ganador jugador 1\nganador jugador 1\nganador jugador 1");
                            Salida = true;
                            win = true;

                        }
                        else
                        {
                            Console.WriteLine("ganador jugador 2\nganador jugador 2\nganador jugador 2");
                            Salida = true;
                            win = true;
                        }
                    }
                    varX = var_x[2] + var_x[4] + var_x[6];
                    varO = var_o[2] + var_o[4] + var_o[6];
                    if (varX == 3 | varO == 3)
                    {
                        if (varX == 3)
                        {
                            Console.WriteLine("ganador jugador 1\nganador jugador 1\nganador jugador 1");
                            Salida = true;
                            win = true;

                        }
                        else
                        {
                            Console.WriteLine("ganador jugador 2\nganador jugador 2\nganador jugador 2");
                            Salida = true;
                            win = true;
                        }


                    }
                   
                    counterjugadas++;
                    if (counterjugadas > 8 & win==false)
                    {
                        win = true;
                        Salida = true;
                        Console.WriteLine("Nadie Gana");
                    }
                    if (win)
                    {
                        j = 3;
                    }




                }


            }
            Console.ReadKey();

        
        }
    }
}
