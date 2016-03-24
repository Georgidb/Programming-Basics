using System;


namespace _07.Sort3Numbers
{
    class Sort3Numbers
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
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                    
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
                
            }
            if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                    
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
                
            }
            if (c > a && c > b)
            {
                if (a > b)
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);                   
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
                
            }
        }

    }
}
