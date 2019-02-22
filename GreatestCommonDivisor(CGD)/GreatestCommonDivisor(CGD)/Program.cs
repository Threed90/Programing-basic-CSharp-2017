using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor_CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int bigger = Math.Max(a, b);
            int smaller = Math.Min(a, b);

            while (smaller!=0)
            {
                int gcd = bigger % smaller;
                bigger = smaller;
                smaller = gcd;
            }

            Console.WriteLine(bigger);
        }
    }
}
