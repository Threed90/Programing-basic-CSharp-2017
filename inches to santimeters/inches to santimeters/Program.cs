using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inches_to_santimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cel = decimal.Parse(Console.ReadLine());
            decimal far = (cel * 1.8m) + 32;
            Console.WriteLine(far);
        }
    }
}
