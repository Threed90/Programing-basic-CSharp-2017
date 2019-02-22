using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int points = n+1;
            int dashes = 2 * n - 3;
            

            for (int i = 0; i < n*2+2; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.',n+1 ),new string('_',2*n+1));
                }
                else if (i>=1 && i < n + 1)
                {
                    points -= 1;
                    dashes += 2;
                    Console.WriteLine("{0}{1}{2}{3}{0}", new string('.',points), new string('/', 2), 
                                                        new string('_',dashes ), new string('\\',2));
                }
                else if (i == n + 1)
                {
                    points -= 1;
                    dashes += 2;
                    Console.WriteLine("{0}{1}{2}STOP!{2}{3}{0}", new string('.', points), new string('/', 2),
                                                        new string('_', (dashes-5)/2), new string('\\', 2));
                }
                else if (i>n+1 && i < 2 * n + 2)
                {
                   
                    Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', points), new string('\\', 2),
                                                        new string('_', dashes), new string('/', 2));
                    points += 1;
                    dashes -= 2;
                }
            }
        }
    }
}
