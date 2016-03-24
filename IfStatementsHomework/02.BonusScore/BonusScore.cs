using System;


namespace _02.BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            int score = 0;
            Console.Write("Please, enter a score number: ");
            score = Int32.Parse(Console.ReadLine());
            if (score >= 1 && score <= 3)
            {
                int result = score * 10;
                Console.WriteLine(result);               
            }
            if (score >= 4 && score <= 6)
            {
                int result = score * 100;
                Console.WriteLine(result);
            }
            if (score >= 7 && score <= 9)
            {
                int result = score * 1000;                
            }
            if (score >= 10 || score <= 0)
	        {
                Console.WriteLine("Invalid score");		 
	        }
            
        }
    }
}
