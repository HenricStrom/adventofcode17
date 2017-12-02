using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.Tests
{
    [TestClass]
    public class Day2Tests
    {
        [TestMethod]
        public void TestThatCheckSumCalculatesCorrectly()
        {
            //day2tests.txt består av
            //5195
            //753
            //2468
            var checkSum = Day2.GetChecksum(@"C:\Code\AdventOfCode2017\AdventOfCode2017\Utilities\day2test.txt");

            Assert.AreEqual(18, checkSum);
        }
    }
}
