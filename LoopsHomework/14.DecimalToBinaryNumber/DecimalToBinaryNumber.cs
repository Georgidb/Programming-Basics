using System;
using System.Collections.Generic;

namespace _14.DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
        static void Main()
        {
            long inputNumber = 0;
            Console.Write("Please, enter decimal number: ");
            inputNumber = Int64.Parse(Console.ReadLine());
            long dividedAll = 0;
            long dividedMod = 0;
            List<long> binary = new List<long>();

            do
            {
                dividedAll = inputNumber / 2;
                dividedMod = inputNumber % 2;
                inputNumber = dividedAll;
                binary.Add(dividedMod);
                dividedAll--;
               
            } while (dividedAll >= 0);

            binary.Reverse();

            foreach (var item in binary)
            {
                Console.Write(item.ToString());             
            }
            Console.WriteLine();
        }
    }
}
