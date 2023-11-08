using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace page455ex3
{
    internal class MessageBoxshow
    {
        public string Showdata()
        {
            
            Random rnd = new Random();
            int lengh;
            string value1;
            string value2;
            string value3;
            string value4="";
            lengh = rnd.Next(1, 21);
            double[] Second = new double[lengh];
            lengh = rnd.Next(1, 21);
            double[] First = new double[lengh];
            for (int i = 0; i < Second.Length; i++)
            {
                Second[i] = rnd.NextDouble() * rnd.Next(1, 101);
                Second[i] = Math.Round(Second[i], 2);
            }
            for (int i = 0; i < First.Length; i++)
            {
                First[i] = rnd.NextDouble() * rnd.Next(1, 101);
                First[i] = Math.Round(First[i], 2);
            }
            var salida_Mayor_menor = mayor_menor_value(First, Second);
            int Mayor = salida_Mayor_menor.Item1;
            int Menor = salida_Mayor_menor.Item2;
            string MayorIs = salida_Mayor_menor.Item3;
            double[] Third = new double[Mayor];
            for (int i = 0; i < Menor; i++)
            {
                Third[i] = First[i] * Second[i];

                Console.WriteLine("{0:F2} * {1:F2} = {2:F2}", First[i], Second[i], Third[i]);
                value1 = First[i].ToString("F2");
                value2 = Second[i].ToString("F2");
                value3= Third[i].ToString("F2");
                value4 = value4 + value1 + " *  " + value2 +" = "+value3+ "\n";
            }
            if (Mayor != Menor)
            {
                for (int i = Menor; i < Mayor; i++)
                {
                    if (MayorIs == "First")
                    {
                        Third[i] = First[i];
                        value1= First[i].ToString("F2");
                        value2 = Third[i].ToString("F2");
                        value4 = value4+value1 + " * 1 = " + value2 +"\n";
                        

                    }
                    else
                    {
                        Third[i] = Second[i];
                        value1 = Second[i].ToString("F2");
                        value2 = Third[i].ToString("F2");
                        value4 = value4+value1 + " * 1 = " + value2 + "\n";
                    }
                }
                


            }
            return (value4);

            
        }

        public (int, int, string) mayor_menor_value(double[] first, double[] second)
        {
            int mayor = 0;
            int menor = 0;
            string mayoris = "";
            if (first.Length >= second.Length)
            {
                mayor = first.Length;
                menor = second.Length;
                mayoris = "First";

            }
            else
            {
                menor = first.Length;
                mayor = second.Length;
                mayoris = "Second";
            }
            return (mayor, menor, mayoris);
        }
    }
}
