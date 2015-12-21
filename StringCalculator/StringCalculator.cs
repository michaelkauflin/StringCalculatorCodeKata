
using System;
using System.Globalization;

namespace CodeKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            string[] items = numbers.Split(',');

            int sum = 0;

            foreach (string item in items)
            {
                sum += Convert.ToInt32(item, NumberFormatInfo.InvariantInfo);
            }

            return sum;
        }
    }
}
