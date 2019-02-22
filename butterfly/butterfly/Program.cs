using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2*(n-2)+1; i++)
            {
                if (i == (2 * (n - 2) + 1)/2)
                {
                    Console.WriteLine("{0}@{0}", new string(' ', n - 1));
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
                }
            }
        }
    }
}
