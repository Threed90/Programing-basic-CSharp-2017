using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = 0;
            int y1 = 0;

            bool inside1 = x > 0 && x < h * 3 && y > 0 && y < h;
            bool inside2 = x > h && x < h * 2 && y >= h && y < h * 4;
            bool border1 = y >= 0 && y <= h && (x==0 || x==h*3);
            bool border2 = x >= 0 && x <= h * 3 && y == 0;
            bool border3 = y >= h && y <= h * 4 && (x == h || x == h * 2);
            bool border4 = x >= h && x <= h * 2 && y == h * 4;
            bool border5 = x >= 0 && x <= h && y == h;
            bool border6 = x >= h*2 && x <= h*3 && y == h;

            if (inside1 || inside2)
            {
                Console.WriteLine("inside");
            }
            else if (border1 || border2 || border3 || border4 || border5 || border6)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
