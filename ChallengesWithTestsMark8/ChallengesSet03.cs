using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            // Used google and Chat GPT
            int sum = 0;

            if (numbers == null)
            {
                return false;
            }

            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }
            return sum % 2 != 0;

            //-----------------------Frustrated I cant get a simple program to work with out google or chat gpt....

            // this is the code that was not working
            //int count = 0;
            //foreach (int number in numbers)
            //{
            //    Check if the number is odd
            //    if (number % 2 != 0)
            //    {
            //        int sum = count += number;
            //        if (sum % 2 != 0)
            //        {
            //            return true;
            //        }
            //        else return false;
            //    }
            //    else return false;
            //}
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //Googled Chat GPT for answer

            // Check for an uppercase letter
            bool containsUpper = Regex.IsMatch(password, "[A-Z]");
            // Check for a lowercase letter
            bool containsLower = Regex.IsMatch(password, "[a-z]");
            // Check for a digit
            bool containsNumber = Regex.IsMatch(password, "[0-9]");

            return containsUpper && containsLower && containsNumber;
        }

        public char GetFirstLetterOfString(string val)
        { 
            string word = val;
            
            char[] letters = word.ToCharArray();
            
            return letters[0];              
        }

        public char GetLastLetterOfString(string val)
        {
            string word = val;

            char[] letters = word.ToCharArray();
                        
            return letters[letters.Length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
            
        }

        public int LastMinusFirst(int[] nums)
        {
            var first = nums[0];
            var last = nums[nums.Length-1];
            return last - first;

        }

        public int[] GetOddsBelow100()
        {
            // There are 50 odd numbers below 100 (1, 3, 5, ..., 99)
            int[] odds = new int[50];

            // Fill the array with odd numbers
            for (int i = 0, num = 1; i < odds.Length; i++, num += 2)
            {
                odds[i] = num;
            }

            // Return the array
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            // Check if the array is null or empty before attempting to process it
            if (words == null || words.Length == 0)
            {
                // Optionally handle the null or empty array scenario
                return;
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != null) // Check if the element is not null before converting to uppercase
                {
                    words[i] = words[i].ToUpper();
                }
            }
        }
    }
}
