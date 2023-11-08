using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inputs_data
{
    internal class Inputs_data_all
    {
        public double Data_Input_Double() 
        {
            Boolean validate=false;
            double input=0;

            while (!validate)
            {

                string input_string = Console.ReadLine();
                if (double.TryParse(input_string,out input))
                {
                    validate = true;
                }
                else
                {
                    Console.WriteLine("The Value {0} is not valid try again", input_string);
                }
            }
            return input;
        }
        public string Data_Input_String() 
        {
            string input_string = Console.ReadLine();
            return input_string;
        }
    }
}