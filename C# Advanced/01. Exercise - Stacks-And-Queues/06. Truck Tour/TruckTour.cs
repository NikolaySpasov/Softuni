using System;
using System.Collections.Generic;
using System.Linq;

class TruckTour
{
    static void Main()
    {
        int petrolStationsNum = int.Parse(Console.ReadLine());
        var petrolStations = new Stack<int[]>();

        for (int i = 0; i < petrolStationsNum; i++)
        {
            var petrolStation = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            petrolStations.En
        }

        var reachFinal = false;
        while (!reachFinal)
        {
            var totalPetrol = 0;
            for (int i = 0; i < petrolStationsNum; i++)
            {
                var petr0lStation = petrolStations.Dequeue();
                petrolStations.En
            }
        }
    }
}
