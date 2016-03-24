using System;


namespace _07.QuotesInStrings
{
    class QuotesStrings
    {
        static void Main()
        {
            string firstWay = "The \"use\" of quotations causes difficalties.";
            string secondWay = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(firstWay);
            Console.WriteLine(secondWay);
        }
    }
}
