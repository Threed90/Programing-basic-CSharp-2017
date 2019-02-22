using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmassTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                if (i == 0 || i == n - 1)
                {
                    Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));
                }
                else if ((n+1)/2 ==i + 1) // Math.Ceilling((double)n/2.00) == i+1
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2-2), new string('|', n));
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string(' ', n));
                }
            }
        }
    }
}
