using System;


namespace _12.ZeroSubset
{
    class ZeroSubset
    {
        static void Main()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            Console.Write("Please, enter integer number a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Please, enter integer number b: ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("Please, enter integer number c: ");
            c = Int32.Parse(Console.ReadLine());
            Console.Write("Please, enter integer number d: ");
            d = Int32.Parse(Console.ReadLine());
            Console.Write("Please, enter integer number e: ");
            e = Int32.Parse(Console.ReadLine());
            if (a == -(b) || a == -(b + c) || a == -(b + c + d) || a == -(b + c + d + e) || b == -(a) || b == -(a + c) || b == -(a + c + d) || 
                b == -(a + c + d + e))
            {
                int result1 = a + b;
                int result2 = a + b + c;
                int result3 = a + b + c + d;
                int result4 = a + b + c + d + e;
                int result5 = a + c;
                int result6 = a + d;
                int result7 = a + e;
                int result21 = a + c + d;
                int result22 = a + c + d + e;

                int result8 = b + c;
                int result9 = b + d;
                int result10 = b + e;
                int result11 = b + c + d;
                int result12 = b + c + d + e;
                int result13 = b + d + e;
                int result14 = b + a + d;
                int result15 = b + a + d + e;

                int result16 = c + d;
                int result17 = c + e;
                //int result18 = c + a + d;
                int result19;

                int result20 = d + e;
                //int result23 = d + a + b;
                int result24 = d + a + e;
                int result25 = d + c + e;
                //int result30 = d + b + a;

                int result26 = e + a + b;
                int result27 = e + a + c;
                int result28 = e + b + c;
                int result29 = e + b + c + a;

                if (result1 == 0)
                {
                    Console.WriteLine(a + b);               
                }
                if (result2 == 0)
                {
                    Console.WriteLine(a + b + c);                
                }
                if (result3 == 0)
                {
                    Console.WriteLine(a + b + c + d);                  
                }
                if (result4 == 0)
                {
                    Console.WriteLine(a + b + c + d + e);   
                }
                if (result5 == 0)
                {
                    Console.WriteLine(a + c);                  
                }
                if (result6 == 0)
                {
                    Console.WriteLine(a + d);                
                }
                if (result7 == 0)
                {
                    Console.WriteLine(a + e);                   
                }
                if (result8 == 0)
                {
                    Console.WriteLine(b + c);                  
                }
                if (result9 == 0)
                {
                    Console.WriteLine(b + d);                  
                }
                if (result10 == 0)
                {
                    Console.WriteLine(b + e);                   
                }
                if (result11 == 0)
                {
                    Console.WriteLine(b + c + d);                  
                }
                if (result12 == 0)
                {
                    Console.WriteLine(b + c + d + e);                   
                }
                
            }
            else
            {
                Console.WriteLine("no zero subset");
            }
        }
    }
}
