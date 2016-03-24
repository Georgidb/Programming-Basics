using System;


namespace _12.ExtractBitInteger
{
    class ExtractBitInteger
    {
        static void Main()
        {
            Console.Write("Please, enter a positive integer number: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Please, enter position p of the bits: ");
            int p = Int32.Parse(Console.ReadLine());
            bool compare = p >= 0 && p <= 32;
            int numberShifted = n >> p;
            int mask = 1;
            if (compare)
            {
                int result = numberShifted & mask;
                string binary = Convert.ToString(n, 2).PadLeft(16, '0');
                Console.WriteLine("Entered number n = {0}, binary {1}, p = {2}, bit @ p = {3}", n, binary, p, result);               
            }
            else
            {
                Console.WriteLine("Please, enter correctly position 0 <= p <= 32");
            }
        }
    }
}
