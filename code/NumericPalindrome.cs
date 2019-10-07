using System;

namespace NumericPalindromesEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            const long numbMax = 999;
            Console.WriteLine($"Largest Palindromic Number created from the product of two 3 digit numbers: ");
            int largestNum;
            for (int i = 100; i < numbMax; i++)
            {
                for(int j = 100; j < numbMax; j++)
                {
                    if(i * j )
                }
            }
        }

        public static int[] numToArray(int num)
        {
            string stringInt = $"{num}";
            int[] numArray = new int[stringInt.Length];
            string tempChar;
            for(int i = 0; i < numArray.Length; i++)
            {
                tempChar = $"{stringInt[i]}";
                numArray[i] = int.Parse(tempChar); 
            }
            

            return numArray;
        }
        public static bool isPalindromic(int num)
        {
            int[] numArray = numToArray(num);
            bool isPalindrome = false;
            if (numArray.Length % 2 == 0) //if even
            {
                int offset = numArray.Length / 2;
                for (int i = 0; i < offset; i++)
                {
                    if (numArray[i] == numArray[i + offset])
                    {
                        isPalindrome = true;
                    }
                    else
                    {
                        isPalindrome = false;
                    }
                }
            }
            else //if odd
            {
                int pivot = (numArray.Length / 2) + 1; 
                for(int i = 0; i < pivot; i++)
                {
                    if(numArray[i] == numArray[pivot + i])
                    {
                        isPalindrome = true;
                    }
                    else
                    {
                        isPalindrome = false;
                    }
                }
            }
            return isPalindrome;
        }
    }
}
