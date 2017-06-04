using System;
using System.Linq;


class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var r = input[0];
        var c = input[1];

        string[,] matrix = new string[r, c];

        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                matrix[row, col] = "" + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row);

            }
        }
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }

    }
}