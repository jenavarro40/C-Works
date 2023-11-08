using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            int third;
            Shapes Shape=new Shapes();
            Shape.Enlarge(out first, out second, out third);
            Shape.Draw_Shapes_Diamant(first);
            Console.WriteLine("Enlarge 1");
            Shape.Draw_Shapes_Diamant(second);
            Console.WriteLine("Enlarge 2");
            Shape.Draw_Shapes_Diamant(third);
            Console.ReadKey();
            
        }
    }
}
