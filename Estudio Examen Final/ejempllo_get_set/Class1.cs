using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejempllo_get_set
{
    internal class getsetejemplo
    {
        private int numero = 0;
        public int salida
        {
            get
            { 
                return numero;
            
            }

            set
            {
                
                if (value > 300) 
                {
                    
                    Console.WriteLine("Reescriba");
                }
                else
                {
                    numero = value;
                }
                
            }
        }
       
    }
}
