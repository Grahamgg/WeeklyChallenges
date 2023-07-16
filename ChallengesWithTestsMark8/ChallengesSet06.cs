using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
                return false;

            StringComparison comparison = ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;

            foreach ( string item in words)
            {
                if (item != null && item.Equals(word, comparison))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if ( num <= 1)
            {
                return false;
            }

            if(num <= 3)
            {
                return true;
            }

            if (num % 2 == 0 || num % 3 == 0)
                return false;

            int divisor = 5;
            while(divisor * divisor <= num)
            {
                if (num % divisor == 0 || num % (divisor + 2) == 0)
                        return false;
                divisor += 6;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
                return -1;

            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {

                char currentChar = str[i];
                if (letterCount.ContainsKey(currentChar))
                {
                    letterCount[currentChar]++;
                }
                else
                {
                    letterCount[currentChar] = 1;
                }
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                char currentChar = str[i];
                if (letterCount[currentChar] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            int maxCount = 1;
            int currentCount = 1;

            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                    maxCount = Math.Max(maxCount, currentCount);
                }
                else
                {
                    currentCount = 1;
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0)
            {
                return new double[0];
            }

            List<double> everyNth = new List<double>();
            for (int i = n - 1; i < elements.Count; i += n)
            {
                everyNth.Add(elements[i]);
            }
            return everyNth.ToArray();
        }
    }
}
