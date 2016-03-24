using System;

namespace _16.PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            
          
            for (int i = 2, j = -3; i <= 1000; i += 2, j += -2)
            {
                Console.Write("{0}, {1}, ", i, j);
                
            }
         
        }
    }
}
