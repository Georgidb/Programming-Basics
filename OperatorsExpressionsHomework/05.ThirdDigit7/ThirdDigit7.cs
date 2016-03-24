using System;


namespace _05.ThirdDigit7
{
    class ThirdDigit7
    {
        static void Main()
        {
            Console.Write("Please, enter an integer: ");
            int inputNumber = Int32.Parse(Console.ReadLine());
            int nDigit = (inputNumber / 100) % 10;
            bool compare = nDigit == 7;           
            Console.WriteLine("Third digit 7? {0}", compare);
        }
    }
}
