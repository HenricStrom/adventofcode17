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
            string[] input = System.IO.File.ReadAllLines(filePath);

            int checkSum = 0;

            foreach (var row in input)
            {
                int lowestNumber = 10, highestNumber = 0;

                foreach (var c in row)
                {
                    int value = Convert.ToInt32(Char.GetNumericValue(c));

                    if (value > highestNumber)
                    {
                        highestNumber = value;
                    }
                    if (value < lowestNumber)
                    {
                        lowestNumber = value;
                    }
                }

                checkSum += highestNumber - lowestNumber;
            }

            Console.WriteLine(checkSum);
            return checkSum;
        }
    }
}
