namespace Stateless
{
    using System;
    using System.Linq;

    public class Stateless
    {
        public static void Main()
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();


            while (!firstLine.Equals("collapse"))
            {
                while (secondLine.Length > 0)
                {
                    if (firstLine.Contains(secondLine))
                    {
                        firstLine = firstLine.Replace(secondLine, "");
                    }
                    secondLine = string.Join("", secondLine.Skip(1).Take(secondLine.Length - 2));
                }
                if (firstLine.Length == 0 && secondLine.Length ==0)
                {
                    Console.WriteLine("(void)");
                }
                else if (firstLine.Length >0)
                {
                    Console.WriteLine(firstLine.Trim());
                }

                firstLine = Console.ReadLine();
                if (firstLine.Equals("collapse"))
                {
                    break;
                }
                secondLine = Console.ReadLine();
            }
        }
    }
}