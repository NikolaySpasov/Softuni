using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AcademyGraduation
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        var students = new SortedDictionary<string, List<double>>();
        for (int i = 0; i < number; i++)
        {
            var student = Console.ReadLine();
            var results = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => double.Parse(n, CultureInfo.InvariantCulture)).ToList();
            students.Add(student, results);
        }

        foreach (var kvp in students)
        {
            Console.WriteLine($"{kvp.Key} is graduated with {kvp.Value.Average()}");
        }
    }
}