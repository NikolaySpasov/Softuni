using System;

public class ConsoleWriter
{
    public void WriteLine(string output)
    {
        Console.WriteLine(output);
    }

    public void WriteLine(string[] elements)
    {
        foreach (var element in elements)
        {
            Console.WriteLine(string.Format(element));

        }
    }
}