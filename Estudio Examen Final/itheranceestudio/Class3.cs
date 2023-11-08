using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itheranceestudio
{
    internal abstract class principal2
    {
        public int num1;
        public int num2;
        public int num3;
        
        public principal2(int num1,int num2)
        {
            
            this.num1 = num1;
            this.num2 = num2;
            num3 = num1+num2;


        }
        public virtual int suma()
        {
            
            
            return num3;
        }


    }
}
