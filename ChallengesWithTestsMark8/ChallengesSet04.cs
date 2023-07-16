using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            int result = 0;

            foreach( int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number;
                }
                else
                {
                    result -= number;
                }
            }
            return result;

        }
        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {

            {
                int shortestLength = int.MaxValue;

                if (str1.Length < shortestLength)
                    shortestLength = str1.Length;

                if (str2.Length < shortestLength)
                    shortestLength = str2.Length;

                if (str3.Length < shortestLength)
                    shortestLength = str3.Length;

                if (str4.Length < shortestLength)
                    shortestLength = str4.Length;

                return shortestLength;
            }

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestNumber = int.MaxValue;

            if (number1 < smallestNumber)
                smallestNumber = number1;

            if (number2 < smallestNumber)
                smallestNumber = number2;

            if (number3 < smallestNumber)
                smallestNumber = number3;

            if (number4 < smallestNumber)
                smallestNumber = number4;

            return smallestNumber;

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            if  (biz != null)
            {
                biz.Name = "TrueCoders";
            }
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }
           return sideLength1 + sideLength2 > sideLength3 &&
           sideLength1 + sideLength3 > sideLength2 &&
           sideLength2 + sideLength3 > sideLength1;

        }

        public bool IsStringANumber(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            bool isNumber = double.TryParse(input, out _);

            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null || objs.Length == 0)
            {
                return false;
            }

            int nullCount = 0;
            int nonNullCount = 0;

            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    nullCount++;
                }
                else
                {
                    nonNullCount++;
                }
            }
            return nullCount > nonNullCount;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;
            int count = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                    count++;
                }
            }

            if (count == 0)
            {
                return 0;
            }

            return (double)sum / count;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Number must be non-negative.", nameof(number));
            }
            if (number == 0 || number == 1)
            {
                return 1;
            }
            int factorial = 1;
            for(int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
