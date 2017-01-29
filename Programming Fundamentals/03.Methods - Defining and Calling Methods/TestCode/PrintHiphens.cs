namespace TestCode
{
    using System;

    public class PrintHiphens
    {

        public static void PrintHiphens(int count)
        {
            Console.WriteLine(new string ('-',count ));
        }

        public static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                PrintHiphens(i);
            }
        }
    }
}
