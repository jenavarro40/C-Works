using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itheranceestudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            secundaria sec=new secundaria();
            
            sec.mainpin();
            sec.mainpin2();
            int val= sec.emasita(); 
            Console.WriteLine(val);
            int val1 = 10;
            int val2 = 15;

            secundaria2 sec2=new secundaria2(val1,val2);

            val1 = 3;
            val2 = 1;

            sec2=new secundaria2 (val1, val2);
            for (int i = 0; i < 10; i++)
            {
                int a = sec2.suma();
                Console.WriteLine(a);
            }
            int b=sec2.suma2 ();
            Console.WriteLine(b);
            
    
            Console.ReadKey();
        }
    }
}
