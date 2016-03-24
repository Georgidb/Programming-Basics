using System;
using System.Numerics;

namespace _06.CalculateFactorial
{
    class CalculateFactorial
    {
        static void Main()
        {
            int n = 0;
            double k = 0;
            BigInteger division = 1;
            BigInteger productN = 1;
            BigInteger productK = 1;
            Console.Write("Please, enter value n: ");
            n = Int32.Parse(Console.ReadLine());
            Console.Write("Please, enter value k: ");
            k = Double.Parse(Console.ReadLine());
            if (k > 1 && n > k && n < 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    productN *= i;
                    if (k >= i)
                    {
                        productK *= i;                      
                    }                   
                }
                division = productN / productK;
                Console.WriteLine(division);
            }
            else
            {
                Console.WriteLine("Please, enter correct values 1 < k < n < 100!");
            }
        }
    }
}
