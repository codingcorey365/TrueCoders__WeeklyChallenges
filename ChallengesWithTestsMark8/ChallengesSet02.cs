using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            // the value of the count of the array.Length is even. Not the total count of the array.
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //maxNum = numbers.Max();
            //minNum = numbers.Min();
            if (numbers == null)
            {
                return 0;
            }

            if(numbers.Count() == 0)
            {
                return 0;
            }

            return numbers.Max() + numbers.Min();
            
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var str1Length = str1.Length;
            var str2Length = str2.Length;

            return Math.Min(str1Length , str2Length);
        }

        public int Sum(int[] numbers)

            //sum of all nums
        {
            if(numbers== null)
                { return 0; }
            var sum = 0;
           
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            
            return sum;

            //if (numbers==null)
            //{
            //    return 0;
            //}
            //return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            //sum of even nums
            if (numbers == null)
            {
                return 0;
            }
            
            var sum = 0;

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
            // sum of list is odd?
        {
            if (numbers == null)
            {
                return false;
            }

            var sum = 0 ;


            //My original thought
            // for (int i = 0;i < numbers.Count;i++)
            //{
            //    sum += numbers[i];
            //}


            //More concise than a loop
            sum = numbers.Sum();

            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }








        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number == null || number < 1) 
            {  
                return 0; 
            }

            
            return number /2;


           

        }
    }
}
