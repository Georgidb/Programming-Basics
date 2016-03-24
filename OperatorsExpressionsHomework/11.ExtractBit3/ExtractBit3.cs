using System;


namespace _11.ExtractBit3
{
    class ExtractBit3
    {
        static void Main()
        {
            Console.Write("Please, enter a positive integer number: ");
            int n = Int32.Parse(Console.ReadLine());
            int mask = 1;
            int binaryShifted = n >> 3;
            int result = binaryShifted & mask;
            string binary = Convert.ToString(n, 2).PadLeft(16, '0');
            Console.WriteLine("Entered number n = {0}, binary {1}, bit#3 = {2}", n, binary, result);
        }
    }
}
