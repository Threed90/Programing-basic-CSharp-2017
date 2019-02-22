using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1000days
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            DateTime start = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime end = start.AddDays(1000-1);
            Console.WriteLine(end.ToString("dd-MM-yyyy"));
        }
    }
}
