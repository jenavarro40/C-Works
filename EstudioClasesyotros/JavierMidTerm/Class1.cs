using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JavierMidTerm
{
    internal class Student
    {
        public string namestudents()
        {
            string name_student;
            while (true)
            {

                Console.WriteLine("Write Name of Student?");
                name_student = Console.ReadLine();
                if (name_student == null || name_student.Length > 20) { Console.WriteLine("try again"); }
                else { break; }
            }



            return name_student;
        }
        public string[] namesasignatures()
        {
            string[] asignatures = new string[3];
            for (int i = 0; i < asignatures.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine("Write Name of  " +(i+1) + "  Asignature");
                    asignatures[i] = Console.ReadLine();
                    if (asignatures[i] == null || asignatures[i].Length > 20) Console.WriteLine("try again");
                    else break;

                }

            }

            return asignatures;
        }
        public int[] grades()
        {
            int[] grades_value = new int[3];
            for (int i = 0; i < grades_value.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine("Please insert Grade  " + (i + 1) + "  asignature");
                    if (int.TryParse(Console.ReadLine(), out grades_value[i]) == false) Console.WriteLine("incorrect format try again");
                    else
                    {
                        if (grades_value[i] < 0 | grades_value[i] > 100) Console.WriteLine("incorrect value try again");
                        else break;
                    }
                }

            }
            return grades_value;


        }
        public int to_Average(int[] _grades)
        {
            int avg = 0;
            for (int i = 0; _grades.Length > i; i++)
            {
                avg = avg + ((int)_grades[i]);
            }
            avg=avg/_grades.Length;
            return avg;
        }
        public int to_max(int[] _grades)
        {
            int max = 0;
            for (int i = 0; i < _grades.Length; i++)
            {
                if (max < _grades[i])
                    max = _grades[i];


            }
            return max;
        }
        public string to_gpa(int avg)
        {
            string finalgrade;
            if (avg < 50)
            {
                finalgrade = "F";
            }
            else if (avg >= 50 & avg < 65)
            {
                finalgrade = "P";
            }
            else if (avg >= 65 & avg < 75)
            {
                finalgrade = "C";
            }
            else if (avg >= 75 & avg < 85)
            {
                finalgrade = "B";
            }
            else if (avg >= 85 & avg < 95)
            {
                finalgrade = "A";
            }
            else
            {
                finalgrade = "A+";
            }
            return finalgrade;
        }

    }
}
