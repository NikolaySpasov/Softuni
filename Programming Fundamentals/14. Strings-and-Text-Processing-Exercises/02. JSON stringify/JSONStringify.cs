namespace JsonStringify
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int[] Grades { get; set; }
    }

    public class JsonStringify
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            string inputLine = Console.ReadLine();

            while (!inputLine.Equals("stringify"))
            {
                string[] inputParams = inputLine.Split(new[] { ' ', ':', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string studentName = inputParams[0];
                int studentAge = int.Parse(inputParams[1]);
                int[] studentGrades = inputParams.Skip(2).Select(int.Parse).ToArray();

                Student newStudent = new Student();

                newStudent.Name = studentName;
                newStudent.Age = studentAge;
                newStudent.Grades = studentGrades;

                students.Add(newStudent);
                inputLine = Console.ReadLine();
            }

            string output = "";

            output += "[";

            for (int i = 0; i < students.Count; i++)
            {
                Student currentStudent = students[i];

                output += "{";

                output += "name:\"" + currentStudent.Name + "\"" + ",";
                output += "age:" + currentStudent.Age + ",";
                output += "grades:[" + string.Join(", ", currentStudent.Grades) + "]";
                output += "}";

                if (i < students.Count - 1)
                {
                    output += ",";

                }
            }
            output += "]";

            Console.WriteLine(output);
        }
    }
}
