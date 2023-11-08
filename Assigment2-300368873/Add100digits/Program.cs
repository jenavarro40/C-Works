using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add100digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            add100digits digits = new add100digits();
            int[,] numerosadd = digits.Ingresar();
            int[] result=new int[numerosadd.GetLength(1)];
            
          
            

            int add=0;
            int llevo = 0;
            for (int i = 0; i < numerosadd.GetLength(0); i++)
            {
                Console.WriteLine("Number"+(i+1));
                for (int j = 0; j < numerosadd.GetLength(1); j++)
                {
                    Console.Write(numerosadd[i, j]);
                }
                Console.Write("\n");
            }
            for (int i = numerosadd.GetLength(1)-1; i >-1 ; i--) 
            {
                add = 0;
                for(int j =0; j < numerosadd.GetLength(0); j++)
                {
                    add =llevo+ add + numerosadd[j, i];
                    if (add > 9 && j==1)
                    {
                        if (i > 0)
                        {
                            llevo = 1;
                            add = add - 10;
                        }
                    }
                    else llevo = 0;
                    

                }
                result[i] = add;



            }
            Console.WriteLine("Result is:");
            foreach (int var in result) Console.Write(var);

            Console.ReadKey();
        }
    }   
}
