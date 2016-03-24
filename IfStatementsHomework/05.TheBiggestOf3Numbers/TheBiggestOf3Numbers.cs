using System;


namespace _05.TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            Console.Write("Please, enter number a: ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Please, enter number b: ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("Please, enter number c: ");
            c = Double.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                double biggest = a;
                Console.WriteLine("{0} {1} {2}; biggest {3}", a, b, c, biggest);
            }
            if (a < b && a < c)
            {
                double biggest = b;
                Console.WriteLine("{0} {1} {2}; biggest {3}", a, b, c, biggest);
                
            }
            else
            {
                double biggest = c;
                Console.WriteLine("{0} {1} {2}; biggest {3}", a, b, c, biggest);
            }
        }
    }
}
