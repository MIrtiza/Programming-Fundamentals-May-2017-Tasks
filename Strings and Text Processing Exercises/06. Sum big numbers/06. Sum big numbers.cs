using System;
using System.Text;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main()
        {
            var firstNumber = Console.ReadLine().TrimStart('0');
            var secondNumber = Console.ReadLine().TrimStart('0');

            var maxPad = Math.Max(firstNumber.Length, secondNumber.Length);
            var paddingChar = '0';

            if (firstNumber.Length != secondNumber.Length)
            {
                firstNumber = firstNumber.PadLeft(maxPad, paddingChar);
                secondNumber = secondNumber.PadLeft(maxPad, paddingChar);
            }

            var inMind = 0;
            var remainder = 0;

            var result = new StringBuilder();

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                var firstNumberParsed = int.Parse(firstNumber[i].ToString());
                var secondNumberParsed = int.Parse(secondNumber[i].ToString());

                var sum = firstNumberParsed + secondNumberParsed + inMind;

                inMind = sum / 10;
                remainder = sum % 10;

                result.Insert(0, remainder.ToString());

                if (i == 0 && inMind != 0)
                {
                    result.Insert(0, inMind.ToString());
                }
            }

            Console.WriteLine(result);
        }
    }
}
