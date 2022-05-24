using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    internal class Vending_Machine
    {
        public void moneychanger()
        {
            Console.WriteLine("Enter an amount");
            int money = Convert.ToInt32(Console.ReadLine());
            int[] havingleNotes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] change = new int[9];
            int startinglIndex = 0, totalIndex = 8;


            while (startinglIndex < totalIndex)
            {
                if (money >= havingleNotes[startinglIndex])
                {
                    change[startinglIndex] = money / havingleNotes[startinglIndex];
                    money = money - (change[startinglIndex] * havingleNotes[startinglIndex]);
                }

                startinglIndex++;
            }

            Console.WriteLine("Change for an Entered Amount:");
            startinglIndex = 0;
            while (startinglIndex < totalIndex)
            {
                Console.WriteLine(havingleNotes[startinglIndex] + " Notes are: " + change[startinglIndex]);
                startinglIndex++;
            }


        }
    }
}
