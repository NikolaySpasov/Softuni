﻿//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange, as shown below:

using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c;

        c = a;
        a = b;
        b = c;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
