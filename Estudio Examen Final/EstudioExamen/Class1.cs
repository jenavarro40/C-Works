using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EstudioExamen
{
    internal abstract class Variables
    {

        public string[] names;
        

        public Variables(string [] names)
        {
            this.names = names;
        }
    }
}
