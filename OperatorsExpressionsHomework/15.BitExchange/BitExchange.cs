using System;


namespace _15.BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            Console.Write("Please, enter a positive integer number: n = ");
            
            int n = Int32.Parse(Console.ReadLine());
            int numberShifted1 = n >> 3;
            int mask = 1;
            int result1 = numberShifted1 & mask;
            int numberShifted2 = n >> 4;
            int result2 = numberShifted2 & mask;
            int numberShifted3 = n >> 5;
            int result3 = numberShifted3 & mask;
            int numberShifted4 = n >> 24;
            int result4 = numberShifted4 & mask;
            int numberShifted5 = n >> 25;
            int result5 = numberShifted5 & mask;
            int numberShifted6 = n >> 26;
            int result6 = numberShifted6 & mask;
            int maskNull = 7 << 3; //00111000
            int maskNullConverted = ~ maskNull; // 11000111
            int firstResult = n & maskNullConverted;
            int maskWrite1 = result4 << 3;
            int maskWrite2 = result5 << 4;
            int maskWrite3 = result6 << 5;
            int firstWrite = firstResult | maskWrite1;
            int secondWrite = firstWrite | maskWrite2;
            int thirdWrite = secondWrite | maskWrite3;
            int maskNull2 = 7 << 24;
            int maskNullConverted2 = ~ maskNull2;
            int secondResult = thirdWrite & maskNullConverted2;
            int maskWrite4 = result1 << 24;
            int maskWrite5 = result2 << 25;
            int maskWrite6 = result3 << 26;
            int fourthWrite = secondResult | maskWrite4;
            int fifthWrite = fourthWrite | maskWrite5;
            int sixthWrite = fifthWrite | maskWrite6;
            string binary = Convert.ToString(n, 2).PadLeft(32, '0');
            string binaryResult = Convert.ToString(sixthWrite, 2).PadLeft(32, '0');
            Console.WriteLine("Entered number n = {0}, binary of n {1}, binary result {2}, result = {3}",
                n, binary, binaryResult, sixthWrite);
        }
    }
}