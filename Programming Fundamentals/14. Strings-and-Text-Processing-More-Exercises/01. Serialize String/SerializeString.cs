namespace SerializeString
{
    using System;

    public class SerializeString
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            for (int i = 0; i < inputLine.Length; i++)
            {
                if (inputLine[i].Equals('^'))
                {
                    continue;
                }
                var index = inputLine.IndexOf(inputLine[i]);
                var output = inputLine[i] + ":" + index;
                while (index != -1)
                {
                    
                    index = inputLine.IndexOf(inputLine[i], index + 1);
                    if (index != -1)
                    {
                        output += "/" + index;
                    }
                }
                Console.WriteLine(output);
                inputLine = inputLine.Replace(inputLine[i], '^');
            }
        }
    }
}
