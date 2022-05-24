using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    internal class MonthlyPayment
    {
        public void moneyIntrest()
        {
            double p, y, R, n, r, payment;
            Console.WriteLine("Enter the years");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the intrest for principal:");
            p = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the intrest for percent: ");
            R = double.Parse(Console.ReadLine());
            n = 12 * y;
            r = R / (12 * 100);
            payment = (p * r) / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine("your monthly payment is: " + payment);
        }
    }
}
