using System;

namespace _15.HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main()
        {
            string hexadecimal = String.Empty;
            Console.Write("Please, enter a hexadecimal number: ");
            hexadecimal = Console.ReadLine();
            int power = 0;
            long hexaDecimalResult0 = 0;
            long hexaDecimalResult = 0;
            long powerSixteen = 0;

            for (int i = (hexadecimal.Length - 1); i >= 0; i--)
            {
                power = (hexadecimal.Length - (i + 1));
                powerSixteen = (long)Math.Pow(16, power);
                long numberConverted = 1;

                switch (hexadecimal[i])
                {
                    case '0':
                        numberConverted = 0;
                        hexaDecimalResult0 = numberConverted * powerSixteen;
                        break;
                    case '1':
                        numberConverted = 1;
                        hexaDecimalResult0 = numberConverted * powerSixteen;
                        break;
                    case '2':
                        numberConverted = 2;
                        hexaDecimalResult0 = numberConverted * powerSixteen;
                        break;
                    case '3':
                        numberConverted = 3;
                        hexaDecimalResult0 = numberConverted * powerSixteen;
                        break;
                    case '4':
                        numberConverted = 4;
                        hexaDecimalResult0 = numberConverted * powerSixteen;
                        break;
                    case '5':
                        numberConverted = 5;
                        hexaDecimalResult0 = numberConverted * powerSixteen;
                        break;
                    case '6':
                        numberConverted = 6;
                        hexaDecimalResult0 = numberConverted * powerSixteen;
                        break;
                    case '7':
                        numberConverted = 7;
                        hexaDecimalResult0 = numberConverted * powerSixteen;
                        break;
                    case '8':
                        numberConverted = 8;
                        hexaDecimalResult0 = numberConverted * powerSixteen;
                        break;
                    case '9':
                        numberConverted = 9;
                        hexaDecimalResult0 = numberConverted * powerSixteen;
                        break;
                    case 'A':
                        numberConverted = 10;
                        hexaDecimalResult0 = numberConverted * powerSixteen;
                        break;
                    case 'B':
                        numberConverted = 11;
                        hexaDecimalResult0 = numberConverted * powerSixteen;
                        break;
                    case 'C':
                        numberConverted = 12;
                        hexaDecimalResult0 = numberConverted * powerSixteen;
                        break;
                    case 'D':
                        numberConverted = 13;
                        hexaDecimalResult0 = numberConverted * powerSixteen;
                        break;

                    case 'E':
                        numberConverted = 14;
                        hexaDecimalResult0 = numberConverted * powerSixteen;
                        break;
                    case 'F':
                        numberConverted = 15;
                        hexaDecimalResult0 = numberConverted * powerSixteen;
                        break;
                }

                hexaDecimalResult += hexaDecimalResult0;
            }

            Console.WriteLine(hexaDecimalResult);
        
        }
    }
}
