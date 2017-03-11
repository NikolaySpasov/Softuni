namespace FoldAndSum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
            int k = arr.Length / 4;
            int[] row1left = arr.Take(k).Reverse().ToArray();
            int[] row1right = arr.Reverse().Take(k).ToArray();
            int[] row1 = row1left.Concat(row1right).ToArray();
            int[] row2 = arr.Skip(k).Take(2 * k).ToArray();
            var sumArr = row2.Select((x, y) => x + row1[y]);
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
