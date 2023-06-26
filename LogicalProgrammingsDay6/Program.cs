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

            int number = 28;
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == number)
            {
                Console.WriteLine($"{number} is a perfect number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a perfect number.");
            }
        }

    }
}
