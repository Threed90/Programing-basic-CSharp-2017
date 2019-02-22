using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUmbers1to100WORDS
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int lastNumber = input % 10;
            int firstNumber = input - lastNumber;
            string last = string.Empty;

            if (lastNumber == 1)
            {
                last = "one";
            }
            else if (lastNumber == 2)
            {
                last = "two";
            }
            else if (lastNumber == 3)
            {
                last = "three";
            }
            else if (lastNumber == 4)
            {
                last = "four";
            }
            else if (lastNumber == 5)
            {
                last = "five";
            }
            else if (lastNumber == 6)
            {
                last = "six";
            }
            else if (lastNumber == 7)
            {
                last = "seven";
            }
            else if (lastNumber == 8)
            {
                last = "eight";
            }
            else if (lastNumber == 9)
            {
                last = "nine";
            }

            if (input == 0)
            {
                Console.WriteLine("zero");
            }
            else if (input == 100)
            {
                Console.WriteLine("one hundred");
            }
            else if (input < 10)
            {
                Console.WriteLine(last);
            }
            else if (input == 11)
            {
                Console.WriteLine("eleven");
            }
            else if (input == 12)
            {
                Console.WriteLine("twelve");
            }
            else if (input == 13)
            {
                Console.WriteLine("thirteen");
            }
            else if (input == 15)
            {
                Console.WriteLine("fifteen");
            }
            else if (input == 18)
            {
                Console.WriteLine("eighteen");
            }
            else if (input-10==lastNumber & lastNumber==4 || lastNumber==6 || lastNumber== 7|| lastNumber == 9)
            {
                Console.WriteLine($"{last}teen");
            }

            

            //десети
            if (firstNumber == 20)
            {
                Console.WriteLine($"twenty {last}");
            }
            else if (firstNumber == 30)
            {
                Console.WriteLine($"thirty {last}");
            }
            else if (firstNumber== 40)
            {
                Console.WriteLine($"forty {last}");
            }
            else if (firstNumber == 50)
            {
                Console.WriteLine($"fifty {last}");
            }
            else if (firstNumber == 60)
            {
                Console.WriteLine($"sixty {last}");
            }
            else if (firstNumber == 70)
            {
                Console.WriteLine($"seventy {last}");
            }
            else if (firstNumber == 80)
            {
                Console.WriteLine($"eighty {last}");
            }
            else if (firstNumber == 90)
            {
                Console.WriteLine($"ninety {last}");
            }
        }
    }
}
