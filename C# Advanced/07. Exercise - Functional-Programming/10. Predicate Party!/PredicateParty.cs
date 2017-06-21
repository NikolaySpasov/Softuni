using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main()
    {
        List<string> names = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

        string[] command = Console.ReadLine().Split(' ').ToArray();

        while (command[0] != "Party!")
        {
            if (command[0] == "Remove")
            {
                switch (command[1])
                {
                    case "StartsWith": names = RemoveStartsWith(names, command[2]); break;
                    case "EndsWith": names = RemoveEndsWith(names, command[2]); break;
                    case "Length": names = names.Where(x => x.Length != int.Parse(command[2])).ToList(); break;

                    default:
                        break;
                }
            }
            else if (command[0] == "Double")
            {
                switch (command[1])
                {
                    case "StartsWith": names = DoubleStartsWith(names, command[2]); break;
                    case "EndsWith": names = DoubleEndsWith(names, command[2]); break;
                    case "Length": names = DoubleLength(names, command[2]); break;

                    default:
                        break;
                }
            }

            command = Console.ReadLine().Split(' ').ToArray();
        }

        if (names.Count == 0)
        {
            Console.WriteLine("Nobody is going to the party!");
        }
        else
        {
            Console.WriteLine(string.Join(", ", names) + " are going to the party!");
        }
    }

    public static List<string> DoubleLength(List<string> names, string v)
    {
        for (int i = 0; i < names.Count; i++)
        {
            if (names[i].Length == int.Parse(v))
            {
                names.Insert(i, names[i]);
                i++;
            }
        }

        return names;
    }

    public static List<string> DoubleEndsWith(List<string> names, string v)
    {
        for (int i = 0; i < names.Count; i++)
        {
            if (names[i].Substring(names[i].Length - v.Length) == v)
            {
                names.Insert(i, names[i]);
                i++;
            }
        }

        return names;
    }

    public static List<string> DoubleStartsWith(List<string> names, string v)
    {
        for (int i = 0; i < names.Count; i++)
        {
            if (names[i].Substring(0, v.Length) == v)
            {
                names.Insert(i, names[i]);
                i++;
            }
        }

        return names;
    }

    public static List<string> RemoveEndsWith(List<string> names, string v)
    {
        List<string> result = new List<string>();

        foreach (var name in names)
        {
            if (name.Substring(name.Length - v.Length) != v)
            {
                result.Add(name);
            }
        }

        return result;
    }

    public static List<string> RemoveStartsWith(List<string> names, string v)
    {
        List<string> result = new List<string>();

        foreach (var name in names)
        {
            if (name.Substring(0, v.Length) != v)
            {
                result.Add(name);
            }
        }

        return result;
    }
}