using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num <= 20)
            {
                Console.WriteLine("Числото е разрешено!");
            }
            if (num>20)
            {
                Console.WriteLine("Числото е забранено!");
            }
            return;
        }
    }
}
