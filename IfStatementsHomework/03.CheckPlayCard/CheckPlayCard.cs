using System;


namespace _03.CheckPlayCard
{
    class CheckPlayCard
    {
        static void Main()
        {
            int cardNumber1 = 0;
            Console.Write("Please, enter a card sign: ");
            string cardNumber2 = (Console.ReadLine());
            if (cardNumber2 == "A" || cardNumber2 == "J" || cardNumber2 == "K" || cardNumber2 == "Q")
            {
                Console.WriteLine("Valid card sign?" + " " + "yes");
            }
            else
            {
                try
                {
                    cardNumber1 = Int32.Parse(cardNumber2);

                    if (cardNumber1 >= 2 && cardNumber1 <= 10)
                    {
                        Console.WriteLine("Valid card sign?" + " " + "yes");
                    }
                    else
                    {
                        Console.WriteLine("Valid card sign?" + " " + "no");
                    }

                }
                catch (FormatException)
                {
                    
                    Console.WriteLine("Valid card sign?" + " " + "no");
                }
                
            }           
        }
    }
}
