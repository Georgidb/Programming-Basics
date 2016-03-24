using System;

namespace _11.RandomNumbersGivenRange
{
    class RandomNumbersGivenRange
    {
        static void Main()
        {
            int n = 0;
            int min = 0;
            int max = 0;
            Console.Write("Please, enter value for n: ");
            n = Int32.Parse(Console.ReadLine());
            Console.Write("Please, enter value for min: ");
            min = Int32.Parse(Console.ReadLine());
            Console.Write("Please, enter value for max: ");
            max = Int32.Parse(Console.ReadLine());
            if (min < max)
            {
                Random minmax = new Random();
                int[] numbers = new int[n];
                
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = minmax.Next(min, max);
                    Console.Write("{0} ", numbers[i]);           
                }               
            }
            else
            {
                Console.WriteLine("Please, enter correct values min < max!");
            }
        }
    }
}
