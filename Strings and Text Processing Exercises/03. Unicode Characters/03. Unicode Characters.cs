using System;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().ToCharArray();

            foreach (var letter in input)
            {
                Console.Write($"\\u{(int)letter:x4}");
            }

            Console.WriteLine();
        }
    }
}
