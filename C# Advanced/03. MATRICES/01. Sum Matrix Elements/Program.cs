using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var matrixLength = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int row = matrixLength[0];
        int col = matrixLength[1];
        int[,] matrix = new int[row,col];

        for (int i = 0; i < matrixLength[0]; i++)
        {
            
        }

    }
}