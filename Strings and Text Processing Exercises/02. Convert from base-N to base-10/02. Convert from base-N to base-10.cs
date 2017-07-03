using System;
using System.Linq;
using System.Numerics;

namespace _02.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();

            var number = BigInteger.Parse(input[1]);
            var numberBase = int.Parse(input[0]);

            var result = ConvertFromBaseNToDecimal(number, numberBase);
            Console.WriteLine(result);
        }

        static BigInteger ConvertFromBaseNToDecimal(BigInteger number, int numberBase)
        {
            var numberAsString = number.ToString();

            var sum = new BigInteger(0);
            for (int power = 0; power < numberAsString.Length; power++)
            {
                var num = int.Parse(numberAsString[numberAsString.Length - 1 - power].ToString());

                var result = num * BigInteger.Pow(numberBase, power);
                sum += result;
            }

            return sum;
        }
    }
}
