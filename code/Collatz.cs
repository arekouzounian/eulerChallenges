using System;

namespace Collatz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the number you would like to plug in as the starting value.");
            //long userInput = long.Parse(Console.ReadLine());
            //userInputCollatz(userInput);
            Console.WriteLine("This program will output the integer that outputs the largest Collatz series under 1 million.");
            const int maximum = 1000000;

            long largestSequence = 0;
            long num = 0; 
            long step = 0;
            long currentNum;
            for(long i = 2; i < maximum; i++)
            {
                currentNum = i;
                step = 1;
                while(currentNum != 1)
                {
                    if (currentNum % 2 == 0) //if number is even
                    {
                        currentNum /= 2;
                    }
                    else //if number is odd
                    {
                        currentNum = (3 * currentNum) + 1;
                    }
                    step++;
                }
                if(step > largestSequence)
                {
                    largestSequence = step;
                    num = i;
                }
            }
            Console.WriteLine($"The largest sequence with a number under 1 million is produced with {num}, and is iterated {largestSequence} times.");

            Console.ReadKey();
        }

        public static void userInputCollatz(long userInput)
        {
            //long temp = userInput;
            //long stepNumber = 1;
            //while(temp != 1)
            //{
            //    if(temp % 2 == 0) //even
            //    {
            //        Console.WriteLine($"Step {stepNumber}: {temp} is even, so it becomes {temp / 2}.");
            //        temp /= 2;
            //    }
            //    else //odd
            //    {
            //        Console.WriteLine($"Step {stepNumber}: {temp} is odd, so it becomes {(3 * temp) + 1}.");
            //        temp = (3 * temp) + 1;
            //    }
            //    stepNumber++;
            //}
            //Console.WriteLine($"The number {userInput} became 1 after {stepNumber} iterations of the Collatz Conjecture.");
        }
    }
}
