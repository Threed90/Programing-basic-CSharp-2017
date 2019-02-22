using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int Exam_hour = int.Parse(Console.ReadLine());
            int Exam_mins = int.Parse(Console.ReadLine());
            int arrival_hour = int.Parse(Console.ReadLine());
            int arrival_mins = int.Parse(Console.ReadLine());

            int Exam_all_in_mins = Exam_hour * 60 + Exam_mins;
            int arrival_all_in_mins = arrival_hour * 60 + arrival_mins;


            bool late = Exam_all_in_mins < arrival_all_in_mins;
            bool onTime = Exam_all_in_mins - arrival_all_in_mins<=30 && Exam_all_in_mins - arrival_all_in_mins>=0;
            bool early = Exam_all_in_mins - arrival_all_in_mins > 30;

            if (late)
            {
                Console.WriteLine("Late");
                if ((arrival_all_in_mins- Exam_all_in_mins)/60 >= 1)
                {
                    int h = arrival_hour - Exam_hour;
                    int m = (arrival_all_in_mins - Exam_all_in_mins) % 60;
                    Console.WriteLine($"{h}:{m} hours after the start” ");
                }
                else
                {
                    int m = arrival_mins - Exam_mins;
                    Console.WriteLine($"{m} minutes after the start");
                }
            }
            else if (onTime)
            {
                Console.WriteLine("On time");
            }
            else if (early)
            {
                Console.WriteLine("Early");
                if ((Exam_all_in_mins- arrival_all_in_mins)/60 >= 1)
                {
                    int h = Exam_hour - arrival_hour;
                    int m = (Exam_all_in_mins - arrival_all_in_mins) % 60;
                    Console.WriteLine($"{h}:{m} hours before the start");
                }
                else
                {
                    int m = (Exam_all_in_mins-arrival_all_in_mins)%60;
                    Console.WriteLine("{0} minutes before the start",m);
                }
            }
        }
    }
}
