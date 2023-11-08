using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProgram
{
    internal class input_process_data
    {
        public void input_sales_month(string[] months, decimal[] Sales)
        {
            for (int i = 0; i < months.Length; i++)
            {
                
                while (true)
                {
                    Console.WriteLine("Input " + months[i] + " Sales");
                    if ((decimal.TryParse(Console.ReadLine(), out Sales[i])) == false)
                    {
                        Console.WriteLine("Input error Try Again");
                    }
                    else
                    {

                        break;


                    }

                }
            }
            
        }
        public decimal[] porcentajes(decimal[] Sales)
        {
            decimal[] Porcenta_value = new decimal[Sales.Length];
            decimal anual_sales = 0M;
            foreach (int vSales in Sales)
            {
                anual_sales += vSales;
            }
            for (int i = 0; i < Porcenta_value.Length; i++)
            {
                Porcenta_value[i] =  Sales[i]/anual_sales;
            }
            return (Porcenta_value);
        }
    }
}
