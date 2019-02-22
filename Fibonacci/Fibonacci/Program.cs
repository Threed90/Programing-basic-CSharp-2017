using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int f0 = 0;
            int f1 = 1;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum = f0 + f1;
                f0 = f1;
                f1 = sum;
            }
            if (n == 0)
                sum = 1;

            Console.WriteLine(sum);
        }
    }
}
