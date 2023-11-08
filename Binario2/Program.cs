using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binario2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Insert Binary Value check the value is binary

            string Bin_Val_String = "";
            ingress_binary(ref Bin_Val_String);

            //2. divide the value in groups of 4 
            string Bin_Val = "";
            Procedure_binary(ref Bin_Val_String, ref Bin_Val);





            //5. print the value
            Console.WriteLine(Bin_Val);

            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
        static void ingress_binary(ref string bin_val_string)
        {
            //string bin_val_string="";
            int count_bin = 0;
            int count_while1 = 0;
            int count_if = 0;
            double count_pow=0;
            int variable1 = 0;
            int variable2 = 0;
            while (count_while1 == 0)
            {
                Console.WriteLine("Write the Binary Number and press enter");
                bin_val_string = Console.ReadLine();
                count_bin = bin_val_string.Length;
                count_pow = count_bin-1;
                int count_while2 = 0;
                while (count_while2 == 0)
                {
                    if (count_if <= count_bin - 1)
                    {
                        if ((int.Parse(bin_val_string.Substring(count_if, 1)) == 0 || int.Parse(bin_val_string.Substring(count_if, 1)) == 1))
                        {

                            
                            variable1 =(int)(int.Parse(bin_val_string.Substring(count_if, 1)) * (Math.Pow(2, count_pow)));
                            variable2 = variable1 + variable2;
                            count_if++;
                            count_pow=count_pow - 1.0;

                        }
                        else
                        {
                            count_while2 = 1;

                            if (count_if > count_bin - 1)
                            {
                                count_while1 = 1;
                            }
                            else
                            {
                                Console.WriteLine("input erronuos plese enter again");
                            }

                            count_if = 0;


                        }
                    }
                    else
                    {

                        count_while1 = 1;
                        count_while2 = 1;

                    }

                }
            }

            string variable3=Convert.ToString(variable2, 16);
            Console.WriteLine(variable2);
            Console.WriteLine(variable3);
        }
        //Empezar con otro method
        static void Procedure_binary(ref string bin_val_string_1, ref string bin_val)
        {
            int count_bin = bin_val_string_1.Length;

            int j = 1;
            string[] strings_4bits = new string[count_bin];
            int Number_of_4bits = count_bin / 4;
            int bit_rest = count_bin % 4;
            int i = 1;
            for (i = 1; i <= Number_of_4bits; i++)
            {
                strings_4bits[j] = bin_val_string_1.Substring(count_bin - (4 * i), 4);

                j = j + 1;

            }

            //3. complete with 0 convert to decimal the groups of 4
            if (bit_rest == 0)
            {
                j = 0;

            }

            else
            {

                strings_4bits[j] = bin_val_string_1.Substring(0, bit_rest);
                switch (bit_rest)
                {
                    case 1:
                        strings_4bits[j] = "000" + strings_4bits[j]; break;
                    case 2:
                        strings_4bits[j] = "00" + strings_4bits[j]; break;
                    case 3:
                        strings_4bits[j] = "0" + strings_4bits[j]; break;
                }
                ;

            }
            i = 0;
            j = count_bin - 1;
            string Hexa_number = "The hexa Number is: 0x";
            //4. Case for the 15 values
            for (i = 0; i < count_bin - 1; i++)
            {
                switch (strings_4bits[j])
                {
                    case "0000": Hexa_number = Hexa_number + "0"; break;
                    case "0001": Hexa_number = Hexa_number + "1"; break;
                    case "0010": Hexa_number = Hexa_number + "2"; break;
                    case "0011": Hexa_number = Hexa_number + "3"; break;
                    case "0100": Hexa_number = Hexa_number + "4"; break;
                    case "0101": Hexa_number = Hexa_number + "5"; break;
                    case "0110": Hexa_number = Hexa_number + "6"; break;
                    case "0111": Hexa_number = Hexa_number + "7"; break;
                    case "1000": Hexa_number = Hexa_number + "8"; break;
                    case "1001": Hexa_number = Hexa_number + "9"; break;
                    case "1010": Hexa_number = Hexa_number + "A"; break;
                    case "1011": Hexa_number = Hexa_number + "B"; break;
                    case "1100": Hexa_number = Hexa_number + "C"; break;
                    case "1101": Hexa_number = Hexa_number + "D"; break;
                    case "1110": Hexa_number = Hexa_number + "E"; break;
                    case "1111": Hexa_number = Hexa_number + "F"; break;
                }
                j--;
            }
            bin_val = Hexa_number;



        }

    }
}