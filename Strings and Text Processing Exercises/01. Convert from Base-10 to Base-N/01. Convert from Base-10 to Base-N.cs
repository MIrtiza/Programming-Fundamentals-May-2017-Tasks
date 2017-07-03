using System;
using System.Linq;
using System.Numerics;

namespace _01.Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var number = BigInteger.Parse(input[1]);
            var toBase = int.Parse(input[0]);
            
            var result = ConvertFromDecimalToBaseN(number,toBase);
            Console.WriteLine(result);
        }

         static string ConvertFromDecimalToBaseN(BigInteger number, int toBase)
        {
            var result = string.Empty;
            while(number > 0)
            {
                var remainder = number % toBase;

                result = remainder + result;
                number /= toBase;
            }

            return result;
        }
    }
}
