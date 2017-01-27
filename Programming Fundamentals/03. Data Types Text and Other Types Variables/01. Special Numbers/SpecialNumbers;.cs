using System;

class SpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //enter maxNumber n

        for (int i = 1; i <= n; i++)
        {
            var currentNumber = i;
            var sum = 0;

            foreach (var symbol in currentNumber.ToString())
            {
                var digit = symbol - '0';//take last digit 
                sum += digit; //sum of last digits
            }

            var result = sum == 5 || sum == 7 || sum == 11; // check is it sum equal to 5,7,11

            Console.WriteLine("{0} -> {1}", i, result);

            //Console.WriteLine($"{i} -> {result}");
        }
    }
}