using System;
using System.Globalization;

namespace AgainSomeExercises
{
    class Again09
    {
        static void Main()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            char comma = ',';
            for (int i = 2, j = -3; i <= 10; i += 2, j -= 2)
            {
                if (i < 10)
                {
                    Console.Write("{0}{1}{2}{1}", i, comma, j);                   
                }
                if (i == 10)
                {
                    Console.Write("{0}{1}{2}", i, comma, j);
                }              
            }
            Console.WriteLine();
        }
    }
}
