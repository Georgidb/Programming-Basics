using System;


namespace _08.DigitAsWord
{
    class digitAsWord
    {
        static void Main()
        {                     
            try
            {
                Console.Write("Please, enter a digit: ");
                int digit = Int32.Parse(Console.ReadLine());
                switch (digit)
                {
                    case 0:
                        Console.WriteLine("result: zero");
                        break;
                    case 1:
                        Console.WriteLine("result: one");
                        break;
                    case 2:
                        Console.WriteLine("result: two");
                        break;
                    case 3:
                        Console.WriteLine("result: three");
                        break;
                    case 4:
                        Console.WriteLine("result: four");
                        break;
                    case 5:
                        Console.WriteLine("result: five");
                        break;
                    case 6:
                        Console.WriteLine("result: six");
                        break;
                    case 7:
                        Console.WriteLine("result: seven");
                        break;
                    case 8:
                        Console.WriteLine("result: eight");
                        break;
                    case 9:
                        Console.WriteLine("result: nine");
                        break;
                    default:
                        Console.WriteLine("Not a digit");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a digit");               
            }          
        }
    }
}
