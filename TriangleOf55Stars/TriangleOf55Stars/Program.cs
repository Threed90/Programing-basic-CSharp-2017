﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}", new string('*', i));
            }
        }
    }
}
