using System;
using System.Text;

public class ReverseString
{
    static void Main()
    {
        var text = Console.ReadLine();c
        var sb = new StringBuilder();

        for (int i = text.Length - 1; i >= 0; i--)
        {
            sb.Append(text[i]);
        }
        Console.WriteLine(sb);
    }
}