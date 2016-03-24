using System;
using System.Text;



namespace _08.IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            char specialSymbol = '\u00A9';
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("{0,4}\n{0,3}{0,2}\n{0,2}{0,4}\n{0}{0,2}{0,2}{0,2}", specialSymbol);
            // If the console does not display the symbol correctly, please change your console Font to Consolas (right click on the console window -> Properties -> Fonts -> Consolas);
            
        }
    }
}
