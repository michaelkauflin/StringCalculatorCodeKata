
using NUnit.Framework;

namespace CodeKata.Tests
{
    [TestFixture]
    internal class StringCalculatorFixture
    {
        [TestCase("", ExpectedResult = 0)]
        [TestCase("1,2", ExpectedResult = 3)]
        public int AddTest(string input)
        {
            var stringCalculator = new StringCalculator();

            return stringCalculator.Add(input);
        }
    }
}
