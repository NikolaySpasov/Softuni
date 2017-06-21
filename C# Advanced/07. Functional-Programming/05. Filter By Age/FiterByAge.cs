using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Filter_By_Age
{
    class FiterByAge
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>();
            for (int i = 0; i < lines; i++)
            {
                var person = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                people.Add(person[0], int.Parse(person[1]));

            }
            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            Func<KeyValuePair<string, int>, string, bool> f = (k, s) => k.Key == s;

            people.Where(x => x.Value >= age ?
            condition == "older" :
            condition == ""

        }
    }
}
