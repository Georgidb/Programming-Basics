using System;


namespace _10.PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main()
        {
            Console.Write("Please, enter value for x = ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("Please, enter value for y = ");
            double y = Double.Parse(Console.ReadLine());
            bool compare1 = x > -0.5 && x < 2.5 && y <= 2.5 && y > 1;
            bool compare2 = x >= -1 && x <= 5 && y >= -1 && y <= 1;
            bool compare3 = x <= -0.5 && x >= 2.5 && y > 1;
            bool compare4 = x <= -0.5 && x >= 2.5 && y < 2.5;
            bool compare5 = x > -0.5 && x < 2.5 && y <= 2.5 && y > 1;
            if (compare1)
            {
                string result = "yes";
                Console.WriteLine("x = {0}, y = {1}; inside K and outside R: {2}", x, y, result);              
            }
            else
            {
                if (compare2 || compare3 || compare4)
                {
                    string result = "no";
                    Console.WriteLine("x = {0}, y = {1}; inside K and outside R: {2}", x, y, result);
                }

            }
        }
    }
}
