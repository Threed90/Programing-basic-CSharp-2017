using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogramy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double till200 = 0;
            double till400 = 0;
            double till600 = 0;
            double till800 = 0;
            double over800 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    till200+=1;
                }
                else if(num>=200 && num < 400)
                {
                    till400+=1;
                }
                else if(num>=400 && num < 600)
                {
                    till600+=1;
                }
                else if(num>=600 && num < 800)
                {
                    till800+=1;
                }
                else
                {
                    over800+=1;
                }
            }

            double percent200 = (till200 / n) * 100;
            double percent400 = (till400 / n) * 100;
            double percent600 = (till600 / n) * 100;
            double percent800 = (till800 / n) * 100;
            double percentOver = (over800 / n) * 100;

            Console.WriteLine($"{percent200:f2}%");
            Console.WriteLine($"{percent400:f2}%");
            Console.WriteLine($"{percent600:f2}%");
            Console.WriteLine($"{percent800:f2}%");
            Console.WriteLine($"{percentOver:f2}%");

        }
    }
}
