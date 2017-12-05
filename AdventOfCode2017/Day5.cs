using System;

namespace AdventOfCode2017
{
    public static class Day5
    {
        public static int SolveMaze(string path)
        {
            var steps = 0;
            int nextIndex = 0;
            var input = System.IO.File.ReadAllLines(path);

            for (var i = 0; i < input.Length; )
            {
                var lineNumber = Convert.ToInt32(input[i]);

                
                nextIndex = i + lineNumber;

                if (lineNumber >= 3)
                {
                    var newValueOnIndexPos = lineNumber - 1;
                    input[i] = newValueOnIndexPos.ToString();
                }
                else
                {
                    var newValueOnIndexPos = lineNumber + 1;
                    input[i] = newValueOnIndexPos.ToString();
                }


                i = nextIndex;

                steps++;
            }
            
            return steps;
        }
    }
}
