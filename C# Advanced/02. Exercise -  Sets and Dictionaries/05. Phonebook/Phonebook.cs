using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Phonebook
{
    static void Main()
    {
        var phonebook = new Dictionary<string, string>();
        var line = Console.ReadLine().Split('-');


        while (line[0] != "search")
        {
            if (line[1].Contains('+')) ;
            {

                if (!phonebook.ContainsKey(line[0]))
                {
                    phonebook.Add(line[0], line[1]);
                }

                phonebook[line[0]] = line[1];
            }
            //int phone;
            //var isPhoneNumber = int.TryParse(line[1], out phone);
            //if (isPhoneNumber && )
            //{

            //    if (!phonebook.ContainsKey(line[0]))
            //    {
            //        phonebook.Add(line[0], phone.ToString());
            //    }

            //    phonebook[line[0]] = phone.ToString();
            //}

            line = Console.ReadLine().Split('-');
        }
        Console.WriteLine();
        var name = Console.ReadLine();
        while (name != "stop")
        {
            foreach (var kvp in phonebook)
            {
                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
                else
                {
                    Console.WriteLine($"Contact {kvp.Key} does not exist.");
                }
            }
            name = Console.ReadLine();
        }
    }
}