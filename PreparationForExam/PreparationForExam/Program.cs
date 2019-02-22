using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double daljina = double.Parse(Console.ReadLine());
            double shirina = double.Parse(Console.ReadLine());

            double razmeri1 = (daljina + 2 * 0.30) * (shirina + 2 * 0.30);
            double razmeri2 = (daljina / 2) * (daljina / 2);

            double price = ((double)tables * razmeri1)*7.00;
            double price2 = (razmeri2 * (double)tables)*9.00;
            double total = price + price2;
            double totalBGN = total * 1.85;

            Console.WriteLine($"{total:f2}USD");
            Console.WriteLine($"{totalBGN:f2}BGN");

        }
    }
}
