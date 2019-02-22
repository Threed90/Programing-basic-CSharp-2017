using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remont_na_plochki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Дължина(площадка): ");
            double N = double.Parse(Console.ReadLine());
            Console.Write("Широчина(плочка): ");
            double W = double.Parse(Console.ReadLine());
            Console.Write("Дължина(плочка): ");
            double L = double.Parse(Console.ReadLine());
            Console.Write("Широчина(пейка): ");
            double M = double.Parse(Console.ReadLine());
            Console.Write("Дължина(пейка): ");
            double O = double.Parse(Console.ReadLine());

            double areaN = N * N;
            double areaWL = W * L;
            double areaMO = M * O;

            double needed = (areaN  - areaMO)/ areaWL;
            double time = needed * 0.2;

            if (N>=1 & 100>=N & W>=0.1 & 10.00>=W & L >= 0.1 & 10.00 >= L & M >=0 & 10>= M & O >= 0 & 10 >= O)
            {
                Console.Write("Брой необходими плочки: ");
                Console.WriteLine(Math.Round(needed,2));
                Console.Write("Време за поставяне на {0} на брой плочки: ", Math.Round(needed,2));
                Console.WriteLine($"{time:f2}");
            }
            else
            {
                Console.WriteLine("error");
                Console.WriteLine("дължината на страна от площадката в интервала [1...100]");
                Console.WriteLine("широчината на една плочка в интервала [0.1...10.00]");
                Console.WriteLine("дължината на една плочка в интервала [0.1...10.00]");
                Console.WriteLine("широчината на пейката в интервала [0...10]");
                Console.WriteLine("дължината на пейката в интервала [0...10]");
            }
        }
    }
}
