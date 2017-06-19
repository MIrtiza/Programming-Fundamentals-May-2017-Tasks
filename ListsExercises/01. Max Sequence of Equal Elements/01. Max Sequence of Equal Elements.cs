using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            var inputArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var maxSequenceOfEqualElements = FindMaxSequenceOfEqualElements(inputArr);

            Console.WriteLine(string.Join(" ", maxSequenceOfEqualElements));




            //List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //int maxStart = 0;
            //int maxLen = 1;
            //int bestStart = 0;
            //int bestLen = 1;
            //for (int i = 0; i < numbers.Count-1; i++)
            //{

            //    if (numbers[bestLen] == numbers[bestLen+1])
            //    {
            //        maxLen++;
            //        if (maxLen > bestLen )
            //        {
            //            maxLen = bestLen;
            //            maxStart = numbers[bestStart];
            //        }
            //    }
            //    else
            //    {
            //        bestLen = 1;
            //        //bestStart = i;
            //    }
            //    bestStart++;
            //    if (bestLen == 1)
            //    {
            //        maxStart = numbers[0];
            //    }
            //}
            //for (int i = 0; i < bestStart; i++)
            //{
            //    Console.WriteLine("{0} ", maxStart);
            //}
        }

        static int[] FindMaxSequenceOfEqualElements(int[] arr)
        {
            var longestSequence = new List<int>();
            var currentSequence = new List<int>();
            currentSequence.Add(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                var currentNum = arr[i];
                var searchNum = currentSequence[0];

                if (currentNum == searchNum)
                {
                    currentSequence.Add(currentNum);
                }
                else
                {
                    if (currentSequence.Count > longestSequence.Count)
                    {
                        longestSequence = new List<int>(currentSequence);
                    }
                    currentSequence.Clear();
                    currentSequence.Add(currentNum);
                }
            }
            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence = new List<int>(currentSequence);
            }
            return longestSequence.ToArray();
        }
    }
}
