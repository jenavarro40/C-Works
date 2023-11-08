using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classess
{
    internal class Clases_in_U
    {
        public int input_clases()
        {
            int _number_of_class;
            while (true)
            {
                Console.WriteLine("Please Input Number of Clases:");
                if (int.TryParse(Console.ReadLine(), out _number_of_class) == false)
                    Console.WriteLine("Wrong Data TryAgain");
                else
                {
                    if (_number_of_class > 0 & _number_of_class < 21)
                    {
                        break;
                    }
                    else
                        Console.WriteLine("Exceed Number of Class Try again");

                    
                }
            }
        Console.Clear();
        return _number_of_class;
        }
        public (string[], int[], int[]) ingress_data(int _number_of_class)
        {
            string[] curso= new string[_number_of_class];
            int[] actual_student= new int[_number_of_class];
            int[] Number_seats= new int[_number_of_class];
            int exit;
            for (int i=0; i<_number_of_class; i++)
            {

                Console.WriteLine("Write Subject Code:"); 
                curso[i] = Console.ReadLine();
                while (true)
                {
                    Console.WriteLine("Write Number of seats:");
                    if (int.TryParse(Console.ReadLine(), out exit) == false)
                        Console.WriteLine("Wrong Data TryAgain");
                    else
                    {
                        Number_seats[i] = exit;
                        break;
                    }
                }
                while(true)
                { 
                    Console.WriteLine("Write Number of students:");
                    if (int.TryParse(Console.ReadLine(), out exit) == false)
                        Console.WriteLine("Wrong Data TryAgain");
                    else
                    {
                        if (exit <= Number_seats[i])
                        {
                            actual_student[i] = exit;
                            break;
                        }
                        else Console.WriteLine("Wrong Data TryAgain");
                    }


                }
                    

            }
            Console.Clear();
            return(curso, actual_student,Number_seats);
        }

            
 
                    

    }
}
