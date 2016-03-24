using System;
using System.Text;

namespace _04.PrintDeck52Cards
{
    class PrintDeck52Cards
    {
        static void Main()
        {
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        int[] colors = { 3, 4, 5, 6 };

        foreach (var card in cards)
        {
            foreach (var color in colors)
            {
                Console.Write(card);
                Console.Write((char)color + " ");
            }

            Console.WriteLine();
        }


            //Console.OutputEncoding = Encoding.Unicode;
            //string two = "2";
            //string three = "3";
            //string four = "4";
            //string five = "5";
            //string six = "6";
            //string seven = "7";
            //string eight = "8";
            //string nine = "9";
            //string ten = "10";
            //string ace = "A";
            //string jack = "J";
            //string king = "K";
            //string queen = "Q";
            //char spade = '\u2664';
            //char heart = '\u2661';
            //char diamonds = '\u9826';
            //char club = '\u2667';
            //for (int i = 2; i <= 10; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.WriteLine("{0} ", i);
            //        switch (i)
            //        {
            //            case 2:
            //                Console.WriteLine();


            //            default:
            //        }
                    

            //    }
            //}   
        }
    }
}
