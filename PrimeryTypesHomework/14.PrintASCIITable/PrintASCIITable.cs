using System;
using System.Text;


namespace _14.PrintASCIITable
{
    class PrintASCIITable
    {
        static void Main()
        {
            for (int i = 0; i <= 255; i++)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("{0} Symbol {1}", i, (char)i);
            }
            
        }
    }
}
