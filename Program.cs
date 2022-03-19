using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _254008_L01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valSeed;
            int numItems;

            Console.WriteLine("Value of seed:");
            valSeed = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of items:");
            numItems = int.Parse(Console.ReadLine());

            Problem problem = new Problem(valSeed, numItems);

            Console.WriteLine(problem.ToString());
            Console.WriteLine(problem.solveFor(50));

            Console.ReadLine();
        }
    }
}
