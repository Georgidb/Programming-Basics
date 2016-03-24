using System;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            int n = 0;
            Console.Write("Please, enter value for n: ");
            n = Int32.Parse(Console.ReadLine());
            BigInteger catalan = 1;
            BigInteger productN = 1;
            BigInteger product1 = 1;
            BigInteger product2 = 1;
            if (n > 1 && n < 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    productN *= i;                   
                }
                for (int j = 1; j <= 2 * n; j++)
                {
                    product2 *= j;                   
                }
                for (int k = 1; k <= (n + 1); k++)
                {
                    product1 *= k;
                }
                catalan = product2 / (product1 * productN);
                Console.WriteLine(catalan);              
            }
            else
            {
                Console.WriteLine("Please, enter correct value for 1 < n < 100!");
            }

        }
    }
}
