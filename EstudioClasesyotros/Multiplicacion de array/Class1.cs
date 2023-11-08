using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicacion_de_array
{
    internal class calculos_array
    {
        public (int,int,string) mayor_menor_value(double[] first,double[] second)
        {
            int mayor=0;
            int menor=0;
            string mayoris = "";
            if (first.Length>=second.Length) 
            {
                mayor=first.Length;
                menor=second.Length;
                mayoris = "First";
                
            }
            else
            {
                menor = first.Length;
                mayor = second.Length;
                mayoris = "Second";
            }
            return (mayor,menor,mayoris);
        }
    }
}
