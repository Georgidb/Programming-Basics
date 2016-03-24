using System;


namespace _13.ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            System.IFormatProvider dotDecimal = new System.Globalization.CultureInfo("en-US");
            Console.Write("Please, enter the first comparing number (only float numbers): ");
            double num1 = double.Parse(Console.ReadLine(), dotDecimal);
            Console.Write("Please, enter the second comparing number (only float numbers): ");
            double num2 = double.Parse(Console.ReadLine(), dotDecimal);
            const double eps = 0.000001;
            double difference = Math.Abs(num1 - num2);
            if (difference >= eps)
            {
                Console.WriteLine("The comparing numbers {0} and {1} are different", num1, num2);        
            }
            else
            {
                Console.WriteLine("The comparing numbers {0} and {1} are equal", num1, num2);
            }
        }
    }
}
