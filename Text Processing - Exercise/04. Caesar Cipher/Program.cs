using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder encryptedMessage = new StringBuilder();
            foreach(char letter in text)
            {
                char enryptedLetter = (char)(letter + 3);
                encryptedMessage.Append(enryptedLetter);
            }

            Console.WriteLine(encryptedMessage);
        }
    }
}
