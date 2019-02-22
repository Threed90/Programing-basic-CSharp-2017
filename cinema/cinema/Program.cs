using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine().ToLower();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double allPlaces = row * column;
            double ticket = 0;

            switch(projection)
            {
                case "premiere":
                    ticket = 12.00;
                    break;
                case "normal":
                    ticket = 7.50;
                    break;
                case "discount":
                    ticket = 5.00;
                    break;
            }

            Console.WriteLine($"{allPlaces*ticket:f2}");
        }
    }
}
