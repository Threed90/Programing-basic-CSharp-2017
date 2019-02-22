using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           
            do
            {
               try
                {
                    Console.Write("Enter even number:");
                    int n = int.Parse(Console.ReadLine());
                    if (n % 2 != 0)
                    {
                        Console.WriteLine("The number is not even.");
                        continue;
                    }
                    else if (n % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {n}");
                        break;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                    
                }
            } while (true) ;

            
        }
    }
}
