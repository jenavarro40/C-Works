using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Feet_Output;
            double Inch_Output;
            double DataIngress = insertdata();
            calculatechange(ref DataIngress, out Feet_Output, out Inch_Output);
            impress_answer(ref DataIngress,ref Feet_Output, ref Inch_Output);
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
        static double insertdata()
        {
            Console.WriteLine("Write the Value in meters");
            double dataingress=double.Parse(Console.ReadLine());
            return dataingress;
        }
        static void calculatechange(ref double dataingress,out double feet_output, out double inch_output)
        {
            feet_output = Math.Truncate(dataingress * 3.2808);
            inch_output = (dataingress * 3.2808)-(Math.Truncate(dataingress * 3.2808));
            inch_output = Math.Round(inch_output*12,2);

        }
        static void impress_answer(ref double dataingress,ref double feet_output, ref double inch_output)
        {
            Console.WriteLine("{0:F2} Meters is equivalent to {1:f0} Feets, and {2:f2} Inches",dataingress,feet_output,inch_output);
        }
    }
}
