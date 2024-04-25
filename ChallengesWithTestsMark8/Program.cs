using System;


namespace ChallengesWithTestsMark8
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNextNumberDivisibleByNN( 5, 9);
        }

        public static int GetNextNumberDivisibleByNN(int startNumber, int n)
        {
            // set a bool to allow the while loop to infinitely continue
            bool test = true;
            do //executes code while true
            {
                if (startNumber == 0)
                {
                    startNumber = 1;
                }

                //math for given number modulus of n
                int result = startNumber % n;
                //ternary: if true then given number is already a modulus of n
                bool isBool = (result == 0) ? true : false;

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
    }
}
