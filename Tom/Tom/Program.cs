using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            int weekend_days = int.Parse(Console.ReadLine());

            int working_days = 365 - weekend_days;
            int weekDays_Play = 127 * weekend_days;
            int workDays_PLay = 63 * working_days;
            int allDays_Play = weekDays_Play + workDays_PLay;

            int lefttime = 30000 - allDays_Play;
            int hours_Play = lefttime / 60;
            int mins_PLay = lefttime % 60;
            
            if (allDays_Play > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Abs(hours_Play)} hours and {Math.Abs(mins_PLay)} minutes more for play") ;
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours_Play} hours and {mins_PLay} minutes less for play");
            }
        }
    }
}
