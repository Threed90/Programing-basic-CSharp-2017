using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sells = double.Parse(Console.ReadLine());

            double commition = 0.00;

            if (sells>=0 && sells <= 500)
            {
                switch (city)
                {
                    case "sofia":
                        commition = sells * 5 / 100;
                        break;
                    case "varna":
                        commition = sells * 4.5 / 100;
                        break;
                    case "plovdiv":
                        commition = sells * 5.5 / 100;
                        break;
                }
            }
            else if (sells > 500 && sells <= 1000)
            {
                switch (city)
                {
                    case "sofia":
                        commition = sells * 7 / 100;
                        break;
                    case "varna":
                        commition = sells * 7.5 / 100;
                        break;
                    case "plovdiv":
                        commition = sells * 8 / 100;
                        break;
                }

            }
            else if(sells >1000 && sells <= 10000)
            {
                switch (city)
                {
                    case "sofia":
                        commition = sells * 8 / 100;
                        break;
                    case "varna":
                        commition = sells * 10 / 100;
                        break;
                    case "plovdiv":
                        commition = sells * 12 / 100;
                        break;
                }
            }
            else if (sells > 10000)
            { 
                switch (city)
                {
                    case "sofia":
                        commition = sells * 12 / 100;
                        break;
                    case "varna":
                        commition = sells * 13 / 100;
                        break;
                    case "plovdiv":
                        commition = sells * 14.5 / 100;
                        break;
                }
            }
           if ((city == "sofia"|| city =="plovdiv"|| city=="varna" )&&sells>=0)
            Console.WriteLine($"{commition:f2}");
           else
                Console.WriteLine("error");
        }
    }
}
