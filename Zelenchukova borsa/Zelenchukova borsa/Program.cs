using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelenchukova_borsa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Зеленчуци - цена за килограм: ");
            double vegetables_price_for_kg = double.Parse(Console.ReadLine());
            Console.Write("Плодове - цена за килограм: ");
            double fruits_price_for_kg = double.Parse(Console.ReadLine());
            Console.Write("Общо килограми на зеленчуците: ");
            int total_kg_for_vegetables = int.Parse(Console.ReadLine());
            Console.Write("Общо килограми на плодовете: ");
            int total_kg_for_fruits = int.Parse(Console.ReadLine());

            double total_prece_vegetables = vegetables_price_for_kg * total_kg_for_vegetables;
            double total_prece_fruits = fruits_price_for_kg * total_kg_for_fruits;

            double total_all = total_prece_vegetables + total_prece_fruits;
            double total_all_in_EUR = total_all / 1.94;

        
            if (vegetables_price_for_kg >=0.00  & 1000.00 >= vegetables_price_for_kg & fruits_price_for_kg >= 0.00 & 1000.00>=fruits_price_for_kg & total_kg_for_vegetables>= 0 & 1000>= total_kg_for_vegetables & total_kg_for_fruits >= 0 & 1000>= total_kg_for_fruits)
            {
                Console.WriteLine($"{total_all_in_EUR:f2}");
            }
            else
            {
                Console.WriteLine("Въведете коректни стойности: ");
                Console.WriteLine("                              от 0.00лв. до 1000.00лв - цена за килограм;");
                Console.WriteLine("                              от 0кг до 1000кг - общи килограми.");
            }

        }
    }
}
