using System;

public class RefactorVolumeOfPyramid
{
    static void Main()
    {
        double length = 0;
        Console.Write("Length: ");
        length = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        double width = 0;
        width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height = 0;
        height = double.Parse(Console.ReadLine());
        double volume = 0;
        volume = (length * width * height) / 3;
        Console.WriteLine("Pyramid Volume: {0:F2}", volume);
    }
}