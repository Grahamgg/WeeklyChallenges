using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int nextNumber = startNumber + 1;

            while (nextNumber % n != 0)
            {
                nextNumber++;
            }
            return nextNumber;


        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }
        
        public bool IsAscendingOrder(int[] numbers)
        {
            if ( numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }

               
            }
            return true;
        }
        

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;

            if (numbers == null)
            {
                return 0;

            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] % 2 == 0)
                {
                    sum += numbers[i];
                }
                
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if ( words == null || words.Length == 0)
            {
                return string.Empty;
            }

            StringBuilder sentence = new StringBuilder();
            
            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    sentence.Append(word.Trim()).Append(" ");
                }
            }
            if (sentence.Length > 0)
            {
                sentence.Length--;
                sentence.Append(".");
            }
            return sentence.ToString();

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if(elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            List<double> everyFourth = new List<double>();
            for(int i  = 3; i  <elements.Count; i += 4)
            {
                everyFourth.Add(elements[i]);
            }
            return everyFourth.ToArray();
            
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i <nums.Length; i++)
            {
                for(int k = i + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
