using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
                int row = i + 1;
                int row2 = n - 1;
                for (int j = 0; j < n-i; j++)
                {
                    Console.Write(row + " ");
                    row++;
                }
                for (int j = 1; j < i; j++)
                {
                    Console.Write(row2 + " ");
                    row2--;
                }
                Console.WriteLine();
            }
        }
    }
}
