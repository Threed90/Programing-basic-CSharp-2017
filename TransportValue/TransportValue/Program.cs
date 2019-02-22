using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportValue
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = double.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double taxi = 0.00;

            if (dayOrNight == "day")
            {
                taxi = 0.79;
            }
            else if (dayOrNight=="night")
            {
                taxi = 0.90;
            }

            if (km < 20)
            {
                Console.WriteLine($"{0.70+taxi*km:f2}");
            }
            else if (km <100)
            {
                Console.WriteLine($"{0.09*km:f2}");
            }
            else
            {
                Console.WriteLine($"{0.06 * km:f2}");
            }
        }
    }
}
