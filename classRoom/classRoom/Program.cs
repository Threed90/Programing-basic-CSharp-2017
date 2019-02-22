using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            
                double Wcm = w * 100 - 100;
                double Hcm = h * 100;

            double wRow = Math.Floor(Wcm / 70);
            double hRow = Math.Floor(Hcm / 120);

            double roomAreaTables = wRow * hRow - 3;




            if (3==h || h < 3 || h < w || h == w || w > 100 || w == 100) 
            {
               
                    Console.WriteLine("Грешни стойности! Ограничение: 3 < = h < = w < = 100.");
                
            }
            else
            {
                Console.WriteLine(roomAreaTables);
            }
        } 
    }
}
