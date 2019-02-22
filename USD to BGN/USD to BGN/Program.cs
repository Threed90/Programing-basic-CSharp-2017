using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("USD= ");
            decimal USD = decimal.Parse(Console.ReadLine());

            decimal BGN = USD * 1.79549m;

            Console.WriteLine("BGN= "+ $"{BGN:f2}");
        }
    }
}
