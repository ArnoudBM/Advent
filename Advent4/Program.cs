using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace Advent4
{
    // http://adventofcode.com/2016/day/4
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\..\4.txt");

            int total = 0;
            foreach (string line in lines)
            {
                if (Check(line))
                {
                    Console.WriteLine(Decrypt(line));
                }
            }

            Console.WriteLine(total);

            Console.ReadKey();
        }

        private static bool Check(string line)
        {
            line = line.Replace("-", string.Empty);
            var letters = line.Substring(0,line.IndexOfAny(new[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'}, 0));
            var rest = line.Substring(line.IndexOfAny(new[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'})).Split(new [] {'[',']'});
            var section = int.Parse(rest[0]);
            var checksum = rest[1];
            var ding = new Dictionary<char, int>();

            foreach (var letter in letters)
            {
                if (ding.ContainsKey(letter))
                    ding[letter]++;
                else
                    ding.Add(letter, 1);
            }

            List<KeyValuePair<char,int>> sortedList = ding.ToList();

            sortedList.Sort(delegate(KeyValuePair<char, int> pair1, KeyValuePair<char, int> pair2)
                {
                    var valresult = -pair1.Value.CompareTo(pair2.Value);
                    if (valresult != 0) return valresult;
                    return pair1.Key.CompareTo(pair2.Key);
                }
            );
            var calculatedChecksum =
                sortedList[0].Key.ToString() +
                sortedList[1].Key.ToString() +
                sortedList[2].Key.ToString() + 
                sortedList[3].Key.ToString() + 
                sortedList[4].Key.ToString();

            if (checksum.Equals(calculatedChecksum))
                return true;
            else
                return false;
        }

        private static string Decrypt(string line)
        {
            var letters = line.Substring(0, line.IndexOfAny(new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }, 0));
            var rest = line.Substring(line.IndexOfAny(new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' })).Split(new[] { '[', ']' });
            var section = int.Parse(rest[0]);
            var decrypted = string.Empty;

            foreach (var c in letters)
            {
                if (c == '-')
                {
                    decrypted += " ";
                }
                else
                {
                    decrypted += Rotate(c, section).ToString();
                }
            }

            var hint = string.Empty;

            if (decrypted.Contains("north"))
                hint += "[NORTH]";
            if (decrypted.Contains("warehouse"))
                hint += "[WAREHOUSE]";
            if (decrypted.Contains("storage"))
                hint += "[STORAGE]";


            if (decrypted.Contains("bunny") ||
                decrypted.Contains("easter") ||
                decrypted.Contains("egg") ||
                decrypted.Contains("jelly") ||
                decrypted.Contains("grass") ||
                decrypted.Contains("flower") ||
                decrypted.Contains("rabbit") ||
                decrypted.Contains("chocolate"))
            return string.Empty;


            return decrypted + " [" + section + "]   " + hint;
        }

        private static char Rotate(char c, int number)
        {
            number = number%26;

            var output = (char)(c + number); 
            if (output > 'z')
                output = (char)(output - 26);

            return output;
        }

    }

}
