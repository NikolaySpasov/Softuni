
namespace Greater_of_Two_Values
{
    using System;

    class GreaterOfTwoValues
    {
        static void Main()
        {
            var type = Console.ReadLine();

            if (type == "int")
            {
                int int1 = int.Parse(Console.ReadLine());
                int int2 = int.Parse(Console.ReadLine());
                int max = GetMax( int1,int2);
                Console.WriteLine(max); 
            }

            else if (type == "char")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());
                char max = GetMax(char1,char2);
                Console.WriteLine(max);
            }

            else
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                string max = GetMax(str1, str2);
                Console.WriteLine(max);
            }

        }

        static int GetMax(int int1, int int2)
        {
            if (int1 >= int2)
            {
                return int1;
            }

            return int2;
        }

        static char GetMax(char char1, char char2)
        {
            if (char1 >= char2)
            {
                return char1;
            }

            return char2;
        }

        static string GetMax(string str1, string str2)
        {
            if (str1.CompareTo(str2) >= 0)
            {
                return str1;
            }

            return str2;
        }
    }
}
