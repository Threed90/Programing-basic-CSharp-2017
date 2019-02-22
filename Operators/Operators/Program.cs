using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char operators = char.Parse(Console.ReadLine());

            bool even = (N1 + N2) % 2 == 0 ;
            bool odd = (N1 + N2) % 2 != 0 ;

            
            if (operators == '+')
            {
                if (even)
                {
                    int plus = N1 + N2;
                    Console.WriteLine($"{N1} {operators} {N2} = {plus} - even");
                }
                else if (odd)
                {
                    int plus = N1 + N2;
                    Console.WriteLine($"{N1} {operators} {N2} = {plus} - odd");
                }
            }
            else if (operators == '-')
            {
                int minus = N1 - N2;
                if (even)
                {
                    Console.WriteLine($"{N1} {operators} {N2} = {minus} - even");
                }
                else if (odd)
                {
                    Console.WriteLine($"{N1} {operators} {N2} = {minus} - odd");
                }
            }
            else if (operators == '*')
            {
                int multiplication = N1 * N2;
                if (even)
                {
                    Console.WriteLine($"{N1} {operators} {N2} = {multiplication} - even");
                }
                else if (odd)
                {
                    Console.WriteLine($"{N1} {operators} {N2} = {multiplication} - odd");
                }
            }
            else if (operators == '/')
            {
                double divide = (double)N1 / (double)N2;
                if (N2 == 0)
                {
                   Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                Console.WriteLine($"{N1} / {N2} = {divide:f2}");
            }
            else if (operators == '%')
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                Console.WriteLine($"{N1} % {N2} = {N1 % N2}");
            }
        }
    }
}
