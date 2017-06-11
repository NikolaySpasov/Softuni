using System;
using System.Text.RegularExpressions;


class MatchPhoneNumber
{
    static void Main()
    {
        string phone = Console.ReadLine();

        Regex regexOne = new Regex(@"^\+359[ ][2][ ][0-9]{3}[ ][0-9]{4}$");
        Regex regexTwo = new Regex(@"^\+359[-][2][-][0-9]{3}[-][0-9]{4}$");

        while (phone != "end")
        {
            if (regexOne.IsMatch(phone) || regexTwo.IsMatch(phone))
            {
                Console.WriteLine(phone);
            }
            
            phone = Console.ReadLine();
        }
    }
}

