using System;

namespace _06.Notifications
{
    class Notifications
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string result = Console.ReadLine();

            string operation = Console.ReadLine();
            string message = Console.ReadLine();

            if (result == "success")
            {
                ShowSuccess(operation, message);
            }

        }

        static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}."); 

        }

        static void ShowError(string operation, int code)
        {
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            if (code < 0)
            {
                Console.WriteLine($"Error Code: Invalid Client Data.");
            }
            else
            {
                Console.WriteLine($"Error Code: Internal System Failure.");
            }

        }


    }
}
