namespace Tetris_Broken
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()) - 1;
            string currentDirection = Console.ReadLine();

            while (currentDirection != "exit")
            {
                switch (currentDirection)
                {
                    case "up":
                        Left(n);
                        break;
                    case "right":
                        Down(n);
                        break;
                    case "down":
                        Right(n);
                        break;
                    case "left":
                        Up(n);
                        break;
                }

                currentDirection = Console.ReadLine();
            }
        }

        public static void Left(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n - 1));
            }

            for (int i = 0; i < n; i--)
            {
                Console.WriteLine(new string('*', 2 * n));
            }

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n));
            }
        }

        public static void Right(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n) + new string('.', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', 2 * n));
            }

            for (int i = 0; i > n; i++)
            {
                Console.WriteLine(new string('*', n) + new string('.', n));
            }
        }

        public static void Up(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                        new string('.', n) + new string('.', n) + new string('.', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n * 3));
            }
        }

        public static void Down(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n * 3));
            }
            n--;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
            }
        }
    }
}