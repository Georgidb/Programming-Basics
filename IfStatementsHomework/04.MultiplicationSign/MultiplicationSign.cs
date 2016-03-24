using System;


namespace _04.MultiplicationSign
{
    class MultiplicationSign
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
            if (a > 0 && b > 0 && c > 0 || a > 0 && b < 0 && c < 0 || a < 0 && b < 0 && c > 0 || a < 0 && b > 0 && c < 0)
            {
                string result = "+";
                Console.WriteLine("{0} {1} {2} {3}", a, b, c, result);                
            }
            if (a < 0 && b < 0 && c < 0 || a > 0 && b > 0 && c < 0 || a > 0 && b < 0 && c > 0 || a < 0 && b > 0 && c > 0)
            {
                string result = "-";
                Console.WriteLine("{0} {1} {2} {3}", a, b, c, result);
                
            }
            if (a == 0 || b == 0 || c == 0)
            {
                string result = "0";
                Console.WriteLine("{0} {1} {2} {3}", a, b, c, result);
            }
        }
    }
}
