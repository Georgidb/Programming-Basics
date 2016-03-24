using System;


namespace _06.BiggestOf5Numbers
{
    class BiggestOf5Numbers
    {
        static void Main()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;
            double e = 0;
            Console.Write("Please, enter number a: ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Please, enter number b: ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("Please, enter number c: ");
            c = Double.Parse(Console.ReadLine());
            Console.Write("Please, enter number d: ");
            d = Double.Parse(Console.ReadLine());
            Console.Write("Please, enter number e: ");
            e = Double.Parse(Console.ReadLine());
            if (a >= b && a >= c && a >= d && a >= e)
            {
                double biggest = a;
                Console.WriteLine("biggest {0}", biggest);
                return;
            }
            if (b >= a && b >= c && b >= d && b >= e)
            {
                double biggest = b;
                Console.WriteLine("biggest {0}", biggest);
                return;
            }
            if (c >= a && c >= b && c >= d && c >= e)
            {
                double biggest = c;
                Console.WriteLine("biggest {0}", biggest);
                return;
            }
            if (d >= a && d >= b && d >= c && d >= e)
            {
                double biggest = d;
                Console.WriteLine("biggest {0}", biggest);
                return;
            }
            if (e >= a && e >= b && e >= c && e >= d)
            {
                double biggest = e;
                Console.WriteLine("biggest {0}", biggest);
                return;
            }
        }
    }
}
