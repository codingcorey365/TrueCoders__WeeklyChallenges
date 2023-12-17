using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
                else
                {
                    sum -= number;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int str1value = str1.Length;
            int str2value = str2.Length;
            int str3value = str3.Length;
            int str4value = str4.Length;
            int[] array = new int[] { str1value, str2value, str3value, str4value };
            int min = array.Min();
            return min;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] array = new int[] { number1, number2, number3, number4 };
            int min = array.Min();
            return min;
        } 

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            switch (biz.Name)
            {
                case null:
                    biz.Name = "TrueCoders";
                    Console.WriteLine(biz.Name);
                    break;
                case "":
                    biz.Name = "TrueCoders";
                    Console.WriteLine(biz.Name);
                    break;
                case "true coders":
                    biz.Name = "TrueCoders";
                    Console.WriteLine(biz.Name);
                    break;
                case "truecoders":
                    biz.Name = "TrueCoders";
                    Console.WriteLine(biz.Name);
                    break;
                case "TRUECODERS":
                    biz.Name = "TrueCoders";
                    Console.WriteLine(biz.Name);
                    break;
                case "tRUEcODERS":
                    biz.Name = "TrueCoders";
                    Console.WriteLine(biz.Name);
                    break;
                case "test":
                    biz.Name = "TrueCoders";
                    Console.WriteLine(biz.Name);
                    break;
                default:
                    biz.Name = "TrueCoders";
                    break;
            }
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            // Zero and Negative Number check
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }
            
            // All the same numbers
            if (sideLength1 == sideLength2 && sideLength1 == sideLength3)
            {
                return true;
            }

            // Straight Line Condition
            if (sideLength1 == sideLength2 + sideLength3 || sideLength2 == sideLength1 + sideLength3 || sideLength3 == sideLength1 + sideLength2)
            {
                return false;
            }

            // Bool initialize for comparison
            var triangleOption1 = ((sideLength1 + sideLength2) > sideLength3);
            var triangleOption2 = ((sideLength2 + sideLength3) > sideLength1);
            var triangleOption3 = ((sideLength3 + sideLength1) > sideLength2);

            // Is Bool?
            if (triangleOption1 == true && triangleOption2 == true && triangleOption3 == true)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            if (input == null)
            {
                return false;
            }
            var success = decimal.TryParse(input, out decimal result);
            return success;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //int objsLength = objs.Length;
            int nullSum = 0;
            int nonNullSum = 0;
            foreach (var obj in objs)
            {
                if (obj == null)
                {
                     nullSum += 1;
                }
                else
                {
                     nonNullSum += 1;
                }
            }
            if (nullSum > nonNullSum)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
