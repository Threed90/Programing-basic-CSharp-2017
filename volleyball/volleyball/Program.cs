using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string leap = Console.ReadLine().ToLower();
            int holydays = int.Parse(Console.ReadLine());
            int weekends_out_from_Sofia = int.Parse(Console.ReadLine());

            double weekends_in_Sofia = ((48 - (double)weekends_out_from_Sofia) * 3) / 4;
            double volleyball_in_Sofia = ((double)holydays * 2 / 3) + weekends_in_Sofia;
            double volleyball_out_Sofia = weekends_out_from_Sofia;

            double leap_year = (volleyball_in_Sofia + volleyball_out_Sofia) * 15 / 100;

            if (leap == "leap")
            {
                Console.WriteLine(Math.Floor(volleyball_in_Sofia+volleyball_out_Sofia+leap_year));
            }
            else if(leap == "normal")
            {
                Console.WriteLine(Math.Floor(volleyball_in_Sofia+volleyball_out_Sofia));
            }
        }
    }
}
