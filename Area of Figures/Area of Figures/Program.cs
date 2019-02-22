using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figures = Console.ReadLine();

            if (figures == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a*a:f3}");
            }
            else if (figures== "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(a*b);
            }
            else if (figures== "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double area = Math.PI * r * r;
                Console.WriteLine(Math.Round(area,3));
            }
            else if (figures== "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a*h/2:f3}");
            }
        }
    }
}
