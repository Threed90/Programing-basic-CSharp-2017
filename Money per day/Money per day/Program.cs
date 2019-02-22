using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_per_day
{
    class Program
    {
        static void Main(string[] args)
        {
            int working_days = int.Parse(Console.ReadLine());
            double money_per_day = double.Parse(Console.ReadLine());
            double USD_for_BGN = double.Parse(Console.ReadLine());

            double money_for_mount = working_days * money_per_day;
            double money_for_year = money_for_mount * 12 + money_for_mount * 2.5;
            double tax = (money_for_year * 25) / 100;

            double year_money_after_tax = money_for_year - tax;
            double daily_money = year_money_after_tax / 365;

            double daily_money_in_BGN = daily_money * USD_for_BGN;

            if(working_days>=5 & working_days<=30 & money_per_day>=10.00&money_per_day<=2000.00&USD_for_BGN>=0.99&USD_for_BGN<=1.99)
            {
                Console.WriteLine(Math.Round(daily_money_in_BGN,2));
            }
        }
    }
}
