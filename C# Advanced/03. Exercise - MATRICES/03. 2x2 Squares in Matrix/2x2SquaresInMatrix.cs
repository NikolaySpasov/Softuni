using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var row = inputLine[0];
        var col = inputLine[1];
        int count = 0;
        string[][] matrix = new string[row][];
        for (int i = 0; i < row; i++)
        {
            var letters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            matrix[i] = letters;
        }

        for (int i = 0; i < row-1; i++)
        {
            for (int j = 0; j < col-1; j++)
            {
                var element = matrix[i][j];
                if (matrix[i][j].Equals(element) && matrix[i+1][j].Equals(element) && matrix[i][j+1].Equals(element) && matrix[i +1][j + 1].Equals(element))
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}
