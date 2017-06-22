using System;
using System.Linq;
using System.Text;

public sealed class Startup
{
    private static void Main(string[] args)
    {
        int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[,] garden = new int[dimensions[0], dimensions[1]];
        string input = Console.ReadLine();

        while (input != "Bloom Bloom Plow")
        {
            int[] tokens = input.Split(' ').Select(int.Parse).ToArray();
            int row = tokens[0];
            int col = tokens[1];

            for (int r = 0; r < garden.GetLength(0); r++)
            {
                garden[r, col]++;
            }

            for (int c = 0; c < garden.GetLength(1); c++)
            {
                garden[row, c]++;
            }

            garden[row, col]--;

            input = Console.ReadLine();
        }
        var result = new StringBuilder();
        for (int row = 0; row < garden.GetLength(0); row++)
        {
            for (int col = 0; col < garden.GetLength(1); col++)
            {
                result.Append(garden[row, col] + " ");
            }

            result.AppendLine();
        }

        Console.WriteLine(string.Join(" ",result));
    }
}