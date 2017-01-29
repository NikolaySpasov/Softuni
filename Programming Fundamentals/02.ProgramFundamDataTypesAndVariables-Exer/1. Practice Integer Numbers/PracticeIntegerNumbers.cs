//Create a new C# project and create a program that assigns integer values to variables.
//Be sure that each value is stored in the correct variable type (try to find the most suitable variable type in order to save memory).
//Finally, you need to print all variables to the console.

using System;

public class PracticeIntegerNumbers

{

    public static void Main()
    {
        sbyte num1 = -100;
        byte num2 = 128;
        short num3 = -3540;
        int num4 = 64876;
        long num5 = 2147483648;
        int num6 = -1141583228;
        long num7 = -1223372036854775808;

        System.Console.WriteLine(num1);
        System.Console.WriteLine(num2);
        System.Console.WriteLine(num3);
        System.Console.WriteLine(num4);
        System.Console.WriteLine(num5);
        System.Console.WriteLine(num6);
        System.Console.WriteLine(num7);

    }
}