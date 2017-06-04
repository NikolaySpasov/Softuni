using System;
using System.Collections.Generic;
using System.Linq;

class BasicStackOperations
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var n = input[0];
        var s = input[1];
        var x = input[2];
        var stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            stack.Push(line[i]);
        }
        for (int i = 0; i < s; i++)
        {
            stack.Pop();
        }

        if (stack.Count > 0)
        {
            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
        else
        {
            Console.WriteLine(0);
        }
        
    }
}
