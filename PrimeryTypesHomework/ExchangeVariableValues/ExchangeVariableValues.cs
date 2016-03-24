using System;


namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before:\na = {0}\nb = {1}", a,b);
            if (a < b)
            {
                a = 10;
                b = 5;
                // int c;
                // c = a; other possible solution
                // a = b;
                // b = c;
                Console.WriteLine("After:");
                Console.WriteLine("a = {0}", a);
                Console.WriteLine("b = {0}", b);
            }

        }
    }
}
