namespace DataTypesNumeralTypesAndTypeConversion_Lab
{
    using System;

    class TimeSinceBirthday
    {
        static void Main(string[] args)
        {
            Console.Write("Years - ");
            byte years = byte.Parse(Console.ReadLine());
            int days = years * 365;
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{years} years = {days} days = {hours} hours = {minutes} minutes.");
        }
    }
}