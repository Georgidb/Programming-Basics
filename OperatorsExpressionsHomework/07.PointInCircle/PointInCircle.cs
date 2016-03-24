using System;


namespace _07.PointInCircle
{
    class PointInCircle
    {
        static void Main()
        {
            Console.Write("Please, enter value for x: ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("Please, enter value for y: ");
            double y = Double.Parse(Console.ReadLine());
            bool compare1 = x >= -2 && x <= 2;
            bool compare2 = y >= -2 && y <= 2;
            if (compare1 && compare2)
            {
                Console.WriteLine("The given point x = {0}, y = {1} is in the circle: {2}", x, y, true); 
            }
            else
            {
                Console.WriteLine("The given point x = {0}, y = {1} is in the circle: {2}", x, y, false);           
            }
        }
    }
}
