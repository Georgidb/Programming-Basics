using System;


namespace _01.NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            int inputNumber = 0;
           
            try 
	{             
            do
            {
                Console.Write("Please, enter a positive integer number: ");
                inputNumber = Int32.Parse(Console.ReadLine());

            } while (inputNumber <= 0);
                             
        if (inputNumber > 0)
        {           
                for (int i = 1; i <= inputNumber; i++)
                {
                    Console.Write("{0} ", i);
                }                      
        }        
	}
	catch (FormatException)
	{
		
		Console.WriteLine("Please, enter valid positive integer!");
	}
        }

    }
}
