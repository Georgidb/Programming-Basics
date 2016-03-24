using System;
using System.Linq;

namespace _03.MinMaxSumAverage
{
    class MinMaxSumAverage
    {
        static void Main()
        {
            int n = 0;
            Console.Write("Please, enter the value of n: ");           
            n = Int32.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("min = {0}", numbers.Min());
            Console.WriteLine("max = {0}", numbers.Max());
            Console.WriteLine("sum = {0}", numbers.Sum());
            Console.WriteLine("avg = {0:F2}", numbers.Average());

        }
    }
}
