using System;

class ParseTags
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string openTag = "<upcase>";
        string closeTag = "</upcase>";

        int startIndex = text.IndexOf(openTag);
        while (startIndex != -1)
        {
            int endIndex = text.IndexOf(closeTag);
            if (endIndex == -1)
            {
                break;
            }
            string upcase = text.Substring(startIndex, endIndex - startIndex + closeTag.Length);
            string replaceUpcase = upcase.Replace(openTag, "").Replace(closeTag, "").ToUpper();
            text = text.Replace(upcase, replaceUpcase);
            startIndex = text.IndexOf(openTag);

        }
        Console.WriteLine(text);
    }
}
