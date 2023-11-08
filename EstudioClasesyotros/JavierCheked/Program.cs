using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            notes_course notes = new notes_course();
            var data = notes.data_students();
            int[] data1 = data.Item3;
            int[] data2 = data.Item4;
            int[] data3 = data.Item5;
            string[] classes = data.Item2;
            string name = data.Item1;
            string not;



            Console.WriteLine("name subject grade1 grade2 grade3 avg gradefinal max");
            Console.Write(name + "\t" + classes[0] + "\t");
            var promedio = notes.avg(data1);
            notes.print(data1, promedio.Item2, promedio.Item3, promedio.Item1);
            Console.Write(name + "\t" + classes[1] + "\t");
            promedio = notes.avg(data2);
            notes.print(data2, promedio.Item2, promedio.Item3, promedio.Item1);
            Console.Write(name + "\t" + classes[2] + "\t");
            promedio = notes.avg(data3);
            notes.print(data3, promedio.Item2, promedio.Item3, promedio.Item1);

            Console.WriteLine("Enter To continue");
            Console.ReadKey();

            do
            {
                var otro = notes.Read();
                Console.WriteLine("name subject grade1 grade2 grade3 avg  gradefinal max");
                Console.Write(otro.Item2 + "\t" + otro.Item3 + "\t");
                promedio = notes.avg(otro.Item1);
                notes.print(otro.Item1, promedio.Item2, promedio.Item3, promedio.Item1);

                Console.WriteLine("Do you Want enter other student? write y or n");
                not = Console.ReadLine();
            } while (not != "n");





        }
    }
}
