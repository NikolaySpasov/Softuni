namespace UserLogins
{
    using System;
    using System.Collections.Generic;

    public class UserLogins
    {
        public static void Main()
        {
            var namesAndPasswords = new Dictionary<string, string>();
            var count = 0;
            var line = Console.ReadLine();

            while (line != "login")
            {
                var tokens = line.Split();
                var name = tokens[0];
                var password = tokens[2];

                namesAndPasswords[name] = password;

                line = Console.ReadLine();
            }

            line = Console.ReadLine();

            while (line != "end")
            {
                var tokens = line.Split();
                var name = tokens[0];
                var password = tokens[2];

                if (namesAndPasswords.ContainsKey(name) && namesAndPasswords.ContainsValue(password))
                {
                    Console.WriteLine($"{name}: logged in successfully");
                }
                else
                {
                    Console.WriteLine($"{name}: login failed");
                    count++;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
