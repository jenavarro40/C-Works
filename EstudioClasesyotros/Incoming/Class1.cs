using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incoming
{
    internal class _Profit_Incoming
    {
        internal decimal Input_Profit_Incoming()
        {

            Boolean error = true;
            decimal sales = 0;
            while (error) //Input the data if the data has a issue you bring it again
            {
                
                Console.WriteLine("Please Input Sales: ");
                if(decimal.TryParse(Console.ReadLine(), out sales)) 
                {
                    if (sales>0)
                    {
                        error = false;
                    }
                    else
                    {
                        Console.WriteLine("The input has a error please try again");
                    }

                }
                else
                {
                    Console.WriteLine("The input has a error please try again");
                }
                
            }
            return sales;
        }
        internal decimal Output_Profit_Incoming(decimal sales)            
        { 
            decimal porcentaje= 0;
            switch (sales) 
            {
                case var sales1 when sales1 > 0 & sales1<= 1000 : porcentaje = 0.03M; break;
                case var sales1 when sales1 > 1000 & sales1 <= 5000: porcentaje = 0.035M; break;
                case var sales1 when sales1 > 5000 & sales1 <= 10000: porcentaje = 0.04M; break;
                default: porcentaje = 0.045M; break;
            }
            return porcentaje;

        }

    }
}
