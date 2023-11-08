using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incoming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            _Profit_Incoming profit_Incoming = new _Profit_Incoming();
            decimal sales = profit_Incoming.Input_Profit_Incoming();
            decimal porcentaje = profit_Incoming.Output_Profit_Incoming(sales);
            decimal profit = sales * porcentaje;
            Console.WriteLine(" The Sales are: {0:C}\n The profit porcentage is: {1:P1}\n The profit is: {2:C}\n The Cost is: {3:C}", sales,porcentaje,profit,(sales-profit));
            Console.ReadLine();
        }
    }
}
