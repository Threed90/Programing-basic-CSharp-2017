using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftsum = 0;
            int rightsum = 0;

            for (int i = 0; i < n*2; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i<n)
                {
                    leftsum += num;
                }
                else
                {
                    rightsum += num;
                }
            }
            if (leftsum == rightsum)
            {
                Console.WriteLine("Yes, sum = "+leftsum);
            }
            else
            {
                Console.WriteLine("No, diff = "+ Math.Abs(leftsum-rightsum));
            }
        }
    }
}
