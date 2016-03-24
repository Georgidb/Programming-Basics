using System;
using System.Numerics;

namespace _07.CalculateCombinations
{
    class CalculateCombinations
    {
        static void Main()
        {
            double n = 0;
            double k = 0;
            BigInteger division = 1;
            BigInteger productN = 1;
            BigInteger productK = 1;
            BigInteger productNK = 1;
            Console.Write("Please, enter value for n: ");
            n = Double.Parse(Console.ReadLine());
            Console.Write("Please, enter value for k: ");
            k = Double.Parse(Console.ReadLine());
            if (k > 1 && k < n && n < 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    productN *= i;
                    if (k >= i)
                    {
                        productK *= i;                       
                    }                    
                }
                for (int j = 1; j <= (n - k); j++)
                {
                    productNK *= j;
                    
                }
                division = (productN) / (productK * productNK);
                Console.WriteLine(division);
            }
            else
            {
                Console.WriteLine("Please, enter correct values 1 < k < n < 100!");
            }
        }
    }
}
