using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Introduce number of steps and calculate average 
            int fsteps = 0;
            int lsteps = 0;
            double avgsteps = 0;
            calc_steps(ref fsteps, ref lsteps, ref avgsteps);




            //2. Caculate time of Joging in minutes
            int hour_steps = 0;
            int minute_steps = 0;
            int total_time = 0;
            calc_time(ref hour_steps, ref minute_steps, ref total_time);

            //3. Calculate total steps
            double total_steps_in_all_time;

            total_steps_in_all_time = total_time * avgsteps;
            Console.WriteLine("You did {0} steps in your jogging", total_steps_in_all_time);

            //4. Calculate total distance

            double Total_distance_feet;
            double Total_distance_miles;
            Total_distance_feet = total_steps_in_all_time * 2.5;
            Total_distance_miles = Total_distance_feet * 0.0001893939;
            Console.WriteLine("you Run {0} feets or {1} miles", Total_distance_feet, Total_distance_miles);

            Console.ReadKey();
        }



        static void calc_steps(ref int fStep, ref int lStep, ref double avgStep)
        {
            Console.WriteLine("Please Enter steps first minute:");
            fStep = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter steps last minute:");
            lStep = int.Parse(Console.ReadLine());
            avgStep = (fStep + lStep) / 2.0;
            Console.WriteLine("Step in First Minute: {0},Step in last Minute: {1}, Average step: {2}", fStep, lStep, avgStep);
        }
        static void calc_time(ref int hour_Step, ref int minute_Step, ref int total_Time)
        {
            int hour_Step_to_min;
            Console.WriteLine("Please Enter hours you had been jogging:");
            hour_Step = int.Parse(Console.ReadLine());
            hour_Step_to_min=hour_Step * 60;
            Console.WriteLine("Please Enter minutes you had been jogging:");
            minute_Step = int.Parse(Console.ReadLine());
            total_Time = hour_Step_to_min + minute_Step;
            Console.WriteLine("you Joging {0} Hours, with {1} minutes, in total {2} minutes", hour_Step, minute_Step, total_Time);


        }

    }
}

