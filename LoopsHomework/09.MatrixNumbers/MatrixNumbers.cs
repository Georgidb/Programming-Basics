using System;

namespace _09.MatrixNumbers
{
    class MatrixNumbers
    {
        static void Main()
        {
            int n = 0;
            Console.Write("Please, enter number n: ");
            n = Int32.Parse(Console.ReadLine());
            if (n >= 1 && n <= 20)
            {
                for (int i = 1; i < (n + 1); i++)
                {
                    Console.Write("{0} ", i);

                    for (int j = i + 1; j < (i + n); j++)
                    {
                        Console.Write("{0} ", j);
                    }
                    Console.WriteLine();
                }                
            }
            else
            {
                Console.WriteLine("Please, enter correct value 1 <= n <= 20!");
            }
        }
    }
}
