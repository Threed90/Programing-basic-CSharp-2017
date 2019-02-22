using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine().ToLower();

            if (age >= 16)
            {
                switch (gender)
                {
                    case "m":
                        Console.WriteLine("Mr.");
                        break;
                    case "f":
                        Console.WriteLine("Ms.");
                        break;
                }
            }
            else if (age < 16)
            {
                switch (gender)
                {
                    case "m":
                        Console.WriteLine("Master");
                        break;
                    case "f":
                        Console.WriteLine("Miss");
                        break;
                }
            }
        }
    }
}
