using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForExam3
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            string photoType = Console.ReadLine().ToLower();
            string where = Console.ReadLine().ToLower();

            double Price = 0;

            if (photoType == "9x13" || photoType=="10x15")
            {
                Price =  0.16;
                
            }
            else if(photoType == "13x18")
            {
                Price = 0.38;
            }
            else if(photoType == "20x30")
            {
                Price = 2.90;
            }

            double totalPrice = (double)photoNumber * Price;
            double otstapka = 0;

            if (photoNumber >= 50 && photoType == "9x13")
            {
                
                   otstapka  = totalPrice * 5 / 100;
                totalPrice = totalPrice - otstapka;
                
            }
            else if(photoType == "10x15" && photoNumber >= 80)
            {
                otstapka = totalPrice * 3 / 100;
                totalPrice = totalPrice - otstapka;
            }
            else if (photoType == "13x18")
            {
                if (photoNumber>49 && photoNumber <= 100)
                {
                    otstapka = totalPrice * 3 / 100;
                    totalPrice = totalPrice - otstapka;
                }
                else if (photoNumber > 100)
                {
                    otstapka = totalPrice * 5 / 100;
                    totalPrice = totalPrice - otstapka;
                }
            }
            else if (photoType == "20x30")
            {
                if (photoNumber>=10 && photoNumber <= 50)
                {
                    otstapka = totalPrice * 7 / 100;
                    totalPrice = totalPrice - otstapka;
                }
                else if (photoNumber > 50)
                {
                    otstapka = totalPrice * 9 / 100;
                    totalPrice = totalPrice - otstapka;
                }
            }
            if (where == "online")
            {
                totalPrice = totalPrice - (totalPrice * 2 / 100);
                Console.WriteLine($"{totalPrice:f2}BGN");
            }
            else if(where== "office")
            {
                Console.WriteLine($"{totalPrice:f2}BGN");
            }
        }
    }
}
