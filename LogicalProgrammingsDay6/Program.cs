using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingsDay6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 12345;
            int reverse = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number /= 10;
            }

            Console.WriteLine($"Reversed number: {reverse}");
        
        }

    }
}
