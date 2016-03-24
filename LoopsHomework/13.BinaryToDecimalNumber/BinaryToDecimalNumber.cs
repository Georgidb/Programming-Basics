using System;

namespace _13.BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main()
        {
            string binary = String.Empty;
            Console.Write("Please, enter a binary number: ");
            binary = Console.ReadLine();
            int power = 0;
            long decimalResult1 = 0;
            long decimalResult2 = 0;
            long decimalResult3 = 0;
            long powerTwo = 0;
            
            for (int i = (binary.Length - 1); i >= 0; i--)
            {
                power = (binary.Length - (i + 1));
                powerTwo = (long)Math.Pow(2, power);
                long numberConverted = (long)binary[i];

                if (binary[i] == 49)
                {
                    numberConverted = 1;
                    decimalResult1 += numberConverted * powerTwo;
                }
                if (binary[i] == 48)
                {
                    numberConverted = 0;
                    decimalResult2 += numberConverted * powerTwo;                  
                }               
            }
            decimalResult3 = decimalResult1 + decimalResult2;

            Console.WriteLine("Binary: {0} --> Decimal: {1}", binary, decimalResult3);
        }
    }
}
