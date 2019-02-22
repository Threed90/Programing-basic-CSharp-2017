using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs_try2
{
    class Program
    {
        static void Main(string[] args)

       {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int firstsum = 0;
            int diff = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                sum = n1 + n2;

                if (i == 0)
                {
                    firstsum = n1 + n2;
                }
                if (i % 2 == 0)
                {
                    sum1 = n1 + n2;
                }
                else 
                {
                    sum2 = n1 + n2;
                }
                
                    diff = Math.Abs(sum1 - sum2);
                

            }
            if (firstsum - sum == 0)
            {
                Console.WriteLine("Yes, value="+firstsum);
            }
            if (diff != 0)
            {
                Console.WriteLine("No, maxdiff="+diff);
            }
        }
    }
}
