using System;

class StudentsResults
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|", "Name", "CAdv", "COOP","AdvOOP", "Average");

        for (int i = 0; i < number; i++)
        {
            var tokens = Console.ReadLine().Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var name = tokens[0];
            var firtsNum = Double.Parse(tokens[1]);
            var secondNum = Double.Parse(tokens[2]);
            var thirdNum = Double.Parse(tokens[3]);
            var average = (firtsNum + secondNum + thirdNum) / 3;

            Console.WriteLine("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|",name,firtsNum,secondNum,thirdNum,average);
        }
    }
}
