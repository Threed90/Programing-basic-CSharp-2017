using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            bool fruits = fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes";
            bool weekends = day == "saturday" || day == "sunday";
            bool workdays = day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday";
            double products = 0.00;

            if (workdays)
            {
                switch (fruit)
                {
                    case "banana":
                        products = 2.50;
                        break;
                    case "apple":
                        products = 1.20;
                        break;
                    case "orange":
                        products = 0.85;
                        break;
                    case "grapefruit":
                        products = 1.45;
                        break;
                    case "kiwi":
                        products = 2.70;
                        break;
                    case "pineapple":
                        products = 5.50;
                        break;
                    case "grapes":
                        products = 3.85;
                        break;
                }
            }
            else if (weekends)
            {
                switch (fruit)
                {
                    case "banana":
                        products = 2.70;
                        break;
                    case "apple":
                        products = 1.25;
                        break;
                    case "orange":
                        products = 0.90;
                        break;
                    case "grapefruit":
                        products = 1.60;
                        break;
                    case "kiwi":
                        products = 3.00;
                        break;
                    case "pineapple":
                        products = 5.60;
                        break;
                    case "grapes":
                        products = 4.20;
                        break;
                }

            }
            if (fruits && (weekends|| workdays)) 
            
            {
                Console.WriteLine($"{quantity*products:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
