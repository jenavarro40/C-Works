using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classtwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1,2,4
            //1. Obtain the average
            int number1 = 1;
            int number2 = 2;
            int number3 = 4;
            double result1;
           
            //2. do the caculation
            result1 = (double)(number1 + number2 + number3)/3;
            //3. outbut
            Console.WriteLine("result:" + result1);
            Console.WriteLine("Hello World");
            Console.ReadKey();

            // other part of the explanation

            int testnun1 = 10;
            double testnun2 = 20.2;
            //posible
            testnun2 = testnun1;
            //Not posible
            //testnun1 = testnun2;
            //do this
            testnun1 =(int)testnun2;
            Console.WriteLine("result:" + testnun2 + " " + testnun1);
            //Way to diferent write 
            Console.WriteLine("{0}+{1}+{2}/3={3}",number1,number2,number3,result1);
            Console.WriteLine("{0}+{1}+{2}/3={3,-40:F2}??", number1, number2, number3, result1);
            Console.WriteLine("{0}+{1}+{2}/3={3,40:F2}??", number1, number2, number3, result1);
            Console.ReadKey();

        }
    }
}
