using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04.Punctuation_Finder
{
    class Program
    {
        static void Main()
        {

            String[] allLines = File.ReadAllLines(@"D:\Softuni\0.2 Tech Module - May 2017\Projects\10.ObjectsClassesFilesAndExceptiosMoreExers\04. Punctuation Finder\sample_text.txt");
            List<char> punctuations = new List<char>();
            char[] punctuatuinsToTake = new char[] { '.', ',', '!', '?', ':' };

            foreach (string line in allLines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (punctuatuinsToTake.Contains(line[i]))
                    {
                        punctuations.Add(line[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", punctuations));
        }
    }
}
