using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathRounds
{
    class Program
    {
        static void Main(string[] args)
        {
            double one = Math.Round(112.345, 1);
            double two = Math.Round(123.456, 2);
            double three = Math.Round(566.7899, 3);
            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine(three);
        }
    }
}
