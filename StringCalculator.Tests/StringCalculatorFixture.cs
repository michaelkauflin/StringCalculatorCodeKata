
using NUnit.Framework;

namespace CodeKata.Tests
{
    [TestFixture]
    internal class StringCalculatorFixture
    {
        [TestCase("", ExpectedResult = 0)]
        public int AddTest(string input)
        {
            var stringCalculator = new StringCalculator();

            return stringCalculator.Add(input);
        }
    }
}
