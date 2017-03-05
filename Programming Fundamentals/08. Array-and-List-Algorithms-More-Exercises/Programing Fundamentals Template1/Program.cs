using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.IncreasingCrisis
{
    class IncreasingCrisis
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var firstLineToInsertInResultList = Console.ReadLine().Split().Select(int.Parse).ToList();
                                                                                                      

            var result = new List<int>(firstLineToInsertInResultList); 

            List<int> sequenceForInsertInResult = new List<int>(); 

            int index = 0; 

            bool isBreaksIncreasing = false; 

            for (int i = 0; i < number - 1; i++)
            {
                sequenceForInsertInResult.Clear(); 
                index = 0;  
                isBreaksIncreasing = false; 

                var commandLine = Console.ReadLine().Split().Select(int.Parse).ToList(); 

                sequenceForInsertInResult.Add(commandLine[0]);  
                for (int j = 0; j < commandLine.Count - 1; j++)
                {
                    if (commandLine[j] < commandLine[j + 1])
                    {         
                        sequenceForInsertInResult.Add(commandLine[j + 1]);
                    }
                    else
                    {
                        break;                  
                    }
                }

                if (commandLine.Count != sequenceForInsertInResult.Count) 
                {                                                         
                    isBreaksIncreasing = true;                            
                }

            for (int k = 0; k < result.Count; k++)
                {
                    if (result[k] <= sequenceForInsertInResult[0])  
                    {                                               
                        index++;
                    }
                    else
                    {
                        break;
                    }
                }

                result.InsertRange(index, sequenceForInsertInResult); 

                if (isBreaksIncreasing)  
                {                        
                    var startIndex = index + sequenceForInsertInResult.Count;
                    var removeNumberToEndTheList = result.Count - (index + sequenceForInsertInResult.Count);
                    result.RemoveRange(startIndex, removeNumberToEndTheList);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}