using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MathPotato
{
    static void Main()
    {
        var input = Console.ReadLine();
        var number = int.Parse(Console.ReadLine());
        var queue = new Queue<string>(input.Split());
        int cycle = 1;
        while (queue.Count != 1)
        {

            for (int i = 1; i < number; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
            if (PrimeTool.IsPrime(cycle))
            {
                Console.WriteLine($"Prime {queue.Peek()}");
            }
            else
            {
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            cycle++;
        }
        Console.WriteLine($"Last in {queue.Dequeue()}");

    }
}
