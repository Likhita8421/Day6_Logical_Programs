using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    internal class DayOfWeek
    {
        public void DayMonth()
        {
            int x, y, m, d;
            string[] WeekDays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Enter a date:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Month:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a year:");
            int year = int.Parse(Console.ReadLine());

            y = year - (14 - month) / 12;
            x = y + y / 4 - y / 100 + y / 400;
            m = month + 12 * ((14 - month) / 12) - 2;
            d = (day + x + (31 * m) / 12) % 7;

            Console.WriteLine("its a " + WeekDays[d]);
        }
    }
}
