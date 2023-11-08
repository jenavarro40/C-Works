using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World " + (mymethod1() + mymethod2()));
            ReadKey();
        }
        static int mymethod1() { return 1; }

        static int mymethod2() { return 2; }
        
    }
}
