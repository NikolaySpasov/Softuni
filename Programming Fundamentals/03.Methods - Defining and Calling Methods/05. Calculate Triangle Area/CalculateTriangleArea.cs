//Create a method that calculates and returns the area of a triangle by given base and height.

using System;

namespace _Calculate_Triangle_Area
{
    class CalculateTriangleArea
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(width, height);
            Console.WriteLine(area);

        }

        static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
