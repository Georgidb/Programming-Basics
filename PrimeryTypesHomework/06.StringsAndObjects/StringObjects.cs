using System;


namespace _06.StringsAndObjects
{
    class StringObjects
    {
        static void Main()
        {
            string part1 = "Hello";
            string part2 = "World";
            object together = part1 + " " + part2;
            string part3 = (string)together;
            Console.WriteLine(together);
        }
    }
}
