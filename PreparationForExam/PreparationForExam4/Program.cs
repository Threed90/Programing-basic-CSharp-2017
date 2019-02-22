using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForExam4
{
    class Program
    {
        static void Main(string[] args)
        {
            int wigth = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            string STOP = Console.ReadLine().ToLower();

            int cakeArea = wigth * length;
            int totalCakeParts = 0;

            while (true)
            {
                int num = int.Parse(STOP);
                totalCakeParts += num;
                cakeArea -= num;
                if (cakeArea < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeArea)} pieces more!");
                    break;
                }
               
                STOP = Console.ReadLine().ToLower();

                if (STOP == "stop")
                {
                    Console.WriteLine($"{(wigth*length)-totalCakeParts} pieces are left");
                    break;
                }
            }
        }
    }
}
