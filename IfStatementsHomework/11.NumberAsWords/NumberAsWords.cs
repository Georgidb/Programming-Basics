using System;


namespace _11.NumberAsWords
{
    class NumberAsWords
    {
        static void Main()
        {
            int inputNumber = 0;
            Console.Write("Please, enter a number between 0 and 999:  ");
            inputNumber = Int32.Parse(Console.ReadLine());
            if (inputNumber >= 0 && inputNumber <= 20)
	        {
                 switch (inputNumber)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 10:
                    Console.WriteLine("Ten");
                    break;
                case 11:
                    Console.WriteLine("Eleven");
                    break;
                case 12:
                    Console.WriteLine("Twelve");
                    break;
                case 13:
                    Console.WriteLine("Thirteen");
                    break;
                case 14:
                    Console.WriteLine("Fourteen");
                    break;
                case 15:
                    Console.WriteLine("Fifteen");
                    break;
                case 16:
                    Console.WriteLine("Sixteen");
                    break;
                case 17:
                    Console.WriteLine("Seventeen");
                    break;
                case 18:
                    Console.WriteLine("Eighteen");
                    break;
                case 19:
                    Console.WriteLine("Nineteen");
                    break;
                case 20:
                    Console.WriteLine("Twenty");
                    break;
                default:
                    break;
            }       		 
	        }
            if (inputNumber > 20 && inputNumber <= 999)
            {
                int partNumber1 = (inputNumber / 100) % 10;
                int partNumber2 = (inputNumber / 10) % 10;
                int partNumber3 = (inputNumber / 1) % 10;

                if (partNumber1 != 0 && partNumber2 == 0 && partNumber3 == 0)
                {
                    switch (partNumber1)
                    {
                        case 1:
                            Console.Write("One hundred ");
                            break;
                        case 2:
                            Console.Write("Two hundred ");
                            break;
                        case 3:
                            Console.Write("Three hundred ");
                            break;
                        case 4:
                            Console.Write("Four hundred ");
                            break;
                        case 5:
                            Console.Write("Five hundred ");
                            break;
                        case 6:
                            Console.Write("Six hundred ");
                            break;
                        case 7:
                            Console.Write("Seven hundred ");
                            break;
                        case 8:
                            Console.Write("Eight hundred ");
                            break;
                        case 9:
                            Console.Write("Nine hundred ");
                            break;
                        default:
                            break;
                    }
                }


                else
                {

                    if (partNumber1 != 0)
                    {
                        switch (partNumber1)
                        {
                            case 1:
                                Console.Write("One hundred ");
                                break;
                            case 2:
                                Console.Write("Two hundred ");
                                break;
                            case 3:
                                Console.Write("Three hundred ");
                                break;
                            case 4:
                                Console.Write("Four hundred ");
                                break;
                            case 5:
                                Console.Write("Five hundred ");
                                break;
                            case 6:
                                Console.Write("Six hundred ");
                                break;
                            case 7:
                                Console.Write("Seven hundred ");
                                break;
                            case 8:
                                Console.Write("Eight hundred ");
                                break;
                            case 9:
                                Console.Write("Nine hundred ");
                                break;
                            default:
                                break;
                        }
                    }

                    if (partNumber2 != 0 && partNumber2 != 1)
                    {
                        switch (partNumber2)
                        {
                            case 1:
                                Console.Write("ten ");
                                break;
                            case 2:
                                Console.Write("twenty ");
                                break;
                            case 3:
                                Console.Write("thirty ");
                                break;
                            case 4:
                                Console.Write("forty ");
                                break;
                            case 5:
                                Console.Write("fifty ");
                                break;
                            case 6:
                                Console.Write("sixty ");
                                break;
                            case 7:
                                Console.Write("seventy ");
                                break;
                            case 8:
                                Console.Write("eighty ");
                                break;
                            case 9:
                                Console.Write("ninety ");
                                break;
                            default:
                                break;
                        }
                    }
                    if (partNumber2 != 0 && partNumber2 == 1)
                    {
                        switch (partNumber3)
                        {
                            case 1:
                                Console.WriteLine("eleven");
                                break;
                            case 2:
                                Console.WriteLine("twelve");
                                break;
                            case 3:
                                Console.WriteLine("thirteen");
                                break;
                            case 4:
                                Console.WriteLine("fourteen");
                                break;
                            case 5:
                                Console.WriteLine("fifteen");
                                break;
                            case 6:
                                Console.WriteLine("sixteen");
                                break;
                            case 7:
                                Console.WriteLine("seventeen");
                                break;
                            case 8:
                                Console.WriteLine("eighteen");
                                break;
                            case 9:
                                Console.WriteLine("nineteen");
                                break;
                        }
                    }
                    if (partNumber3 > 0 && partNumber3 <= 9 && partNumber2 != 1)
                    {
                        switch (partNumber3)
                        {
                            case 1:
                                Console.Write("one ");
                                break;
                            case 2:
                                Console.Write("two ");
                                break;
                            case 3:
                                Console.Write("three ");
                                break;
                            case 4:
                                Console.Write("four ");
                                break;
                            case 5:
                                Console.Write("five ");
                                break;
                            case 6:
                                Console.Write("six ");
                                break;
                            case 7:
                                Console.Write("seven ");
                                break;
                            case 8:
                                Console.Write("eight ");
                                break;
                            case 9:
                                Console.Write("nine ");
                                break;
                        }
                    }
                }
            }   
        }
    }
}
