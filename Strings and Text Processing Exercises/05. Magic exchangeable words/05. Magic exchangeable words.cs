using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split();
            string firstWord = words[0];
            string secondWord = words[1];

            Dictionary<char, char> map = new Dictionary<char, char>();

            int len = Math.Min(firstWord.Length, secondWord.Length);

            for (int i = 0; i < len; i++)
            {
                if (!map.ContainsKey(firstWord[i]))
                {
                    if (map.ContainsValue(secondWord[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                    map.Add(firstWord[i], secondWord[i]);
                }
                else
                {
                    if(map[firstWord[i]] != secondWord[i])
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }

            if(firstWord.Length == secondWord.Length)
            {
                Console.WriteLine("true");
                return;
            }

            string substr = String.Empty;

            if(firstWord.Length > secondWord.Length)
            {
                substr = firstWord.Substring(len);
            }
            else
            {
                substr = secondWord.Substring(len);
            }

            bool isContained = true;

            foreach (char c in substr)
            {
                if(!map.Keys.Contains(c) && !map.Values.Contains(c))
                {
                    isContained = false;
                    break;
                }
            }

            if (!isContained)
            {
                Console.WriteLine("false");
                return;
            }
            Console.WriteLine("true");
        }
    }
}
