using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string town = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            double productValue = 0.00;

            if (town == "sofia")
            {
                switch (product)
                {
                    case "coffee":
                        productValue = 0.50;
                        break;
                    case "water":
                        productValue = 0.80;
                        break;
                    case "beer":
                        productValue = 1.20;
                        break;
                    case "sweets":
                        productValue = 1.45;
                        break;
                    case "peanuts":
                        productValue = 1.60;
                        break;
                }
            }
            else if (town == "plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        productValue = 0.40;
                        break;
                    case "water":
                        productValue = 0.70;
                        break;
                    case "beer":
                        productValue = 1.15;
                        break;
                    case "sweets":
                        productValue = 1.30;
                        break;
                    case "peanuts":
                        productValue = 1.50;
                        break;
                }
            }
            else if (town == "varna")
            {
                switch (product)
                {
                    case "coffee":
                        productValue = 0.45;
                        break;
                    case "water":
                        productValue = 0.70;
                        break;
                    case "beer":
                        productValue = 1.10;
                        break;
                    case "sweets":
                        productValue = 1.35;
                        break;
                    case "peanuts":
                        productValue = 1.55;
                        break;
                }
            }
            Console.WriteLine(productValue*quantity);
        }
    }
}
