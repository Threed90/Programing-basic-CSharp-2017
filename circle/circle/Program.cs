using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double parameter = Math.PI * r * 2;
            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{parameter:f2}");
        }
    }
}
