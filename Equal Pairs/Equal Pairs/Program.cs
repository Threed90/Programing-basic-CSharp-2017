using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double sum = 0;
            double minSum = double.MaxValue;
            double maxSum = double.MinValue;
            double firstPair = 0;
            double diff = 0;

            for (double i = 0; i < n; i++)
            {
                double n1 = double.Parse(Console.ReadLine());
                double n2 = double.Parse(Console.ReadLine());

                sum = n1 + n2;

                if (i == 0)
                {
                    firstPair = sum;
                }
                if (minSum > sum)
                {
                    minSum = sum;
                }
                if (maxSum < sum)
                {
                    maxSum = sum;
                }
                
                if (i>0 && firstPair == sum)
                {
                    diff = firstPair - sum;
                }
                else if (i>0 && (firstPair != sum))
                {
                    diff = Math.Abs(maxSum-minSum);
                }
            }

            if (diff == 0)
            {
                Console.WriteLine("Yes, value={0}", firstPair);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}");
            }
        }
    }
}
