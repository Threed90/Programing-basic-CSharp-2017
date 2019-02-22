using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = double.Parse(Console.ReadLine());
            Console.WriteLine($"{numbers:f2}");
        }
    }
}
