using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Value_1=2001;
            float Value_2=2001;
            int operatorArith=0;
            int value_while = 0;
            float Result = 0;
            
            for (int i = 0;i<2;i++) 
            {
                Console.WriteLine("Write number 1 to 2000 press enter");
                if (Value_1 == 2001)
                {
                    Value_1 = float.Parse(Console.ReadLine());
                }
                else
                {
                    Value_2 = float.Parse(Console.ReadLine());
                }
            }
            while (value_while == 0)
            {
                Console.WriteLine("Write 1 for add,Write 2 for add for rest, Write 3 for add for Mult, Write 4 for Div, Write 5 for Mod");
                operatorArith = int.Parse(Console.ReadLine());
                if (operatorArith > 0 && operatorArith < 6)
                {
                    value_while = 1;
                }
            }
            switch (operatorArith) 
            {
                case 1:
                    Result = Value_1 + Value_2;
                    break;
                case 2:
                    Result = Value_1 - Value_2;
                    break;
                case 3:
                    Result = Value_1 * Value_2; 
                    break;
                case 4:
                    Result = Value_1 / Value_2;
                    break;
                case 5:
                    Result = Value_1 % Value_2;
                    break;
            }
            Console.WriteLine(Result);
            Console.ReadKey();

        }
    }
}
