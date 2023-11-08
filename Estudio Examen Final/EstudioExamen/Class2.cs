using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioExamen
{
    internal class Variables2:Variables

    {
        string[] names_val;
        public Variables2(string[] names) : base(names) 
        {  
            this.names_val = names;
        }
        public (int,string,string,double,int) pianos()
        {

            int ID = int.Parse(names[0]);
            string brand  = names[1];
            string serie = names[2];
            double price = double.Parse(names[3]);
            int year = int.Parse(names[4]);

            return (ID, brand, serie, price, year);
        }
    } 
}
