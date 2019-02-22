using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2= int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double P1_for_H = P1 * H;
            double P2_for_H = P2 * H;
            double total_P12 = P1_for_H + P2_for_H;
            double v_percent = v / 100;

            double P12_percent = (P1_for_H+ P2_for_H) / v_percent;
            double P1_percent = P1_for_H / (total_P12 / 100);
            double P2_percent = P2_for_H / (total_P12 / 100);

            if (v >= total_P12)
            {
                Console.Write("Pool is full: "+ (int)P12_percent+"%");
                Console.WriteLine($" P1:{(int)P1_percent}% P2:{(int)P2_percent}%");
            }
            else
            {
                Console.WriteLine("overflow with "+ (total_P12-v));
            }

        }
    }
}
