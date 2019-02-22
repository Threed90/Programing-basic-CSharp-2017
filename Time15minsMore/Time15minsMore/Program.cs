using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time15minsMore
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            int mins15 = mins + 15;

            int newhours = hour + (mins15 / 60);
            int newmins = mins15 % 60;
            int hourLimit = newhours % 24;

            if (newmins<10)
            {

                Console.WriteLine($"{hourLimit}:0{newmins}");
            }
            else
            {
                Console.WriteLine("{0}:{1}", hourLimit, newmins);
            }

           
        }
    }
}
