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
        }
    }
}
