using System;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using static System.Console;
 namespace ExerciseI
 {
     class Problem2
    {
        static void Main()
        {
            int value1 = 1, value2 = 18, value3 = 2, value4 = 4;
            int ans = value1 + value2 / value3 * value4 -- ;
            WriteLine(ans);

            ans = 0;
            int v1 = 10, v2 = 19;
            ans = v2 % v1++;

            WriteLine(ans);

            value1 = 1; value2 = 17; value3 = 2; value4 = 4;
            ans = value1 + value2 % 9 / value3 * value4--;
            WriteLine(ans);
            
            int intValue = 0;
            decimal AVALUE= 67M;
            

            WriteLine("Result is {0:c}", 67);
            Write("Number {0:f0} is {1:c}", 1, 3);
            WriteLine(intValue+"\n" +AVALUE);
            Write("{0,-10:f0}–{1,10:c}", 1, 3 * 2 );
            ReadLine();
        }
        }
 }
