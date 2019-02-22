using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            int howOld = int.Parse(Console.ReadLine());
            double peralnia = double.Parse(Console.ReadLine());
            int toyValue = int.Parse(Console.ReadLine());

            double moneys = 0;
            double mm = 0;
            double toy = 0;
            double brother = 0;

            for (int i = 1; i <= howOld; i++)
            {
                if (i % 2 == 0)
                {
                    mm += 10;
                    moneys+=mm;
                    brother++;
                }
                else
                {
                    toy++;
                }
            }

            double BirthdayMoney = moneys - brother;
            double toysMoney = toy * toyValue;
            double total = BirthdayMoney + toysMoney;

            if (total > peralnia)
            {
                Console.WriteLine($"Yes! {(total-peralnia):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(peralnia-total):f2}");
            }
        }
    }
}
