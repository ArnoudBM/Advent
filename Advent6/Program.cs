using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent6
{
    class Program
    {
        //http://adventofcode.com/2016/day/6
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\..\6.txt");

            var letters = new ArrayList
            {
                new Dictionary<string, int>(),
                new Dictionary<string, int>(),
                new Dictionary<string, int>(),
                new Dictionary<string, int>(),
                new Dictionary<string, int>(),
                new Dictionary<string, int>(),
                new Dictionary<string, int>(),
                new Dictionary<string, int>(),
            };


            foreach (string line in lines)
            {
                for (var i=0; i < 8; i++)
                {
                    var letter = line.Substring(i, 1);
                    var dict = (Dictionary<string, int>) letters[i];
                    if (dict.ContainsKey(letter))
                    {
                        dict[letter]++;
                    }
                    else
                    {
                        dict.Add(letter,1);
                    }
                }
            }

            var message = string.Empty;

            for (var i = 0; i < 8; i++)
            {
                message += GetHighestCount((Dictionary<string, int>) letters[i]);
            }


            Console.WriteLine(message);

            Console.ReadKey();
        }

        private static string GetHighestCount(Dictionary<string, int> dictionary)
        {
            var letter = string.Empty;
            var count = Int32.MaxValue;

            foreach (var key in dictionary.Keys)
            {
                if (dictionary[key] < count)
                {
                    letter = key;
                    count = dictionary[key];
                }
            }

            return letter;
        }
    }
}

