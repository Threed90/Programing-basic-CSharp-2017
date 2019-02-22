using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            string destination = string.Empty;
            double costs = 0.00;
            string location = string.Empty;

            if (budjet <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        costs = budjet * 30 / 100;
                        location = "Camp";
                        break;
                    case "winter":
                        costs = budjet * 70 / 100;
                        location = "Hotel";
                        break;
                }
                
            }
            else if (budjet <= 1000)
            {
                destination = "Balkans";

                switch (season)
                {
                    case "summer":
                        costs = budjet * 40 / 100;
                        location = "Camp";
                        break;
                    case "winter":
                        costs = budjet * 80 / 100;
                        location = "Hotel";
                        break;
                }
            }
            else if(budjet > 1000)
            {
                destination = "Europe";
                costs = budjet * 90 / 100;
                location = "Hotel";
            }

            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine($"{location}-{costs:f2}");
        }
    }
}
