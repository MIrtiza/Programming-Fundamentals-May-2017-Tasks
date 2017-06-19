using System;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            foreach (var letter in text)
                Console.WriteLine(string.Join(" -> ", letter, letter - 'a'));
        }
    }
}
