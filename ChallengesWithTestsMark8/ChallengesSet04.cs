﻿using System;
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
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
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
