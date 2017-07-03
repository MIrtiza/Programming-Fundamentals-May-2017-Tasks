using System;
using System.Text;

namespace _07.Multiply_big_number
{
    class Program
    {
        static void Main()
        {
            var firstNumber = Console.ReadLine().TrimStart('0');
            var secondNumber = Console.ReadLine();

            if (firstNumber == "0" || secondNumber == "0")
            {
                Console.WriteLine(0);
                return;
            }

            var inMind = 0;
            var remainder = 0;

            var result = new StringBuilder();

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                for (int j = secondNumber.Length - 1; j >= 0; j--)
                {
                    var firstNumberParsed = int.Parse(firstNumber[i].ToString());
                    var secondNumberParsed = int.Parse(secondNumber[j].ToString());

                    var sum = firstNumberParsed * secondNumberParsed + inMind;

                    inMind = sum / 10;
                    remainder = sum % 10;

                    result.Insert(0, remainder.ToString());

                    if (i == 0 && inMind != 0)
                    {
                        result.Insert(0, inMind.ToString());
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
