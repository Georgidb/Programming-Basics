using System;
using System.Numerics;

namespace _05.Calculate
{
    class Calculate
    {
        static void Main()
        {
            int n = 0;
            decimal x = 0;
            Console.Write("Please, enter value for n: ");
            n = Int32.Parse(Console.ReadLine());
            Console.Write("Please, enter value for x: ");
            x = Int64.Parse(Console.ReadLine());
            decimal finalSum = 0;
            decimal middleSum = 0;
            decimal product1 = 1;
            decimal product2 = 1;
            for (int i = 1; i <= n; i++)
            {
                product1 *= i;
                product2 *= x;
                middleSum += product1 / product2;
            }
            finalSum = 1 + middleSum;
            Console.WriteLine("{0:F5}", finalSum);
        }
    }
}
