using System;

namespace _06.Notifications
{
    class Notifications
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            Input(N);
            ShowSuccess(operation, message);
        }

        static string ShowSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}."); 

        }

        static string ShowError(string operation, int code)
        {
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");

        }


    }
}
