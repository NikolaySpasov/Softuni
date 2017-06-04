using System;
using System.Collections.Generic;
using System.Linq;

class ReverseNumbersWithAStack
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var stack = new Stack<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            stack.Push(numbers[i]);
        }

        while (stack.Count > 0)
        {
            Console.Write(stack.Pop() +" ");
        }
        Console.WriteLine(stack.Pop());

    }
}