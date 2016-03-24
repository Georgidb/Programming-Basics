using System;


namespace _12.NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? number1 = null;
            Nullable<double> number2 = null;
            Console.WriteLine("These are two numbers with nullable values: number1 = {0} and number2 = {1}", number1, number2);
            number1 += 100;
            number2 += 100.45;
            Console.WriteLine("These are two numbers with added values: number1 = {0} and number2 = {1}", number1, number2);

        }
    }
}
