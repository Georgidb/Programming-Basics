using System;


namespace _14.ModifyBitGivenPosition
{
    class ModifyBitGivenPosition
    {
        static void Main()
        {
            Console.Write("Please, enter a positive integer number: n = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Please, enter position p of the bits: p = ");
            int p = Int32.Parse(Console.ReadLine());
            Console.Write("Please, enter bit value 0 or 1: v = ");
            int v = Int32.Parse(Console.ReadLine());
            int numberShifted = n >> p;
            int mask = 1;
            int result = numberShifted & mask;
            string binary = Convert.ToString(n, 2).PadLeft(16, '0');
            bool compare1 = result != v;          
            if (compare1)
            {
                if (v == 0 && result == 1)
                {
                    int mask2 = 1 << p;
                    int newResult = n ^ mask2;
                    string binaryResult = Convert.ToString(newResult, 2).PadLeft(16, '0');
                    Console.WriteLine("Entered number n = {0}, binary {1}, p = {2}, v = {3}, binary result {4}, result = {5}",
                n, binary, p, v, binaryResult, newResult);                 
                }
                if (v == 1 && result == 0)
                {
                    int mask2 = 1 << p;
                    int newResult = n | mask2;
                    string binaryResult = Convert.ToString(newResult, 2).PadLeft(16, '0');
                    Console.WriteLine("Entered number n = {0}, binary {1}, p = {2}, v = {3}, binary result {4}, result = {5}",
                n, binary, p, v, binaryResult, newResult);
                    
                }                      
            }
            else
            {
                string binaryResult = binary;
                int newResult = n;
                Console.WriteLine("Entered number n = {0}, binary {1}, p = {2}, v = {3}, binary result {4}, result = {5}",
                n, binary, p, v, binaryResult, newResult);             
            }
        }
    }
}
