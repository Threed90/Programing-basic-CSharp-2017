using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle__text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter circle radius: ");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double parameter = Math.PI * r * 2;
            Console.WriteLine($"Area = {area:f2}");
            Console.WriteLine($"Parameter = {parameter:f2}");
        }
    }
}
