using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForExam2
{
    class Program
    {
        static void Main(string[] args)
        {

            double dohod = double.Parse(Console.ReadLine());
            double result = double.Parse(Console.ReadLine());
            double min = double.Parse(Console.ReadLine());

            double social = 0;
            double exellent = 0;

            if (dohod<min && result > 4.50)
            {
                social = 35 * min / 100;
            }
            if (result >= 5.50)
            {
                exellent = result * 25;
            }

            if (social==0 && exellent == 0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (social > exellent)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(social)}BGN");
            }
            else if(exellent>social)
            {
                Console.WriteLine($"You get a scholarship for exellent results {Math.Floor(exellent)}BGN");
            }
        }
    }
}
