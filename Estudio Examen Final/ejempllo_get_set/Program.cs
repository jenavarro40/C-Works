using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejempllo_get_set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            getsetejemplo outsal = new getsetejemplo();
            outsal.salida = 200;
            int val=outsal.salida;
            Console.WriteLine(val);
            Console.ReadKey();
        }
    }
}
