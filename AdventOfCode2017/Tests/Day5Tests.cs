namespace AdventOfCode2017.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Day5Tests
    {
        [TestMethod]
        public void SolveMaze()
        {
           var actualSteps = Day5.SolveMaze(@"C:\Dev\adventofcode17\AdventOfCode2017\Utilities\day5test.txt");

           Assert.AreEqual(5, actualSteps);
        }
    }
}
