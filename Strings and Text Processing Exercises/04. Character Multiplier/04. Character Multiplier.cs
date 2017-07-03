using System;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main()
        {
            var strings = Console.ReadLine()
            .Split();

            var firstInput = strings[0];
            var secondInput = strings[1];

            var maxLength = Math.Max(firstInput.Length, secondInput.Length);

            var totalCharactersSum = CalculateCharactersSum(firstInput, secondInput, maxLength);

            Console.WriteLine(totalCharactersSum);
        }

        static long CalculateCharactersSum(string firstInput, string secondInput, int maxLength)
        {
            var totalSum = 0L;

            for (int i = 0; i < maxLength; i++)
            {
                if (firstInput.Length < i + 1)
                {
                    totalSum += secondInput[i];
                }

                else if (secondInput.Length < i + 1)
                {
                    totalSum += firstInput[i];
                }

                else
                {
                    totalSum += firstInput[i] * secondInput[i];
                }
            }

            return totalSum;
        }
    }
}
