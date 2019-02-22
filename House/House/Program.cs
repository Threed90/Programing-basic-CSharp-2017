using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int stars = 1;

            if (n % 2 == 0)
            {
                stars = 2;
            }
            int spaces = (n - stars)/2;

            for (int i = 0; i < (n+1)/2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', spaces), new string('*',stars));
                stars += 2;
                spaces -= 1;
            }
            for (int i = 0; i <n/2; i++)
            {
                Console.WriteLine("|{0}|",new string('*', n-2));
            }
        }
    }
}
