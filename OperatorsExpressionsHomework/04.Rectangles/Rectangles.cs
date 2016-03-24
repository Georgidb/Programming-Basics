using System;


namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.Write("Please, enter width of rectangle: ");
            double width = Double.Parse(Console.ReadLine());
            Console.Write("Please, enter height of rectangle: ");
            double height = Double.Parse(Console.ReadLine());
            double perimeter = 2 * (width + height);
            double area = width * height;
            Console.WriteLine("The rectangle has perimeter {0} and area {1}", perimeter, area);
        }
    }
}
