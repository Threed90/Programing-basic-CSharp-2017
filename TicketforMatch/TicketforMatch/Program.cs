using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketforMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int peopleNumber = int.Parse(Console.ReadLine());

            double cost = 0;
            double lefted = 0;
            double vip = 0;
            double normal = 0;
            

            if (peopleNumber >= 1 && peopleNumber <= 4)
            {
                cost = budjet * 75 / 100;
                lefted = budjet - cost;
                vip = lefted / 499.99;
                normal = lefted / 249.99;
                bool vipTickets = vip >= peopleNumber;
                bool normalTickets = normal >= peopleNumber;
                if (category == "vip" && vipTickets)
                {
                    double n = lefted - (double)peopleNumber * 499.99;
                    Console.WriteLine($"Yes!You have {n:f2} leva left.");
                }
                else if (category == "normal" && normalTickets)
                {
                    double n = lefted - (double)peopleNumber * 249.99;
                    Console.WriteLine($"Yes!You have {n:f2} leva left.");
                }
                else if (category == "vip" && !vipTickets)
                {
                    double n = (double)peopleNumber * 499.99 - lefted;
                    Console.WriteLine($"Not enough money!You need {n:f2} leva.");
                }
                else if (category == "normal" && !normalTickets)
                {
                    double n = (double)peopleNumber * 249.99 - lefted;
                    Console.WriteLine($"Not enough money!You need {n:f2} leva.");
                }
            }
            else if (peopleNumber >= 5 && peopleNumber <= 9)
            {
                cost = budjet * 60 / 100;
                lefted = budjet - cost;
                vip = lefted / 499.99;
                normal = lefted / 249.99;
                bool vipTickets = vip >= peopleNumber;
                bool normalTickets = normal >= peopleNumber;
                if (category == "vip" && vipTickets)
                {
                    double n = lefted - (double)peopleNumber * 499.99;
                    Console.WriteLine($"Yes!You have {n:f2} leva left.");
                }
                else if (category == "normal" && normalTickets)
                {
                    double n = lefted - (double)peopleNumber * 249.99;
                    Console.WriteLine($"Yes!You have {n:f2} leva left.");
                }
                else if (category == "vip" && !vipTickets)
                {
                    double n = (double)peopleNumber * 499.99 - lefted;
                    Console.WriteLine($"Not enough money!You need {n:f2} leva.");
                }
                else if (category == "normal" && !normalTickets)
                {
                    double n = (double)peopleNumber * 249.99 - lefted;
                    Console.WriteLine($"Not enough money!You need {n:f2} leva.");
                }
            }
            else if (peopleNumber >= 10 && peopleNumber <= 24)
            {
                cost = budjet * 50 / 100;
                lefted = budjet - cost;
                vip = lefted / 499.99;
                normal = lefted / 249.99;
                bool vipTickets = vip >= peopleNumber;
                bool normalTickets = normal >= peopleNumber;
                if (category == "vip" && vipTickets)
                {
                    double n = lefted - (double)peopleNumber * 499.99;
                    Console.WriteLine($"Yes!You have {n:f2} leva left.");
                }
                else if (category == "normal" && normalTickets)
                {
                    double n = lefted - (double)peopleNumber * 249.99;
                    Console.WriteLine($"Yes!You have {n:f2} leva left.");
                }
                else if (category == "vip" && !vipTickets)
                {
                    double n = (double)peopleNumber * 499.99 - lefted;
                    Console.WriteLine($"Not enough money!You need {n:f2} leva.");
                }
                else if (category == "normal" && !normalTickets)
                {
                    double n = (double)peopleNumber * 249.99 - lefted;
                    Console.WriteLine($"Not enough money!You need {n:f2} leva.");
                }
            }
            else if (peopleNumber >= 25 && peopleNumber <= 49)
            {
                cost = budjet * 40 / 100;
                lefted = budjet - cost;
                vip = lefted / 499.99;
                normal = lefted / 249.99;
                bool vipTickets = vip >= peopleNumber;
                bool normalTickets = normal >= peopleNumber;
                if (category == "vip" && vipTickets)
                {
                    double n = lefted - (double)peopleNumber * 499.99;
                    Console.WriteLine($"Yes!You have {n:f2} leva left.");
                }
                else if (category == "normal" && normalTickets)
                {
                    double n = lefted - (double)peopleNumber * 249.99;
                    Console.WriteLine($"Yes!You have {n:f2} leva left.");
                }
                else if (category == "vip" && !vipTickets)
                {
                    double n = (double)peopleNumber * 499.99 - lefted;
                    Console.WriteLine($"Not enough money!You need {n:f2} leva.");
                }
                else if (category == "normal" && !normalTickets)
                {
                    double n = (double)peopleNumber * 249.99 - lefted;
                    Console.WriteLine($"Not enough money!You need {n:f2} leva.");
                }
            }
            else if (peopleNumber >= 50)
            {
                cost = budjet * 25 / 100;
                lefted = budjet - cost;
                vip = lefted / 499.99;
                normal = lefted / 249.99;
                bool vipTickets = vip >= peopleNumber;
                bool normalTickets = normal >= peopleNumber;
                if (category == "vip" && vipTickets)
                {
                    double n = lefted - (double)peopleNumber * 499.99;
                    Console.WriteLine($"Yes!You have {n:f2} leva left.");
                }
                else if (category == "normal" && normalTickets)
                {
                    double n = lefted - (double)peopleNumber * 249.99;
                    Console.WriteLine($"Yes!You have {n:f2} leva left.");
                }
                else if (category == "vip" && !vipTickets)
                {
                    double n = (double)peopleNumber * 499.99 - lefted;
                    Console.WriteLine($"Not enough money!You need {n:f2} leva.");
                }
                else if (category == "normal" && !normalTickets)
                {
                    double n = (double)peopleNumber * 249.99 - lefted;
                    Console.WriteLine($"Not enough money!You need {n:f2} leva.");
                }
            }
        }
    }
}
