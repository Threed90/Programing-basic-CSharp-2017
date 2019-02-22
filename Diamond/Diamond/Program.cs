using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int stars = 1;
            int outdash = 0;
            int indash = 0;
            int indash1 = -1;
          

            for (int i = 0; i < n; i++)
            {
                

                if (i==0)
                {
                    if (n % 2 == 0)
                    {
                        Console.Write("{0}{1}{0}", new string('-', n/2-stars), new string('*',stars*2));
                    }
                    else
                    {
                        Console.Write("{0}{1}{0}", new string('-', n / 2 ), new string('*', stars));
                    }
                }
                else if(i==n-1 && n % 2 != 0)
                {
                    Console.Write("{0}{1}{0}", new string('-', n / 2), new string('*', stars));
                }
                else
                {
                    if ((n+1)/2 > i)
                    {
                        
                        if (n % 2 == 0)
                        {
                            indash += 2;
                            outdash = (n - indash - 2) / 2;
                            Console.Write("{0}*{1}*{0}", new string('-',outdash),new string('-',indash));
                            
                        }
                        else
                        {
                            indash1 += 2;
                            outdash = (n - indash1 - 2) / 2;
                            Console.Write("{0}*{1}*{0}", new string('-', outdash), new string('-', indash1));
                            
                        }
                        
                    }
                    else if (i>= (n + 1) / 2 && i < n - 1)
                    {
                        if (n % 2 == 0)
                        {
                            indash -= 2;
                            outdash += 1;
                            Console.Write("{0}*{1}*{0}", new string('-', outdash), new string('-', indash));
                            
                        }
                        else
                        {
                            indash1 -= 2;
                            outdash += 1;
                            Console.Write("{0}*{1}*{0}", new string('-', outdash), new string('-', indash1));
                        }
                    }
                }
                
                
                Console.WriteLine();
            }
        }
    }
}
