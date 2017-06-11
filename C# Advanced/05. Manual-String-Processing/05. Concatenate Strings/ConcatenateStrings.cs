using System;
using System.Text;

class ConcatenateStrings
{
    static void Main()
    {
        var count = int.Parse(Console.ReadLine());
        var sb = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            sb.Append(Console.ReadLine()).Append(" ");
        }

        Console.WriteLine(sb);
    }
}
