using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area
{
    internal class figures
    {
        public void Rectangule() 
        {
            int height;
            int width;
            while (true) 
            {
                Console.WriteLine("Write Height:");
                if (int.TryParse(Console.ReadLine(), out height) == false) Console.WriteLine("Wrong data try Again");
                else break;
            }

            while (true)
            {
                Console.WriteLine("Write Widht:");
                if (int.TryParse(Console.ReadLine(), out width) == false) Console.WriteLine("Wrong data try Again");
                else break;
            }
            int area = height * width;
            Console.WriteLine("The area for Height "+height+" and Width "+width+ " is:  "+area);

        }
        public void circle()
        {
            int rad;
            while (true)
            {
                Console.WriteLine("Write Radio:");
                if (int.TryParse(Console.ReadLine(), out rad) == false) Console.WriteLine("Wrong data try Again");
                else break;
            }
            double area = Math.PI*Math.Pow(rad, 2);
            Console.WriteLine("The area for Radius{0} is: {1:f2}",rad,area);
        }
        public void circle2() 
        {
            int height;
            int rad;
            while (true)
            {
                Console.WriteLine("Write Height:");
                if (int.TryParse(Console.ReadLine(), out height) == false) Console.WriteLine("Wrong data try Again");
                else break;
            }

            while (true)
            {
                Console.WriteLine("Write Radius:");
                if (int.TryParse(Console.ReadLine(), out rad) == false) Console.WriteLine("Wrong data try Again");
                else break;
            }
            double area = (2*Math.PI*height*rad)+(2 * Math.PI * Math.Pow(rad, 2));
            Console.WriteLine("The surface area for Height {0} and Radius {1} is: {2:f2} ",height,rad,area);

        }
    }
}
