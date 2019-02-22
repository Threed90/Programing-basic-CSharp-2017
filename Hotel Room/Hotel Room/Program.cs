using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounts = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;
            double lessPayforStudio = 0;
            double lessPayforApart = 0;


            if ( mounts == "May" || mounts == "October")
            {
                studio = 50.00;
                apartment = 65.00;
                if (days <= 14)
                {
                    lessPayforStudio = studio * 5 / 100;
                }
                else if(days > 14)
                {
                    lessPayforStudio = studio * 30 / 100;
                    lessPayforApart = apartment * 10 / 100;
                }
            }
            else if (mounts == "June" || mounts == "September")
            {
                studio = 75.20;
                apartment = 68.70;
                if (days > 14)
                {
                    lessPayforStudio = studio * 20 / 100;
                    lessPayforApart = apartment * 10 / 100;
                }
            }
            else if (mounts == "July" || mounts == "August")
            {
                studio = 76.00;
                apartment = 77.00;
                if (days > 14)
                {
                    lessPayforApart = apartment * 10 / 100;
                }
            }
             
            Console.WriteLine($"Apartment: {(apartment-lessPayforApart)*days:f2} lv.");
            Console.WriteLine($"Studio: {(studio-lessPayforStudio)*days:f2} lv.");
        }
    }
}
