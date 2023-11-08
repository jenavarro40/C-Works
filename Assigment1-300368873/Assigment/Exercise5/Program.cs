using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            System.Threading.Thread.CurrentThread.CurrentCulture= new CultureInfo("en-US");
            string employeeName = "Joshua Montain";
            decimal sales_1 = 161432.00M;
            decimal sales_2 = 1300000.00M;
            decimal gross = 0M;
            decimal incom = 0M;
            decimal Tax = 0M;
            decimal Retirement = 0M;
            decimal Social = 0M;

            Calculate_employee_gain(ref sales_1, ref gross, ref incom, ref Tax, ref Retirement, ref Social);
            print_info(ref employeeName,ref sales_1, ref gross, ref incom, ref Tax, ref Retirement, ref Social);

            Console.WriteLine("************");
            

            Calculate_employee_gain(ref sales_2, ref gross, ref incom, ref Tax, ref Retirement, ref Social);
            print_info(ref employeeName, ref sales_2, ref gross, ref incom, ref Tax, ref Retirement, ref Social);


            Console.WriteLine("Hello World");
            Console.ReadKey();

        }
        static void Calculate_employee_gain(ref decimal sales, ref decimal gross_proffit,ref decimal net_incoming,ref decimal tax,ref decimal retirement,ref decimal social)
        {
            gross_proffit = sales * 0.07M;
            tax = gross_proffit * 0.18M;
            retirement = gross_proffit * 0.1M;
            social = gross_proffit * 0.06M;
            net_incoming = gross_proffit - tax - retirement - social;
        }
        static void print_info(ref string name_em,ref decimal sales, ref decimal gross_proffit, ref decimal net_incoming, ref decimal tax, ref decimal retirement, ref decimal social)
        {
             
            Console.WriteLine("Employ Name: " +name_em);
            Console.WriteLine("Sales: {0:C} ",sales);
            Console.WriteLine("Comission: {0:F2}" , gross_proffit);
            Console.WriteLine("Taxes: {0:F2}" , tax);
            Console.WriteLine("retirement program: {0:F2}", retirement);
            Console.WriteLine("Social Security: {0:F2}" , social);
            Console.WriteLine("Total TakeHome {0:C}: ",net_incoming);
        }

    }
}
