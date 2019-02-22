using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricCovertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            double meters = 0;
            double convertor = 0;

            if (input == "m")
            {
                meters = num;
            }
            else if (input == "mm")
            {
                meters = num / 1000;
            }
            else if (input == "cm")
            {
                meters = num / 100;
            }
            else if(input == "mi")
            {
                meters = num / 0.000621371192;
            }
            else if (input == "in")
            {
                meters = num / 39.3700787;
            }
            else if (input == "km")
            {
                meters = num / 0.001;
            }
            else if (input == "ft")
            {
                meters = num / 3.2808399;
            }
            else if (input == "yd")
            {
                meters = num / 1.0936133;
            }

            if (output == "m")
            {
                convertor = meters;
            }
            else if (output == "mm")
            {
                convertor = meters * 1000;
            }
            else if (output == "cm")
            {
                convertor = meters * 100;
            }
            else if (output == "mi")
            {
                convertor = meters * 0.000621371192;
            }
            else if (output == "in")
            {
                convertor = meters * 39.3700787;
            }
            else if (output == "km")
            {
                convertor = meters * 0.001;
            }
            else if (output == "ft")
            {
                convertor = meters * 3.2808399;
            }
            else if (output == "yd")
            {
                convertor = meters * 1.0936133;
            }

            Console.WriteLine($"{convertor:f8}");
        }
    }
}
