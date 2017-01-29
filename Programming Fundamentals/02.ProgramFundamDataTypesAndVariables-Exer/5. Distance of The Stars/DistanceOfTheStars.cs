//In physics, there are some well-known relative distances in Space:
//•	The distance from Earth to its nearest star – Proxima Centauri: ~4.22 ly(light years)
//•	The distance to the center of our galaxy – the Milky Way: ~26 000 ly
//•	The c: ~100 000 ly
//•	The distance from Earth to the edge of the observable universe: ~46 500 000 000 ly
//Write a program to calculate the aforementioned distances in kilometers.
//Print the result using scientific notation with 2 points decimal precision
//Assume that 1 light year == 9 450 000 000 000 km.

using System;

class DistanceOfTheStars
{
    static void Main()
    {
        long lightYear = 9450000000000L;
        decimal nearestStar = 4.22M * lightYear;
        decimal centerOfOurGalaxy = 26000M * lightYear;
        decimal diameterOfMilkyWay = 100000M * lightYear;
        decimal earthToObservableUniverse = 46500000000M * lightYear;

        Console.WriteLine("{0:e2}", nearestStar);
        Console.WriteLine("{0:e2}", centerOfOurGalaxy);
        Console.WriteLine("{0:e2}", diameterOfMilkyWay);
        Console.WriteLine("{0:e2}", earthToObservableUniverse);
    }
}
