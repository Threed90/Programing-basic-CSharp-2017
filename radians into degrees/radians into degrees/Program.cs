using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radians_into_degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double grad = rad*180 / Math.PI;

            Console.WriteLine($"{grad:f0}");
        }
    }
}
