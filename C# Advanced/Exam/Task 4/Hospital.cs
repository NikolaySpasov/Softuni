using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var hospital = new Dictionary<string, Dictionary<string, List<string>>>();


        while (inputLine[0] != "Output")
        {
            //{Department} {Doctor} {Patient}
            string department = inputLine[0];
            string doctor = inputLine[1] + inputLine[2];
            string patient = inputLine[3];

            if (!hospital.ContainsKey(department))
            {
                hospital.Add(department, new Dictionary<string, List<string>>());
            }
            if (!hospital[department].ContainsKey(doctor))
            {
                hospital[department][doctor] = new List<string>();
            }
            hospital[department][doctor].Add(patient);

            inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        var outputCommand = Console.ReadLine();
        while (outputCommand != "End")
        {
            foreach (var kvp in hospital )
            {
                var department = kvp.Key;
                var doctor = kvp.Value;


                foreach (var innerKvp in doctor)
                {
                    if (outputCommand == department)
                    {
                        var patient = hospital[department].Select(p => p.Value);
                        Console.WriteLine(string.Join(Environment.NewLine, patient));

                    }
                    //if (outputCommand == innerKvp.Key)
                    //{
                    //    var patient = hospital[department].Select(p => p.Value).ToList<string>();
                    //    Console.WriteLine(string.Join(Environment.NewLine, patient));
                    //}
                }
                    
                

            }

            outputCommand = Console.ReadLine();
        }

    }

}
public static class Hospital
{

}
