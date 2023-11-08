using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            decimal[] values = new decimal[12];
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            input_process_data _Data = new input_process_data();
            _Data.input_sales_month(months,values);
            decimal[] Porcent= new decimal[12];
            Porcent=_Data.porcentajes(values);
            for (int i=0;i<Porcent.Length;i++)
            {
                Console.WriteLine( "The Sales in {0} are: {1:C} and weight in total sales are {2:P} ",months[i], values[i], Porcent[i]);
            }
            Console.ReadKey();
            
        }
    }
}
