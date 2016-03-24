using System;


namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.Write("Please, enter a positive integer number n<=100: ");
            int n = Int32.Parse(Console.ReadLine());
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime);        
        }
    }
}
