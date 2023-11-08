using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintShape
{
    internal class Shapes
    {

        public void Draw_Shapes_Diamant(int number)
        {
            int number_Vacios = number - 1;
            int number_llenos = 1;
            for (int i = 0; i < number; i++)
            {

                if (number_Vacios != 0)
                {
                    for (int j = 0; j < number_Vacios; j++) Console.Write(" ");
                    for (int j = 0; j < number_llenos; j++) Console.Write("*");
                    for (int j = 0; j < number_Vacios; j++) Console.Write(" ");

                }
                else for (int j = 0; j < number_llenos; j++) Console.Write("*");
                number_Vacios--;
                number_llenos = number_llenos + 2;
                Console.Write("\n");
            }

            number_Vacios = 1;
            number_llenos = number_llenos - 4;
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number_Vacios; j++) Console.Write(" ");
                for (int j = 0; j < number_llenos; j++) Console.Write("*");
                for (int j = 0; j < number_Vacios; j++) Console.Write(" ");
                number_Vacios++;
                number_llenos = number_llenos - 2;
                Console.Write("\n");
            }



        }
        public void Enlarge(out int firstnumber, out int secondnumber, out int thirdnumber)
        {
            
            Console.WriteLine("Please write the first number of shape half height greater than 3 minor 13");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out firstnumber) == false) Console.WriteLine("Wrong Format Try Again ");
                else
                {
                    if (firstnumber <= 3 || firstnumber > 13) Console.WriteLine("wrong number try again");
                    else break;

                }
            }
            Console.WriteLine("Please write the first number of shape half height greater than " + firstnumber + " minor 14");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out secondnumber) == false) Console.WriteLine("Wrong Format Try Again ");
                else
                {
                    if (secondnumber <= firstnumber || secondnumber > 14) Console.WriteLine("wrong number try again");
                    else break;

                }
            }
            Console.WriteLine("Please write the first number of shape half height greater than " + secondnumber + " minor 15");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out thirdnumber) == false) Console.WriteLine("Wrong Format Try Again ");
                else
                {
                    if (thirdnumber <= secondnumber || thirdnumber > 15) Console.WriteLine("wrong number try again");
                    else break;

                }
            }
            Console.Clear();

        }
    }
}
