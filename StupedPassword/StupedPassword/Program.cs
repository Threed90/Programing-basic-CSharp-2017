using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupedPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            int letter1 = 0;
            int letter2 = 0;

                for (int first = 1; first <= n; first++)
                {
                    // 1st number

                    for (int second = 1; second <= n; second++)
                    {
                        // 2nd number

                        for (int third = 1; third <= l; third++)
                        {
                            // 1st letter
                            letter1 = 96 + third;

                            for (int four = 1; four <= l; four++)
                            {
                                // 2nd letter
                                letter2 = 96 + four;

                                for (int five = first+1; five <= n; five++)
                                {
                                    // last number + result

                                    if (five> first && five > second) // condition for last number to be bigger that 1st 2 numbers
                                    Console.Write($"{first}{second}{(char)letter1}{(char)letter2}{five} ");
                                }
                            }
                        }
                    }

                }
               
            
        }
    }
}
