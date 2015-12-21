
using System;
using System.Globalization;

namespace CodeKata
{
    public class StringCalculator
    {
        private static readonly char[] Delimiters = { ',', ';', '\n' };

        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            string[] items = numbers.Split(Delimiters);

            int sum = 0;

            foreach (string item in items)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }
                sum += Convert.ToInt32(item, NumberFormatInfo.InvariantInfo);
            }

            return sum;
        }
    }
}
