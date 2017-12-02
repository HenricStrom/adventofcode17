using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017
{
    public static class Day2
    {
        public static int GetChecksum(string filePath)
        {
            //part1
            var input = System.IO.File.ReadAllLines(filePath).Select(line => line.Split('\t').Select(x => int.Parse(x)));
            var sum1 = input.Select(row => row.Max() - row.Min()).Sum();
            Console.WriteLine(sum1);

            var sum2 = 0;

            var first = 0;
            var second = 0;

            //part2
            foreach(var row in input)
            {
                foreach(var character in row)
                {
                    bool isdividable = false;

                    foreach (var rest in row)
                    {
                        if (rest != character && character % rest == 0)
                        {
                            isdividable = true;
                            sum2 += character / rest;
                            break;
                        }
                    }

                    if (isdividable)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(sum2);
            return sum2;
        }
    }
}
