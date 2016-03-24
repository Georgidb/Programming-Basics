using System;

namespace AgainPrintLongSequence16
{
    class Again16
    {
        static void Main()
        {
            char comma = ',';
            for (int i = 2, j = -3; i <= 1000; i += 2, j -= 2)
            {
                if (i < 1000)
                {
                    Console.Write("{0}{1}{2}{1}", i, comma, j);
                }
                if (i == 1000)
                {
                    Console.Write("{0}{1}{2}", i, comma, j);
                }
            }
            Console.WriteLine();
        }
    }
}
