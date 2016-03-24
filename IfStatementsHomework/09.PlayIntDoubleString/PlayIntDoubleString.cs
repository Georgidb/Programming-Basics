using System;


namespace _09.PlayIntDoubleString
{
    class PlayIntDoubleString
    {
        static void Main()
        {
            Console.Write("Please, choose a type:\n1 --> int\n2 --> double\n3 --> string\nuser: ");
            int chooseType = 0;
            chooseType = Int32.Parse(Console.ReadLine());
            switch (chooseType)
            {
                case 1:
                    Console.Write("Please, enter an integer: ");
                    int typeInteger = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(typeInteger + 1);
                    break;
                case 2:
                    Console.Write("Please, enter a double: ");
                    double typeDouble = Double.Parse(Console.ReadLine());
                    Console.WriteLine(typeDouble + 1);
                    break;
                case 3:
                    Console.Write("Please, enter a string: ");
                    string typeString = Console.ReadLine();
                    Console.WriteLine(typeString + "*" );
                    break;
                default:
                    Console.WriteLine("Please, choose between 1, 2 or 3");
                    break;
            }
        }
    }
}
