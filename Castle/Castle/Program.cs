using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("{2}{0}{3}{1}{2}{0}{3}", new string('^', n / 2), new string('_', (n * 2 - (n / 2 + 2) * 2)),
                                                               new string('/', 1), new string('\\', 1));
                }
                else if (i == n - 1)
                {
                    Console.WriteLine("{2}{0}{3}{1}{2}{0}{3}", new string('_', n / 2), new string(' ', (n * 2 - (n / 2 + 2) * 2)),
                                                               new string('\\', 1), new string('/', 1));
                }
                else if (i>0 && i<n-2)
                {


                    Console.WriteLine("|{0}|", new string(' ', n * 2 - 2));

                }
                else if (i == n - 2)
                {
                    if(n<=4)
                    Console.WriteLine("|{0}|", new string(' ', n * 2 - 2));
                    else if(n>4)
                        Console.WriteLine("|{0}{1}{0}|", new string(' ', n / 2 +1), new string ('_', (n * 2 - (n / 2 + 2) * 2)));
                }
                
            }
        }
    }
}
