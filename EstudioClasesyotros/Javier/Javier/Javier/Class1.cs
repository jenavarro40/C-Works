using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Javier
{


    internal class notes_course
    {
        public (string, string[], int[], int[], int[]) data_students()
        {
            string Name = "Javier";
            string[] Subject = { "s1", "s2", "s3" };
            int[] Notes1 = { 70, 75, 90 };
            int[] Notes2 = { 10, 10, 10 };
            int[] Notes3 = { 10, 10, 10 };

            return (Name, Subject, Notes1, Notes2, Notes3);
        }

        public (string, double, double) avg(int[] _Avg)
        {
            double avg = 0;
            double max = 0;
            string finalgrade = "";
            for (int i = 0; i < _Avg.Length; i++)

            {
                avg = avg + _Avg[i];
                if (max < _Avg[i]) max = _Avg[i];
            }
            avg = avg / _Avg.Length;
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


            return (finalgrade, avg, max);
        }
        public void print(int[] _Notes, double avg, double max, string finalGrade)
        {

            for (int j = 0; j < _Notes.Length; j++)
            {
                Console.Write(_Notes[j] + " ");
            }
            Console.Write(avg + " " + finalGrade + " " + max + "\n");


        }

        public (int[], string,string) Read()
        {
            Console.Clear();
            int[] Notass = new int [3];
            string subject;
            string Name;
            int value1=0;

            Console.WriteLine("Please Enter Name");
            Name= Console.ReadLine();
            Console.WriteLine("Please Enter Subject");
            subject= Console.ReadLine();

            for (int i = 0; i < Notass.Length; i++)
            {
                while(true)
                {
                    Console.WriteLine("Please Enter Grades");
                    if (int.TryParse(Console.ReadLine(), out  value1) == false)
                    {
                        Console.WriteLine("try Again");
                    }
                    else
                    {
                        if (value1 > 0 & value1 < 100)
                        {
                            Notass[i] = value1;
                            break;
                        }
                        else Console.WriteLine("try Again");
                    }
                }
            }
            return (Notass, Name, subject);
        }

        

    }
}
