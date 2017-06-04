using System;
using System.Linq;

class DiagonalDifference
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[][] matrix = new int[n][];
        for (int rowsIndex = 0; rowsIndex < n; rowsIndex++)
        {
            var nums = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            matrix[rowsIndex] = nums;
        }
        int diagonalSum1 = 0;
        for (int i = 0; i < n; i++)
            diagonalSum1 += matrix[i][i];

        int diagonalSum2 = 0;
        int start = n - 1;
        for (int i = 0; i < n; i++)
        {
            diagonalSum2 += matrix[i][start];
            start--;
        }
        Console.WriteLine(Math.Abs(diagonalSum1 - diagonalSum2));
    }
}
