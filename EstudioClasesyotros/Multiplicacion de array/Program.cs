using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Multiplicacion_de_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int lengh;
            lengh = rnd.Next(1, 21);
            double[] Second = new double[lengh];
            lengh = rnd.Next(1, 21);
            double[] First = new double[lengh];
            for (int i = 0; i < Second.Length; i++) Second[i] = rnd.NextDouble() * rnd.Next(1, 101);
            for (int i = 0; i < First.Length; i++) First[i] = rnd.NextDouble() * rnd.Next(1, 101);
            calculos_array calculos  = new calculos_array();
            var salida_Mayor_menor=calculos.mayor_menor_value(First, Second);
            int Mayor = salida_Mayor_menor.Item1;
            int Menor = salida_Mayor_menor.Item2;
            string MayorIs = salida_Mayor_menor.Item3;
            double[] Third = new double[Mayor];
            for (int i = 0; i < Menor; i++) 
            {
                Third[i] = First[i]*Second[i];
                Console.WriteLine("{0:F2} * {1:F2} = {2:F2}", First[i],Second[i], Third[i]);
            }
            if(Mayor!=Menor)
            {
                for(int i = Menor;i<Mayor;i++)
                {
                    if (MayorIs=="First")
                    {
                        Third[i] = First[i] ;
                        Console.WriteLine("{0:F2} * {1} = {2:F2}", First[i], 1, Third[i]);

                    }
                    else
                    {
                        Third[i] = Second[i];
                        Console.WriteLine("{0} * {1:f2} = {2:f2}", 1, Second[i], Third[i]);
                    }
                }
                Console.ReadKey();
                

            }
            
       
 
 
        }
    }
}
