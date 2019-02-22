using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squard_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double area = a * a;

            Console.WriteLine($"ЛИцето на квадрата е {area}");
        }
    }
}
