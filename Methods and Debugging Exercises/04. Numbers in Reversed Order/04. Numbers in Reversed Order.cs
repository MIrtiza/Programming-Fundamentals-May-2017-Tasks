using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(ReversedNum(num)); 
        }

        static double ReversedNum(double num)
        {
            var numString = num.ToString();
            var reversedString = string.Empty;

            for (int i = numString.Length-1; i >= 0; i--)
            {
                reversedString += numString[i];
            }
            var reversedNum = double.Parse(reversedString);
            return reversedNum;
        }
    }
}
