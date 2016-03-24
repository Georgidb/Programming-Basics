using System;


namespace _02.NumbersNotDivisible3And7
{
    class NumbersNotDivisible
    {
        static void Main()
        {
            int inputNumber = 0;
            try
            {
                do
                {
                    Console.Write("Please, enter a positive integer: ");
                    inputNumber = Int32.Parse(Console.ReadLine());
                    
                } while (inputNumber <= 0);

                if (inputNumber > 0)
                {
                    for (int i = 1; i <= inputNumber; i++)
                    {
                        if (i % 3 != 0 && i % 7 != 0)
                        {
                            Console.Write("{0} ", i);                          
                        }                       
                    }
                    
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Please, enter a positive integer!"); ;
            }
        }
    }
}
