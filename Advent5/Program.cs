using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Advent5
{
    // http://adventofcode.com/2016/day/5
    class Program
    {
        static void Main(string[] args)
        {

            var id = "cxdnnyjw";

            var charsFound = 0;
            var index = 0;

            var password = new char[8] { '.', '.', '.', '.', '.', '.', '.', '.'};

            using (var md5Hash = MD5.Create())
            {
                while (charsFound < 8)
                {
                    string hash = GetMd5Hash(md5Hash, id + index);

                    if (hash.StartsWith("00000"))
                    {
                        var position = hash.Substring(5, 1);
                        var value = hash.Substring(6, 1);

                        if ("01234567".Contains(position))
                        {
                            var pos = int.Parse(position);

                            if (password[pos] == '.')
                            {
                                password[pos] = Char.Parse(value);
                                charsFound++;
                                Console.WriteLine(password);
                            }
                        }
                    }

                    index++;
                }
            }

            Console.WriteLine(password);

            Console.ReadKey();
        }


        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
