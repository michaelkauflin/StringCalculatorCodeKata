
using NUnit.Framework;

namespace CodeKata.Tests
{
    [TestFixture]
    internal class StringCalculatorFixture
    {
        [TestCase("", ExpectedResult = 0)]
        [TestCase("1,2", ExpectedResult = 3)]
        [TestCase("0", ExpectedResult = 0)]
        [TestCase("1", ExpectedResult = 1)]
        [TestCase("-1", ExpectedResult = -1)]
        [TestCase("2,-1", ExpectedResult = 1)]
        [TestCase("1,2,3,4,5,6,7,8,9,10", ExpectedResult = 55)]
        public int AddTest(string input)
        {
            var stringCalculator = new StringCalculator();

            return stringCalculator.Add(input);
        }
    }
}
