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

            int count = 10; // Number of terms to be displayed
            int firstTerm = 0, secondTerm = 1, nextTerm;

            Console.WriteLine("Fibonacci Series:");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(firstTerm);

                nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }
        }

    }
}
