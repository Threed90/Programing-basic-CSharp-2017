using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence2k1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i*=2)
            //{
            //    i++;
            //    Console.WriteLine(i);
            //}

            int num = 1;
            while (num<=n)
            {
                Console.WriteLine(num);
                num *= 2;
                num++;

            }
        }
    }
}
