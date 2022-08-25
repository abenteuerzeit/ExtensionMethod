using System;

namespace Extensions
{
    static class Utils
    {
        public static int ConvertToBase(this int i, int targetNumberBase)
        {
            if (targetNumberBase is < 2 or > 10)
            {
                throw new ArgumentException($"Value cannot be converted to base {targetNumberBase.ToString()}");
            }

            int result = 0;
            int iterations = 0;
            do
            {
                int nextDigit = i % targetNumberBase;
                i /= targetNumberBase;
                result += nextDigit * (int)Math.Pow(10, iterations);
                iterations++;
            }
            while (i != 0);
            return result;
        }
    }
}