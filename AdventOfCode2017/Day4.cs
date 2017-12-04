using System;

namespace AdventOfCode2017
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Day4
    {
        public static void GetPassPhrase(string path)
        {
            var input = System.IO.File.ReadAllLines(path);
            int validPhrasese = 0;

            foreach (var line in input)
            {
                var lineList = new List<string>(line.Split(' '));
                var sortedLineList = new List<string>();

                foreach (var word in lineList)
                {
                    char[] w = word.ToCharArray();
                    Array.Sort(w);
                    sortedLineList.Add(new string(w));
                }

                if (sortedLineList.Count == sortedLineList.Distinct().Count())
                {
                    validPhrasese += 1;
                }
            }

            Console.WriteLine(validPhrasese);
        }
    }
}
