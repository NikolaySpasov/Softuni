using System;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        var inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var n = inputLine[0];
        var m = inputLine[1];

        int[][] matrix = new int[n][];

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            matrix[i] = input;
        }

        var rowCurrentElement = 0;
        var colCurrentElement = 0;
        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < m - 2; j++)
            {
                var tempSum = matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2] +
                      matrix[i + 1][j] + matrix[i + 1][j + 1] + matrix[i + 1][j + 2] +
                        matrix[i + 2][j] + matrix[i + 2][j + 1] + matrix[i + 2][j + 2];
                if (tempSum > sum)
                {
                    sum = tempSum;
                    rowCurrentElement = i;
                    colCurrentElement = j;
                }
            }
        }

        Console.WriteLine($"Sum = {sum}");
        for (int i = rowCurrentElement; i < rowCurrentElement + 3; i++)
        {
            for (int j = colCurrentElement; j < colCurrentElement + 3; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}