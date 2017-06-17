using System;
using System.Linq;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main()

        {
            char[] firstArray = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int smallerArreyLenght = Math.Min(firstArray.Length, secondArray.Length);
            bool areEqual = false;

            for (int i = 0; i < smallerArreyLenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    continue;
                }
                else
                {
                    if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine(firstArray);
                        Console.WriteLine(secondArray);
                    }
                    else
                    {
                        Console.WriteLine(secondArray);
                        Console.WriteLine(firstArray);
                    }
                    areEqual = true;
                    break;
                }

            }
            if (!areEqual)
            {
                if (firstArray.Length <= secondArray.Length)
                {
                    Console.WriteLine(firstArray);
                    Console.WriteLine(secondArray);
                }
                else
                {
                    Console.WriteLine(secondArray);
                    Console.WriteLine(firstArray);
                }
            }
        }

    }
}
