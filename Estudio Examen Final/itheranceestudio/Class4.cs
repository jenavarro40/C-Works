using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itheranceestudio
{
    internal class secundaria2 : principal2,Idata
    {
        
        public secundaria2(int num1, int num2) : base(num1, num2)
        {
            int num3 = num1 + num2;
            Console.WriteLine(num3);
        }
        public override int suma()

        {
            base.suma();
            int a=0;
            a++;
            return a;
        }
        public int suma2() 
        {
            return num3;
        }
        double Idata.javier() 
        { 
            return num3; 
        }
        int Idata.sara() 
        { 
            return num3;
        }

    }
}
