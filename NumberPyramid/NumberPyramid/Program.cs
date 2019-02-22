using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;
            int rows = 1;

            while (n>=rows)
            {
                for (int i = 0; i < num; i++)
                {
                    Console.Write(rows+" ");
                    rows++;
                    if (n < rows)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                num++;
                
            }
        }
    }
}
