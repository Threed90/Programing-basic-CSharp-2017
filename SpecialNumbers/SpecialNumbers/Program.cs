using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int one = 1; one <= 9; one++)
            {
                for (int two = 1; two <= 9; two++)
                {
                    for (int three = 1; three <= 9; three++)
                    {
                        for (int four = 1; four <= 9; four++)
                        {
                            if(n%one==0 && n%two==0 && n%three==0 && n % four == 0)
                            {
                                Console.Write($"{one}{two}{three}{four} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
