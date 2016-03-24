using System;


namespace _02.GravitationMoon
{
    class GravitationMoon
    {
        static void Main()
        {
            Console.Write("Please, enter your weight: ");
            double weightEarth = Double.Parse(Console.ReadLine());
            double weightMoon = weightEarth * (17.00 / 100);
            Console.WriteLine("Your weight on the Moon is {0}", weightMoon);
        }
    }
}
