using System;

namespace _10.OddAndEvenProduct
{
    class OddEvenProduct
    {
        static void Main()
        {
            string[] inputNumbers = { };
            inputNumbers = Console.ReadLine().Split();
            ulong productEven = 1;
            ulong productOdd = 1;
            
            for (int i = 0; i < inputNumbers.Length; i++)
            { 
                if (i % 2 == 0)
                {
                    productOdd *= Convert.ToUInt64(inputNumbers[i]);                                        
                }
                else
                {
                    productEven *= Convert.ToUInt64(inputNumbers[i]);                   
                }              
            }
            if (productEven == productOdd)
            {
                Console.WriteLine("yes\nproduct = {0}", productEven);                
            }
            else
            {
                Console.WriteLine("no\nodd_product = {0}\neven_product = {1}", productOdd, productEven);

            }                
        }
    }
}
