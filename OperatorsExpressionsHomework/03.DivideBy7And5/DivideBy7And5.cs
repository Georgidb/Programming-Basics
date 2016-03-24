using System;


namespace _03.DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {
            Console.Write("Please, enter an integer: ");
            int inputNumber = Int32.Parse(Console.ReadLine());          
            if (inputNumber%7 == 0 && inputNumber%5 == 0)
            {
                bool compare = true;
                Console.WriteLine("Divided by 7 and 5? {0}", compare);
                
            }
            else
            {
                bool compare = false;
                Console.WriteLine("Divided by 7 and 5? {0}", compare);
            }

        }
    }
}
