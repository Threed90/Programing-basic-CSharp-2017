using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForExam5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int i = 0;
            int two = 2;

            for (int j = 0; j <= 2*n+1; j++)
                {
                if (j <= n - 2)
                {


                    Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', j), new string('.', n - j));
                }
                else if (j == n-1 || j == n + 2)
                {
                    Console.WriteLine("{0}{1}{0}", new string ('.',n-1), new string('*',5));
                }
                else if (j == n)
                {
                    Console.WriteLine("{0}", new string('*', 2*n+3));
                }
                else if( j>=n+2)
                {
                    
                    Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', n-2-i), new string('.', two));
                    i++;
                    two++;
                }
                }
           
            
        }
    }
}
