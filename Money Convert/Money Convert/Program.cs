using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            var leva = double.Parse(Console.ReadLine());
            var euro = leva / 1.95583;

            Console.WriteLine(euro);
        }
    }
}
