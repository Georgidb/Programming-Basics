using System;


namespace _06.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Please, enter a four-digit positive integer number: ");
            int inputNumber = Int32.Parse(Console.ReadLine());
            int nDigit = inputNumber / 1000;
            int a = (inputNumber / 1000) % 10;
            int b = (inputNumber / 100) % 10;
            int c = (inputNumber / 10) % 10;
            int d = (inputNumber / 1) % 10;
            int sum = a + b + c + d;
            string reversed = d + "" + c + b + a;
            string lastFirstPosition = d + "" + a + b + c;
            string exchanged = a + "" + c + b + d;
            bool compare = (nDigit % 10) != 0;
            if (nDigit != 0 && compare == true) 
            {
                
                Console.WriteLine("number n {0}, sum of digits {1}, reversed {2}, last digit in front {3}, second and third digits exchanged {4}", 
                                   inputNumber, sum, reversed, lastFirstPosition, exchanged);
                
            } 

        }
    }
}
