using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputCode = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, char> morseCode = new Dictionary<string, char>()
                                                    {
                                                        {".-", 'a'},
                                                        {"-...",'b' },
                                                        {"-.-.",'c' },
                                                        {"-..", 'd'},
                                                        {".",'e' },
                                                        {"..-.",'f' },
                                                        {"--.", 'g'},
                                                        {"....",'h' },
                                                        {"..", 'i' },
                                                        {".---", 'j'},
                                                        {"-.-",'k' },
                                                        {".-..", 'l' },
                                                        {"--", 'm' },
                                                        {"-.", 'n' },
                                                        {"---",'o' },
                                                        {".--.",'p'},
                                                        {"--.-",'q' },
                                                        {".-.",'r' },
                                                        {"...",'s' },
                                                        {"-",  't' },
                                                        {"..-",'u' },
                                                        {"...-",'v' },
                                                        {".--",'w' },
                                                        {"-..-",'x' },
                                                        {"-.--",'y' },
                                                        {"--..", 'z'},
                                                        {"-----", '0'},
                                                        {".----" ,'1'},
                                                        {"..---", '2'},
                                                        {"...--", '3'},
                                                        {"....-", '4'},
                                                        {".....", '5'},
                                                        {"-....", '6'},
                                                        {"--...", '7'},
                                                        {"---..", '8'},
                                                        {"----.", '9'}
                                                    };

            StringBuilder translatedCode = new StringBuilder();
            foreach(string currWord in inputCode)
            {
                if(morseCode.ContainsKey(currWord))
                {
                    translatedCode.Append(morseCode[currWord].ToString().ToUpper());
                }
                else if (currWord == "|")
                {
                    translatedCode.Append(" ");
                }
            }

            Console.WriteLine(translatedCode);
        }
    }
}
