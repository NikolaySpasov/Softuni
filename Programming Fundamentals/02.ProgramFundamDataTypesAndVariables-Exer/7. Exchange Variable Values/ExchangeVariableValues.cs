//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange, as shown below:
namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            var a = 5;
            var b = 10;
            System.Console.WriteLine("Before:");
            System.Console.WriteLine($"a = {a}");
            System.Console.WriteLine($"b = {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            System.Console.WriteLine("After:");
            System.Console.WriteLine($"a = {a}");
            System.Console.WriteLine($"b = {b}");
        }
    }
}
