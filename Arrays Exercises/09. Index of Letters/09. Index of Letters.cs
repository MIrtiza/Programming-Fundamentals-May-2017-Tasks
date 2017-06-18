using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            foreach (var letter in text)
                Console.WriteLine(string.Join(" -> ", letter, letter - 'a'));
        }
    }
}
