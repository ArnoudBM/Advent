using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2._1
{
    // http://adventofcode.com/2016/day/2
    class Program
    {
        private const string Line1 =
            "DUURRDRRURUUUDLRUDDLLLURULRRLDULDRDUULULLUUUDRDUDDURRULDRDDDUDDURLDLLDDRRURRUUUDDRUDDLLDDDURLRDDDULRDUDDRDRLRDUULDLDRDLUDDDLRDRLDLUUUDLRDLRUUUDDLUURRLLLUUUUDDLDRRDRDRLDRLUUDUDLDRUDDUDLLUUURUUDLULRDRULURURDLDLLDLLDUDLDRDULLDUDDURRDDLLRLLLLDLDRLDDUULRDRURUDRRRDDDUULRULDDLRLLLLRLLLLRLURRRLRLRDLULRRLDRULDRRLRURDDLDDRLRDLDRLULLRRUDUURRULLLRLRLRRUDLRDDLLRRUDUDUURRRDRDLDRUDLDRDLUUULDLRLLDRULRULLRLRDRRLRLULLRURUULRLLRRRDRLULUDDUUULDULDUDDDUDLRLLRDRDLUDLRLRRDDDURUUUDULDLDDLDRDDDLURLDRLDURUDRURDDDDDDULLDLDLU";

        private const string Line2 =
            "LURLRUURDDLDDDLDDLULRLUUUDRDUUDDUDLDLDDLLUDURDRDRULULLRLDDUDRRDRUDLRLDDDURDUURLUURRLLDRURDRLDURUDLRLLDDLLRDRRLURLRRUULLLDRLULURULRRDLLLDLDLRDRRURUUUDUDRUULDLUDLURLRDRRLDRUDRUDURLDLDDRUULDURDUURLLUDRUUUUUURRLRULUDRDUDRLLDUDUDUULURUURURULLUUURDRLDDRLUURDLRULDRRRRLRULRDLURRUULURDRRLDLRUURUDRRRDRURRLDDURLUDLDRRLDRLLLLRDUDLULUDRLLLDULUDUULLULLRLURURURDRRDRUURDULRDDLRULLLLLLDLLURLRLLRDLLRLUDLRUDDRLLLDDUDRLDLRLDUDU";

        private const string Line3 =
            "RRDDLDLRRUULRDLLURLRURDLUURLLLUUDDULLDRURDUDRLRDRDDUUUULDLUDDLRDULDDRDDDDDLRRDDDRUULDLUDUDRRLUUDDRUDLUUDUDLUDURDURDLLLLDUUUUURUUURDURUUUUDDURULLDDLDLDLULUDRULULULLLDRLRRLLDLURULRDLULRLDRRLDDLULDDRDDRURLDLUULULRDRDRDRRLLLURLLDUUUDRRUUURDLLLRUUDDDULRDRRUUDDUUUDLRRURUDDLUDDDUDLRUDRRDLLLURRRURDRLLULDUULLURRULDLURRUURURRLRDULRLULUDUULRRULLLDDDDURLRRRDUDULLRRDURUURUUULUDLDULLUURDRDRRDURDLUDLULRULRLLURULDRUURRRRDUDULLLLLRRLRUDDUDLLURLRDDLLDLLLDDUDDDDRDURRL";

        private const string Line4 =
            "LLRURUDUULRURRUDURRDLUUUDDDDURUUDLLDLRULRUUDUURRLRRUDLLUDLDURURRDDLLRUDDUDLDUUDDLUUULUUURRURDDLUDDLULRRRUURLDLURDULULRULRLDUDLLLLDLLLLRLDLRLDLUULLDDLDRRRURDDRRDURUURLRLRDUDLLURRLDUULDRURDRRURDDDDUUUDDRDLLDDUDURDLUUDRLRDUDLLDDDDDRRDRDUULDDLLDLRUDULLRRLLDUDRRLRURRRRLRDUDDRRDDUUUDLULLRRRDDRUUUDUUURUULUDURUDLDRDRLDLRLLRLRDRDRULRURLDDULRURLRLDUURLDDLUDRLRUDDURLUDLLULDLDDULDUDDDUDRLRDRUUURDUULLDULUUULLLDLRULDULUDLRRURDLULUDUDLDDRDRUUULDLRURLRUURDLULUDLULLRD";

        private const string Line5 =
            "UURUDRRDDLRRRLULLDDDRRLDUDLRRULUUDULLDUDURRDLDRRRDLRDUUUDRDRRLLDULRLUDUUULRULULRUDURDRDDLDRULULULLDURULDRUDDDURLLDUDUUUULRUULURDDDUUUURDLDUUURUDDLDRDLLUDDDDULRDLRUDRLRUDDURDLDRLLLLRLULRDDUDLLDRURDDUDRRLRRDLDDUDRRLDLUURLRLLRRRDRLRLLLLLLURULUURRDDRRLRLRUURDLULRUUDRRRLRLRULLLLUDRULLRDDRDDLDLDRRRURLURDDURRLUDDULRRDULRURRRURLUURDDDUDLDUURRRLUDUULULURLRDDRULDLRLLUULRLLRLUUURUUDUURULRRRUULUULRULDDURLDRRULLRDURRDDDLLUDLDRRRRUULDDD";

        static void Main(string[] args)
        {
            char position = '5';
            string output = string.Empty;

            position = ProcessLine(Line1, position);
            output += position;

            position = ProcessLine(Line2, position);
            output += position;

            position = ProcessLine(Line3, position);
            output += position;

            position = ProcessLine(Line4, position);
            output += position;

            position = ProcessLine(Line5, position);
            output += position;

            Console.WriteLine(output);
            Console.ReadKey();
        }


        static char ProcessLine(string line, char position)
        {
            foreach (var c in line)
            {
                switch (c)
                {
                    case 'U':
                        switch (position)
                        {
                            case '3':
                                position = '1';
                                break;
                            case '6':
                                position = '2';
                                break;
                            case '7':
                                position = '3';
                                break;
                            case '8':
                                position = '4';
                                break;
                            case 'A':
                                position = '6';
                                break;
                            case 'B':
                                position = '7';
                                break;
                            case 'C':
                                position = '8';
                                break;
                            case 'D':
                                position = 'B';
                                break;
                        }
                        break;
                    case 'D':
                        switch (position)
                        {
                            case '1':
                                position = '3';
                                break;
                            case '2':
                                position = '6';
                                break;
                            case '3':
                                position = '7';
                                break;
                            case '4':
                                position = '8';
                                break;
                            case '6':
                                position = 'A';
                                break;
                            case '7':
                                position = 'B';
                                break;
                            case '8':
                                position = 'C';
                                break;
                            case 'B':
                                position = 'D';
                                break;
                        }
                        break;
                    case 'L':
                        switch (position)
                        {
                            case '3':
                                position = '2';
                                break;
                            case '4':
                                position = '3';
                                break;
                            case '6':
                                position = '5';
                                break;
                            case '7':
                                position = '6';
                                break;
                            case '8':
                                position = '7';
                                break;
                            case '9':
                                position = '8';
                                break;
                            case 'B':
                                position = 'A';
                                break;
                            case 'C':
                                position = 'B';
                                break;
                        }
                        break;
                    case 'R':
                        switch (position)
                        {
                            case '2':
                                position = '3';
                                break;
                            case '3':
                                position = '4';
                                break;
                            case '5':
                                position = '6';
                                break;
                            case '6':
                                position = '7';
                                break;
                            case '7':
                                position = '8';
                                break;
                            case '8':
                                position = '9';
                                break;
                            case 'A':
                                position = 'B';
                                break;
                            case 'B':
                                position = 'C';
                                break;
                        }
                        break;
                }

                Console.WriteLine($"{c} {position}");
            }

            return position;
        }
    }
}
