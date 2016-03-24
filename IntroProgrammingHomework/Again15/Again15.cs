using System;
using System.Globalization;

namespace Again15
{
    class Again15
    {
        static void Main()
        {
            string birthDate = String.Empty;
            Console.Write("Please, enter your birthdate: ");
            birthDate = Console.ReadLine();
            string format = "d.MM.YYYY";
            DateTime now = DateTime.Now;
            TimeSpan result = now.Date - DateTime.ParseExact(birthDate, format, CultureInfo.CurrentCulture);
            Console.WriteLine("Now: {0}", result);
        }
    }
}
