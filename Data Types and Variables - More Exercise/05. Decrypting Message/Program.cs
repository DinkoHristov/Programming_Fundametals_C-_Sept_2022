using System;
using static System.Net.Mime.MediaTypeNames;

namespace _05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input:
            // 	-> On the first line, you will receive the key
            //	-> On the second line, you will receive n – the number of lines, which will follow
            //	-> On the next n lines – you will receive lower and uppercase characters from the Latin alphabet
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string decryptedMessage = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int letterValue = (int)letter;
                decryptedMessage += (char)(letter + key);
            }

            //2.Output:
            //  -> Print the decrypted message.
            Console.WriteLine(decryptedMessage);
        }
    }
}
