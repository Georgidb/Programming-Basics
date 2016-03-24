using System;

namespace _16.DecimalToHexadecimalNumber
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            long inputNumber = 0;
            Console.Write("Please, enter a decimal number: ");
            inputNumber = Int64.Parse(Console.ReadLine());
            string hexaDecimal = String.Empty;

            if (inputNumber == 0)
            {
                hexaDecimal = "0";
            }
            else
            {
                while (inputNumber > 0)
                {
                    long remainder = inputNumber % 16;
                    inputNumber = inputNumber / 16;
                    switch (remainder)
                    {
                        case 10: hexaDecimal = "A" + hexaDecimal; 
                            break;
                        case 11: hexaDecimal = "B" + hexaDecimal; 
                            break;
                        case 12: hexaDecimal = "C" + hexaDecimal; 
                            break;
                        case 13: hexaDecimal = "D" + hexaDecimal; 
                            break;
                        case 14: hexaDecimal = "E" + hexaDecimal; 
                            break;
                        case 15: hexaDecimal = "F" + hexaDecimal; 
                            break;
                        default: hexaDecimal = remainder + hexaDecimal; 
                            break;
                    }
                }
            }

            Console.WriteLine(hexaDecimal);      
        }
    }
}
