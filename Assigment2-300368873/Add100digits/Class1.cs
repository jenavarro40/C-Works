using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add100digits
{
    internal class add100digits
    {
        Random random = new Random();
        int[,] Numberstoadd = new int[2, 100];

        public int[,] Ingresar()
        {
            for(int i=0;i<Numberstoadd.GetLength(0);i++)
            {
                for (int j = 0; j < Numberstoadd.GetLength(1); j++)
                {

                    if (j==0) Numberstoadd[i, j] = random.Next(1, 9);
                    else Numberstoadd[i, j] = random.Next(0, 9);
                }
                
            }
            return Numberstoadd;
        }
      

    }

}
