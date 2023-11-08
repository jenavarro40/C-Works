using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace javier

{
    
    internal class Treasure
    {
        int [,] cuadricula = new int[3,3] ;

        public int[,] inicializar_cuadricula()
        {
            for (int i = 0; i < cuadricula.GetLength(0); i++)
            {
                for (int j = 0; j < cuadricula.GetLength(1); j++)
                {
                    cuadricula[i, j] = 0;
                }
            }
            return cuadricula;


        }

        public int DrillDistance(int[,] calculo)
        {
            int Distance = 0;
            int var1 = -1;
            int var2 = -1;
            int var3 = -1;
            int var4 = -1;

            for (int i = 0; i < cuadricula.GetLength(0); i++)
            {
                for (int j = 0; j < cuadricula.GetLength(1); j++)
                {
                    if (calculo[i, j] == 1)
                    {
                        if (var1 == -1) { var1 = i; var2 = j; }
                        else if (var3 == -1) { var3 = i; var4 = j; }
                    }
                }
            }
            if (var1 == -1 || var2 == -1 || var3 == -1 || var4 == -1) Distance = 0;
            else Distance = Math.Abs(var1 - var3) + Math.Abs(var2 - var4);

            return Distance;
        }

        public int [,] trasure_array()
        {
            int[,] calculo = new int[3,3];
            for (int i = 0; i < calculo.GetLength(0); i++)
            {
                for (int j = 0; j < calculo.GetLength(1); j++)
                {
                    calculo[i, j] = 0;
                }
            }
            /*int var = -5;
            int var1 = -3;
            for (int i = 0; i < calculo.GetLength(0); i++)
            {
                for (int j = 0; j < calculo.GetLength(1); j++)
                {
                    
 
                    while (true)
                        
                    {
                        var random = new Random();
                        var = random.Next(1, 10);
                        if (var1 != var)
                        {
                            calculo[i, j] = var;
                            var1 = var;
                            break;
                        }
                    }
                }
            }*/
            var random = new Random();
            int var = random.Next(0, 3);
            int var1= random.Next(0, 3);
            calculo[var,var1] = 6000;
            for (int i = 0; i < calculo.GetLength(0); i++)
            {
                for (int j = 0; j < calculo.GetLength(1); j++)
                {
                    if(i!=var && j!=var1) calculo[i, j] = 0;
                }
            }





            return calculo;
        }
        public ret






    }
}
