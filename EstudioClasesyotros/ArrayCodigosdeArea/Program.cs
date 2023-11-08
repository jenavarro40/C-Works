using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ArrayCodigosdeArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            class_Area_Code areacode=new class_Area_Code();
            int[] Area_Code = areacode.input_Area_Code();
            Console.WriteLine("The area Code are:");
            foreach (int code in Area_Code) 
            {
               
                Console.Write(code + "\t");
            }
            
            Console.ReadKey();

            Console.Clear();

               
           areacode.check_area_code(Area_Code);
                
        


            int[] Area_Code1=new int[Area_Code.Length];

            Area_Code1 = (int[])Area_Code.Clone();


            Array.Sort(Area_Code1);


            foreach (int code in Area_Code) 
            {
                Console.Write("(+"+ code + ")\t");
            }

            

            Console.WriteLine("\n In order");

            foreach (int code1 in Area_Code1)
            {
                Console.Write("(+"+ code1 + ")\t");
            }

            Console.ReadKey();

        }
    }
}
 