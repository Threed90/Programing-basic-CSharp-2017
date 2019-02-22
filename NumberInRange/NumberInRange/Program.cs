using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Еnter a number in the range [1...100]:  ");
            int n = int.Parse(Console.ReadLine());
            
            if(n < 1 || n > 100)
                Console.WriteLine("Invalid number!");
            while (n < 1 || n > 100)
            {
                Console.Write("Еnter a number in the range [1...100]:  ");
                n = int.Parse(Console.ReadLine());
                if (n < 1 || n > 100)
                {
                    Console.WriteLine("Invalid number!");
                }
                
            }
            if (!(n < 1 || n > 100))
                Console.WriteLine($"The number is: {n}");


        }
    }
}
