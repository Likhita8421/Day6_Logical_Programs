using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    internal class CouponNumbers
    {
        int CouponCount = 0, CouponCnt = 0, number;
        Random rand = new Random();
        List<int> couponNumber = new List<int>();

        public void coupon()
        {
            Console.WriteLine("Enter Value for coupon you want");
            number = Convert.ToInt32(Console.ReadLine());
            while (CouponCnt < number)
            {
                int couponNo = rand.Next();
                CouponCount++;
                if (!couponNumber.Contains(couponNo))
                {
                    couponNumber.Add(couponNo);
                    CouponCnt++;
                }
            }
            foreach (int coupon in couponNumber)
            {
                Console.WriteLine(coupon);
            }
            Console.WriteLine("Number of times coupon generated is " + CouponCount);
        }
    }
    
}
