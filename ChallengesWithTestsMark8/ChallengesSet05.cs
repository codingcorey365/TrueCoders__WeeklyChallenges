using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Xml.Schema;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
           bool startNumberHasNoRemainder = startNumber % n == 0;
            // set a bool to allow the while loop to infinitely continue
            bool test = true;
            
            do //executes code while true
            {
                if (startNumberHasNoRemainder)
                {
                    startNumber++;
                }

                if (startNumber == 0)
                {
                    startNumber = 1;
                }


                //math for given number modulus of n
                double result = startNumber % n;
                //ternary: if true then given number is already a modulus of n
                bool isBool = (result == 0);

                if (isBool) // execute if true
                {
                    test = false; //terminates the while loop
                }
                else // if false - post increment
                {
                    startNumber++;
                }
            } while (test); // true unless line 21 is true

            return startNumber; // returns number that is a modulus of n

        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
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
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
           
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
            if (words == null || words.Length == 0)
            {
                return "";
            }

            string sentence = "";
            
            foreach (string word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }    
            }

            if (sentence.Length == 0)
            {
                return "";
            }

            sentence = sentence.Trim();
            sentence += ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            
            List<double> everyFourth = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                everyFourth.Add(elements[i]);
            }

            return everyFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }

}
