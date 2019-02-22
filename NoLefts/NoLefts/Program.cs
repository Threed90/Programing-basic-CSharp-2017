using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoLefts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double divide2 = 0;
            double divide3 = 0;
            double divide4 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    divide2++;
                }
                if (num % 3 == 0)
                {
                    divide3++;
                }
                if (num % 4 == 0)
                {
                    divide4++;
                }
            }

            double p2 = (divide2 / n) * 100;
            double p3 = (divide3 / n) * 100;
            double p4 = (divide4 / n) * 100;

            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
        }
    }
}
