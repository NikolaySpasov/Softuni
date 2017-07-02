
using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

        Family family = new Family();
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine().Split();

            Person person = new Person(int.Parse(input[1]), input[0]);
            family.AddMember(person);
        }

        Person oldest = family.GetOldestMember();
        Console.WriteLine($"{oldest.name} {oldest.age}");

    }
}

