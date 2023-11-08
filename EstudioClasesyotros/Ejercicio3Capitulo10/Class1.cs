using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Capitulo10
{
    internal class CalcularPrecio
    {
        public double precioComponentes(double ski,double googles,double glooves,double Earmufs,double clothes)
        {
            double precio = ski + googles + glooves + Earmufs + clothes;
            return precio;
        }
    }
}
