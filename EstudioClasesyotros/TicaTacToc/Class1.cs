using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;                                                                                                                      

namespace TicaTacToc
{
    internal class TicTac

    {
        public char[] valXO = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public int[] val_X = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] val_O = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public void Dibuje_Cuadricula()
        {
            
            Console.WriteLine("        *     *           ");
            Console.WriteLine("     {0}  *  {1}  *  {2}        ",valXO[0],valXO[1],valXO[2]);
            Console.WriteLine("        *     *           ");
            Console.WriteLine("   ******************     ");
            Console.WriteLine("     {0}  *  {1}  *  {2}        ", valXO[3], valXO[4], valXO[5]);
            Console.WriteLine("        *     *           ");
            Console.WriteLine("   ******************     ");
            Console.WriteLine("     {0}  *  {1}  *  {2}        ", valXO[6], valXO[7], valXO[8]);
            Console.WriteLine("        *     *           ");
            Console.WriteLine("        *     *           ");
        }
        public (int[]val_X,int[]val_O) realize_cambios(int i)
        {
            
            Console.WriteLine("Ingrese Numero Jugador {0}:", i+1, "Ingrese Enter");
            string input_key = Console.ReadLine();
            if ( i== 0)  
            { 
                valXO[int.Parse(input_key) -1 ] = 'X';
                val_X[int.Parse(input_key) - 1] = 1;
                Console.Clear();
                Dibuje_Cuadricula();
                
            } 
            else 
            { 
                valXO[int.Parse(input_key) -1]= 'O';
                val_O[int.Parse(input_key) - 1] = 1;
                Console.Clear();
                Dibuje_Cuadricula();
            }
            
            return (val_X,val_O) ;


        }
    }
}
