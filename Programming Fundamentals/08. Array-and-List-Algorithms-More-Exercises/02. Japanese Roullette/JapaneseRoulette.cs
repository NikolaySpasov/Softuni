using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseRoulette
{
    class JapaneseRoulette
    {
        static void Main(string[] args)
        {
            //THE CILYNDER, ITS A LIST
            List<int> cilynder = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //THE PLAYERS
            string[] players = Console.ReadLine().Split(' ');

            //GET A BOOLEAN VARIABLE TO SAVE IF SOMEONE HAS DIED
            bool hasDied = false;

            //THE LOOP THAT GOES THROUGH ALL PLAYERS
            for (int i = 0; i < players.Length; i++)
            {
                //GET A PLAYER'S PARAMS
                string[] currentPlayerParams = players[i].Split(',');

                int rotations = int.Parse(currentPlayerParams[0]); //GET THE ROTATIONS
                string direction = currentPlayerParams[1]; //GET THE DIRECTION

                //IF ITS RIGHT SPIN RIGHT WITH A SIMPLE METHOD
                //ELSE, SPIN LEFT WITH ANOTHER METHOD
                if (direction == "Right")
                {
                    //RIGHT
                    SpinRight(cilynder, rotations);
                }
                else
                {
                    //LEFT
                    SpinLeft(cilynder, rotations);
                }

                //CHECK THE BULLET INDEX
                int bulletIndex = FindBullet(cilynder);

                //IF ITS 2 (ON THE MUZZLE) THE PLAYER DIES
                if (bulletIndex == 2)
                {
                    Console.WriteLine("Game over! Player {0} is dead.", i);
                    hasDied = true;
                    //BREAK THE LOOP
                    break;
                }

                //SPIN ONE TIME TO THE RIGHT AFTER THE SHOT
                SpinRight(cilynder, 1);
            }

            //IF NO PLAYER HAS DIED, PRINT EVERYBODY GOT LUCKY
            if (!hasDied)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }

        //THE METHOD FOR SPINNING LEFT
        private static void SpinLeft(List<int> cilynder, int rotations)
        {
            //MINIMIZE THE ROTATIONS
            rotations = rotations % cilynder.Count;

            //ROTATION ALGORITHM
            for (int i = 0; i < rotations; i++)
            {
                //STORE THE FIRST ELEMENT
                int firstElement = cilynder[0];

                //TAKE EVERY OTHER AND SET ITS VALUE TO THE NEXT ONE
                for (int j = 0; j < cilynder.Count - 1; j++)
                {
                    cilynder[j] = cilynder[j + 1];
                }

                //WE DONT HAVE THE VALUE OF THE ELEMENT AT INDEX 0
                //BUT WE STORED IT BEFORE THE LOOP
                //SO WE JUST SET THE LAST ELEMENT TO THE STORED VALUE
                cilynder[cilynder.Count - 1] = firstElement;
            }
        }

        //THE METHOD FOR SPINNING RIGHT
        private static void SpinRight(List<int> cilynder, int rotations)
        {
            //MINIMIZE THE ROTATIONS
            rotations = rotations % cilynder.Count;

            //ROTATION ALGORITHM
            for (int i = 0; i < rotations; i++)
            {
                //STORE THE LAST ELEMENT
                int lastElement = cilynder[cilynder.Count - 1];

                //TAKE EVERY OTHER AND SET ITS VALUE TO THE PREVIOUS ONE WITH A REVERSED LOOP
                for (int j = cilynder.Count - 1; j > 0; j--)
                {
                    cilynder[j] = cilynder[j - 1];
                }

                //WE DONT HAVE THE VALUE OF THE ELEMENT AT THE LAST INDEX
                //BUT WE STORED IT BEFORE THE LOOP
                //SO WE JUST SET THE FIRST ELEMENT TO THE STORED VALUE
                cilynder[0] = lastElement;
            }
        }

        //A SIMPLE LOOP WHICH RETURNS THE INDEX OF THE ELEMENT WITH VALUE - 1
        //WE USE IT TO FIND THE BULLET
        private static int FindBullet(List<int> cilynder)
        {
            int bulletIndex = -1;

            for (int i = 0; i < cilynder.Count; i++)
            {
                if (cilynder[i] == 1)
                {
                    bulletIndex = i;
                    break;
                }
            }

            return bulletIndex;
        }
    }
}