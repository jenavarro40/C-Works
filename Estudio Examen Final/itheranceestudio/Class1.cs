using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itheranceestudio
{
    internal abstract class principal
    {
        public int num1;
        public int num2;
        public int num3;
        public abstract void mainpin();
        public abstract void mainpin2();
        public virtual int emasita()
        {
            Console.WriteLine("ejem");
            return 0;
        }
      

    }
}
