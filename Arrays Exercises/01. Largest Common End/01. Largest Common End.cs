using System;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            int smallerArrayLenght = Math.Min(firstArray.Length, secondArray.Length);

            int leftCounter = CheckArrays(firstArray, secondArray, smallerArrayLenght);
            Array.Reverse(firstArray);
            Array.Reverse(secondArray);
            int rightCounter = CheckArrays(firstArray, secondArray, smallerArrayLenght);

            Console.WriteLine(Math.Max(leftCounter,rightCounter));
        }

        private static int CheckArrays(string[] firstArray, string[] secondArray, int smallerArrayLenght)
        {
            int Counter = 0;
            for (int i = 0; i < smallerArrayLenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    Counter++;
                }
                else
                {
                    break;
                }
            }
            return Counter;
        }
    }
}
