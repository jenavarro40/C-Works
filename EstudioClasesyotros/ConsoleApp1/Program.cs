using classess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clases_in_U clases= new Clases_in_U();
            int number_class = clases.input_clases();
            Console.WriteLine(number_class);

            var output = clases.ingress_data(number_class);
            string[] curso = output.Item1;
            int[] seats = output.Item3;
            int[] Student=output.Item2;


            Console.WriteLine("Curso\tTotal Seats\tTotal Students");
            for (int i = 0; i < number_class; i++) 
            {
                Console.WriteLine(curso[i]+"\t"+ seats[i].ToString()+"\t\t"+ Student[i].ToString());
            }
            Console.ReadKey();

        }
    }
}
