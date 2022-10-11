using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input -> Read integers until receive "END"
            string input = Console.ReadLine();

            while (input != "END")
            {
                int number = int.Parse(input);

                CheckIsPalindrome(number);
                input = Console.ReadLine();
            }
        }

        //2.Method to check if the number is palindrome.
        static void CheckIsPalindrome(int number)
        {
            string stringNumber = number.ToString();
            string stringReversed = string.Empty;

            for (int i = stringNumber.Length - 1; i >= 0; i--)
            {
                stringReversed += stringNumber[i];
            }

            bool isPalindrome = false;
            int reversedNumber = int.Parse(stringReversed);
            if (number == reversedNumber)
            {
                isPalindrome = true;
                Console.WriteLine(isPalindrome.ToString().ToLower());
            }
            else
            {
                Console.WriteLine(isPalindrome.ToString().ToLower());
            }
        }
    }
}
