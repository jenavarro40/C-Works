using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCodigosdeArea
{
    internal class class_Area_Code
    {
        public int[] input_Area_Code( ) 
        {
            int _exit_n_codes;
            int _area_n_codes;
            while (true)
            {
                Console.WriteLine("Please input the number of area code:");
                if (int.TryParse(Console.ReadLine(), out _exit_n_codes) == false)
                {
                    Console.WriteLine("Wrong number please try again");
                }
                else
                {
                    break;
                }

            }
            int[] areas_code=new int[_exit_n_codes];

            for (int i=0; i < areas_code.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine("Please input the {0} area code", i);
                    if (int.TryParse(Console.ReadLine(), out _area_n_codes) == false)
                    {
                        Console.WriteLine("Wrong number please try again");
                    }
                    else
                    {
                        areas_code[i] = _area_n_codes;
                        break;
                    }
                }
            }
            Console.Clear();
            return areas_code;
        }
        public void check_area_code(int[] area_code_input)
        {
            int _exit_test_codes = -1;
            
            Boolean test=true;
            while (_exit_test_codes != 0)
            {
                while (true)
                {
                    Console.WriteLine("Please input the Area code to check or write 0 to exit");
                    if (int.TryParse(Console.ReadLine(), out _exit_test_codes) == false)
                    {
                        Console.WriteLine("Wrong number please try again");
                    }
                    else
                    {
                        break;
                    }
                }

                foreach (var code in area_code_input)
                {
                    if (code == _exit_test_codes)
                    {
                        Console.WriteLine("Is a Valid Code");
                        test = false;
                        break;
                    }
                    else
                    {
                        test = true;
                    }

                }
                if (test == true)
                {
                    if (_exit_test_codes == 0)
                    {
                        Console.WriteLine("bye, see you later");
                        break;
                    }
                    Console.WriteLine("Is not Valid Code");
                }
            }
        }
    }

}
