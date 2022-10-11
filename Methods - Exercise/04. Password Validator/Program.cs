using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input -> string password
            string password = Console.ReadLine();

            IsValid(password);
        }

        //2.Method to check if the password is valid.
        static void IsValid(string password)
        {
            bool isLengthValid = false;
            bool isLetterValid = false;
            bool isDigitsValid = false;

            if (password.Length >= 6 && password.Length <= 10)
            {
                isLengthValid = true;

                for (int i = 0; i < password.Length; i++)
                {
                    if ((password[i] >= 48 && password[i] <= 57) ||
                        (password[i] >= 65 && password[i] <= 90) ||
                        (password[i] >= 97 && password[i] <= 122))
                    {
                        isLetterValid = true;
                    }
                    else
                    {
                        isLetterValid = false;
                        Console.WriteLine("Password must consist only of letters and digits");
                        break;
                    }
                }

                int digitsCount = 0;
                for (int i = 0; i < password.Length; i++)
                {
                    if (password[i] >= 48 && password[i] <= 57)
                    {
                        digitsCount++;
                    }
                }

                if (digitsCount >= 2)
                {
                    isDigitsValid = true;
                }
                else
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
            else
            {
                isLengthValid = false;

                Console.WriteLine("Password must be between 6 and 10 characters ");
                for (int i = 0; i < password.Length; i++)
                {
                    if ((password[i] >= 48 && password[i] <= 57) ||
                        (password[i] >= 65 && password[i] <= 90) ||
                        (password[i] >= 97 && password[i] <= 122))
                    {
                        isLetterValid = true;
                    }
                    else
                    {
                        isLetterValid = false;
                        Console.WriteLine("Password must consist only of letters and digits");
                        break;
                    }
                }

                int digitsCount = 0;
                for (int i = 0; i < password.Length; i++)
                {
                    if (password[i] >= 48 && password[i] <= 57)
                    {
                        digitsCount++;
                    }
                }

                if (digitsCount >= 2)
                {
                    isDigitsValid = true;
                }
                else
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }

            if (isLengthValid && isLetterValid && isDigitsValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
