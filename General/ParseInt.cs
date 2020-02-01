using System;
using System.Collections.Generic;
using System.Text;

namespace General
{
    public class ParseInt
    {
        private static Dictionary<char, int> CharsToIntMap = new Dictionary<char, int>() {
                { '0', 0},
                { '1', 1},
                { '2', 2},
                { '3', 3},
                { '4', 4},
                { '5', 5},
                { '6', 6},
                { '7', 7},
                { '8', 8},
                { '9', 9},
            };
        public static int Parse(string input)
        {
            input = input.Trim();

            var firstChar = input[0];
            var isNegative = firstChar == '-';
            input = ClearInput(input);
            Validate(input);

            var result = 0;
            var power = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                var currentChar = input[i];
                var currentInt = CharsToIntMap[currentChar];
                result += currentInt * (int)Math.Pow(10, power++);
            }
            return isNegative ? result * -1 : result;
        }

        private static string ClearInput(string input)
        {
            var firstCharIsSign = input[0] == '-' || input[0] == '+';
            if (firstCharIsSign)
                input = input.Substring(1);
            var indexOfNonIntegerChar = -1;
            for (int i = 0; i < input.Length; i++)
                if (!CharsToIntMap.ContainsKey(input[i]))
                {
                    indexOfNonIntegerChar = i;
                    break;
                }

            return indexOfNonIntegerChar > 0 ? input.Substring(0, indexOfNonIntegerChar) : input;
        }

        private static void Validate(string input)
        {
            var firstChar = input[0];
            if (!CharsToIntMap.ContainsKey(firstChar))
                throw new ArgumentException($"Cannot parse due to invalid argument: {input}");
        }
    }
}
