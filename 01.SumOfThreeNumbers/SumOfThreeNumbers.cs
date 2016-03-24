using System;


namespace _01.SumOfThreeNumbers
{
    class SumOfThreeNumbers
    {
        static void Main()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            Console.WriteLine("This is a program for addition of real numbers");
            Console.WriteLine("");
            Console.Write("Please, write the first number: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Please, write the second number: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Please, write the third number: ");
            c = double.Parse(Console.ReadLine());
            double sum = a + b + c;
            Console.WriteLine("The sum of {0}, {1} and {2} is {3}", a, b, c, sum);
        }
    }
}
