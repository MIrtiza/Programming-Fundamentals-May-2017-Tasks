using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Phonebook_Upgrade
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "A":
                        phonebook[input[1]] = input[2];
                        break;
                    case "S":
                        if (phonebook.ContainsKey(input[1]))
                        {
                            Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                        }
                        else
                        {
                            Console.WriteLine("Contact {0} does not exist.", input[1]);
                        }
                        break;
                    case "ListAll":
                        {
                            foreach (var item in phonebook)
                            {
                                Console.WriteLine($"{item.Key} -> {item.Value}");
                            }
                        }
                        break;
                }
                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
