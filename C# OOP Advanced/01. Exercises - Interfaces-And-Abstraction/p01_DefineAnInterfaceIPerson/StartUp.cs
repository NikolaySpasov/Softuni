namespace p01_DefineAnInterfaceIPerson
{
    using System;
    using System.Reflection;
    using p01_DefineAnInterfaceIPerson.Models;

    public class StartUp
    {
        public static void Main()
        {
            Type personInterface = typeof(Citizen).GetInterface("IPerson");
            PropertyInfo[] properties = personInterface.GetProperties();
            Console.WriteLine(properties.Length);
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            IPerson person = new Citizen(name, age);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}
