using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            ////GCD 最大公倍數
            ////lcm 最小公因數
            int lcm = GCD(12, 6) * (12 / GCD(12, 6)) * (6 / GCD(12, 6));
            Console.WriteLine(GCD(GCD(15, 19),27));
            Console.WriteLine(lcm);
        }
        //求最大公因數
        public static int GCD(int num1, int num2)
        {
            if (num1 % num2 == 0)
                return num2;
            else
                return GCD(num2, num1 % num2);
        }
    }
}
