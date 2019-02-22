using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxValue = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum += num;

                if (maxValue < num)
                {
                    maxValue = num;
                }
                

            }
            if (maxValue == (sum-maxValue))
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = "+ maxValue);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = "+ Math.Abs(maxValue-(sum-maxValue)));
            }
        }
    }
}
