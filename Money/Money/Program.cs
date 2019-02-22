using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double joan = double.Parse(Console.ReadLine());
            double commition = double.Parse(Console.ReadLine());

            int bitcoins_into_leva = bitcoins * 1168;
            double joans_into_leva = (joan * 0.15) * 1.76;
            double leva_into_euro = (bitcoins_into_leva + joans_into_leva) / 1.95;
            double commition_from_euro = leva_into_euro * commition / 100;
            double total = leva_into_euro - commition_from_euro;

            if (bitcoins >= 0 & bitcoins <= 20 & joan >= 0.00 & joan <= 50000.00 & commition >= 0.00 & commition <= 5.00)
            {
                Console.WriteLine($"{total:f2}");
            }
            else
            {
                Console.Write($"{total:f2}");
                Console.WriteLine(" - Надвишена стойност!");
            }
        }
    }
}
