using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudiobasico
{
    delegate string ReturnsSimpleString();
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 11;
            string gusta = "me gusta";
            ReturnsSimpleString saying3 = new ReturnsSimpleString(EndStatement);
            ReturnsSimpleString saying2 = new ReturnsSimpleString((c+10).ToString);
            string javier = saying3();

            Console.WriteLine(saying2() + javier);
            Console.ReadKey();
        }
        
        static string EndStatement()
        {
            return " in 10 years."; 
        }
    }
}
