using System;


namespace _09.Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Console.Write("Please, enter side a = ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Please, enter side b = ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("Please, enter height h = ");
            double h = Double.Parse(Console.ReadLine());
            double area = ((a + b) / 2.0) * h;
            Console.WriteLine("The area of the trapezoid is {0}", area);


        }
    }
}
