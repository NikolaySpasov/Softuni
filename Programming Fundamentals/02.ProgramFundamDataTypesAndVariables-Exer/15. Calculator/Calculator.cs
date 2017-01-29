using System;

//Create a program that reads 3 lines:
//•	An operand.
//•	An operator.
//•	A second operand.
//And performs the operation between the operands.The left and right operands will always be integers.


namespace Calculator
{
    class Calculator
    {
        static void Main()
        {
            int firstOperand = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int secondOperand = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{firstOperand} + {secondOperand} = {firstOperand + secondOperand}");
                    break;
                case "-":
                    Console.WriteLine($"{firstOperand} - {secondOperand} = {firstOperand - secondOperand}");
                    break;
                case "*":
                    Console.WriteLine($"{firstOperand} * {secondOperand} = {firstOperand * secondOperand}");
                    break;
                case "/":
                    Console.WriteLine($"{firstOperand} / {secondOperand} = {firstOperand / secondOperand}");
                    break;
                default:
                    Console.WriteLine("not operator");
                    break;
            }

        }
    }
}
