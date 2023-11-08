using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itheranceestudio
{
    internal class secundaria:principal
    {

        public override void mainpin() 
        {
            Console.WriteLine("Medio Entendi");
        }
        public override void mainpin2()
        {
            Console.WriteLine("Medio Entendi esto que estoy estudiando");
        }
        public override int emasita()
        {
            base.emasita();
            Console.WriteLine("ejem * 2");
            return 10;
        }
       
    }
}
