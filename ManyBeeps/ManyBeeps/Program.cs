using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyBeeps
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 200; i <= 4000; i += 200)
            {
                Console.Beep(i, 100);
            }
        }
    }
}
