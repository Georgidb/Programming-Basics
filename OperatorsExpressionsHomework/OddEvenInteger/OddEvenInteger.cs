using System;


namespace OddEvenInteger
{
    class OddEvenInteger
    {
        static void Main()
        {
            Console.Write("Please, enter integer number: ");
            int inputNumber = Int32.Parse(Console.ReadLine());
            if (inputNumber % 2 != 0)
            {
                bool oddNumber = true;
                Console.WriteLine("Odd? {0}", oddNumber);
                
            }

            else
            {
                Console.WriteLine("Odd? {0}", false);
            }
        }
    }
}
