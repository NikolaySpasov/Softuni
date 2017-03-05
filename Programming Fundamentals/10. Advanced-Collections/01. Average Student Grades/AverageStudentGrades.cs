namespace AverageStudentGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageStudentGrades
    {
        public static void Main()
        {
            var grades = new Dictionary<string, List<double>>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var name = tokens[0];
                var grade = double.Parse(tokens[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }

                grades[name].Add(grade);
            }

            foreach (var kvp in grades)
            {
                var name = kvp.Key;
                var studentGrades = kvp.Value;

                var average = studentGrades.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in studentGrades)
                    Console.Write($"{grade:F2} ");

                Console.WriteLine($"(avg: {average:F2})");
            }

        }
    }
}