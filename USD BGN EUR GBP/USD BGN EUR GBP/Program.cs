using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_BGN_EUR_GBP
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Amount= ");
                double value = double.Parse(Console.ReadLine());
                Console.Write("From= ");
                string moneyForExchange = Console.ReadLine();
                Console.Write("To= ");
                string ExchangedMoney = Console.ReadLine();

                // BGN 
                if (moneyForExchange == "BGN" & ExchangedMoney == "USD")
                {
                    Console.WriteLine($"{value / 1.79549:f2}" + " USD");
                }

                if (moneyForExchange == "BGN" & ExchangedMoney == "EUR")
                {
                    Console.WriteLine($"{value / 1.95583:f2}" + " EUR");
                }

                if (moneyForExchange == "BGN" & ExchangedMoney == "GBP")
                {
                    Console.WriteLine($"{value / 2.53405:f2}" + " GBP");
                }

                // USD
                if (moneyForExchange == "USD" & ExchangedMoney == "BGN")
                {
                    Console.WriteLine($"{value * 1.79549:f2}" + " BGN");
                }

                if (moneyForExchange == "USD" & ExchangedMoney == "GBP")
                {
                    Console.WriteLine($"{(value * 1.79549) / 2.53405:f2}" + " GBP");
                }

                if (moneyForExchange == "USD" & ExchangedMoney == "EUR")
                {
                    Console.WriteLine($"{(value * 1.79549) / 1.95583:f2}" + " EUR");
                }

                //EUR

                if (moneyForExchange == "EUR" & ExchangedMoney == "BGN")
                {
                    Console.WriteLine($"{value * 1.95583:f2}" + " BGN");
                }

                if (moneyForExchange == "EUR" & ExchangedMoney == "USD")
                {
                    Console.WriteLine($"{(value * 1.95583) / 1.79549:f2}" + " USD");
                }

                if (moneyForExchange == "EUR" & ExchangedMoney == "GBP")
                {
                    Console.WriteLine($"{(value * 1.95583) / 2.53405:f2}" + " GBP");
                }

                //GBP

                if (moneyForExchange == "GBP" & ExchangedMoney == "BGN")
                {
                    Console.WriteLine($"{value * 2.53405:f2}" + " BGN");
                }

                if (moneyForExchange == "GBP" & ExchangedMoney == "USD")
                {
                    Console.WriteLine($"{(value * 2.53405) / 1.79549:f2}" + " USD");
                }

                if (moneyForExchange == "GBP" & ExchangedMoney == "EUR")
                {
                    Console.WriteLine($"{(value * 2.53405) / 1.95583:f2}" + " EUR");
                }

        }
    }
}
