using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace JavierMidTerm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yes="J";
            int countevent = 0;
            while (yes != "n")
            {
                Student student = new Student();
                string _name_student = student.namestudents();
                string[] _asignatures = student.namesasignatures();
                int[] _grades = student.grades();
                Console.WriteLine("The Student {0}, has this grades", _name_student);
                for (int i = 0; i < _asignatures.Length; i++)
                {
                    Console.WriteLine("in {0}, your grade is: {1}", _asignatures[i], _grades[i]);
                }
                int avg = student.to_Average(_grades);
                int max=student.to_max(_grades);
                string gpa = student.to_gpa(avg);
                string avgstring=avg.ToString();
                string maxstring=max.ToString();
                Console.WriteLine("your average is: " + avgstring);
                Console.WriteLine("your Max Grade is: " + maxstring);
                Console.WriteLine("your GPA is: " + gpa);

                countevent++;
                Console.WriteLine("continue with other student? write y or n");
                yes=Console.ReadLine();

            }
            Console.WriteLine("you process " + countevent + " Students");
            Console.ReadKey();
            
        }
    }
}
