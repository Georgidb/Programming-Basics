using System;


namespace _01.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            int a = 0;
            int b = 0;
            Console.Write("Please, enter number a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Please, enter number b: ");
            b = Int32.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} {1}", b, a);             
            }
            else
            {
                Console.WriteLine("{0} {1}", a, b);
            }
            
        }
    }
}
