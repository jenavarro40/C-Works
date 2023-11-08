using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RomanosFacil
{
    internal class RomanosFaciles
    {
        public decimal EntradaDecimal()
        {
            Boolean error = false;
            decimal val=0;
            while(!error)
            {
                Console.WriteLine("write number from 1 to 10: ");
                
                if(decimal.TryParse(Console.ReadLine(), out val))
                {
                    if (val>0 & val<11 & val%1==0)
                    {
                        
                        error = true;
                    }
                    else
                    {
                        Console.WriteLine("Out of Range");
                    }
                    

                }
                else
                {
                    Console.WriteLine("Wrong Number");
                }
            }
            return val;
   

        }
        public void Cambio_a_romanos(decimal InputDecimal,out string romanNumber )
        {
            romanNumber = " ";
            switch (InputDecimal)
            {
                case 1:romanNumber = "I"; break;   
                case 2:romanNumber = "II"; break;   
                case 3:romanNumber = "III"; break;
                case 4:romanNumber = "IV"; break;
                case 5:romanNumber = "V"; break;
                case 6:romanNumber = "VI"; break;
                case 7:romanNumber = "VII"; break;
                case 8:romanNumber = "VIII"; break;
                case 9:romanNumber = "IX"; break;
                case 10:romanNumber= "X"; break;
            }
        }
    }
}
