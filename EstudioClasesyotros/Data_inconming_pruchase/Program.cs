using Inputs_data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_inconming_pruchase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the original Cost ");
            Inputs_data_all inputs = new Inputs_data_all();
            double input_purchase_house = inputs.Data_Input_Double();
            Console.WriteLine("Please input the year of construction ");
            double input_year_house=inputs.Data_Input_Double();
            Console.WriteLine("Please input the  the Adress ");
            string adress = inputs.Data_Input_String();
            Console.WriteLine("The Value Earning is : " + input_purchase_house);
            Console.WriteLine("The year of construction " + input_year_house);
            Console.WriteLine("The Adress is :/n " + adress);

            Console.ReadLine();
     
            
        }
    }
}