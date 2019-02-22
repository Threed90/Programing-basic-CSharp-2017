using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForExam6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberFive = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            

            for (int one = 0; one <= numberOne; one++)
            {
                
                for (int two = 0; two <=numberTwo ; two++)
                {
                    
                    for (int five = 0; five <=numberFive; five++)
                    {
                        
                        if (one*1+two*2+five*5==sum)
                        {
                            Console.WriteLine($"{one}*1lv+{two}*2lv+{five}*5lv={sum}lv");
                        }
                    }
                }
            }
        }
    }
}
