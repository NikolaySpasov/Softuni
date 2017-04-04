namespace ReverseString
{
    using System;
    using System.Text;

    public class ReverseTextString
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            Console.WriteLine(ReverseString(word));
        }

        public static string ReverseString(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }
}
