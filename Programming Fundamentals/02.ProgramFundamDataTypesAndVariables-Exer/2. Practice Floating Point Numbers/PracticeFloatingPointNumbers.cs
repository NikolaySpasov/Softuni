//Create a new C# project and create a program that assigns floating point values to variables.
//Be sure that each value is stored in the correct variable type (try to find the most suitable variable type in order to save memory).
//Finally, you need to print all variables to the console.

namespace PracticeFloatingPointNumbers
{
    using System;

    class PracticeFloatingPointNumbers
    {
        static void Main()
        {
            decimal num1 = 3.141592653589793238M;
            double num2 = 1.60217657;
            decimal num3 = 7.8184261974584555216535342341M;

            System.Console.WriteLine(num1);
            System.Console.WriteLine(num2);
            System.Console.WriteLine(num3);
        }
    }
}
