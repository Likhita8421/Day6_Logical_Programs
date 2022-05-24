using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    internal class SquareRoot
    {
        string x;
        double rootofx;
        Console.WriteLine("Enter a Number:");
            x = Console.ReadLine();
            rootofx = Math.Sqrt(Convert.ToInt32(x));
            Console.WriteLine("\nSqrt({0}): {1}", x, rootofx);
            Console.ReadKey();
    }
}
