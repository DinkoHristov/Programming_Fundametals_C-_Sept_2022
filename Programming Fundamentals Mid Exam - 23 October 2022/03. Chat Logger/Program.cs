using System;
using System.Collections.Generic;

namespace _03._Chat_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chatLogger = new List<string>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArgs = input.Split();
                string inputType = inputArgs[0];

                if (inputType == "Chat")
                {
                    string message = inputArgs[1];
                    chatLogger.Add(inputArgs[1]);
                }
                else if (inputType == "Delete")
                {
                    string message = inputArgs[1];

                    if (chatLogger.Contains(message))
                    {
                        chatLogger.Remove(message);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (inputType == "Edit")
                {
                    string message = inputArgs[1];
                    string update = inputArgs[2];

                    if (chatLogger.Contains(message))
                    {
                        for (int i = 0; i < chatLogger.Count; i++)
                        {
                            string currentMessage = chatLogger[i];

                            if (currentMessage == message)
                            {
                                chatLogger[i] = update;
                                break;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (inputType == "Pin")
                {
                    string message = inputArgs[1];

                    if (chatLogger.Contains(message))
                    {
                        for (int i = 0; i < chatLogger.Count; i++)
                        {
                            string currentMessage = chatLogger[i];

                            if (currentMessage == message)
                            {
                                chatLogger.RemoveAt(i);
                                chatLogger.Add(message);
                                break;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (inputType == "Spam")
                {
                    for (int i = 1; i < inputArgs.Length; i++)
                    {
                        string currentMessage = inputArgs[i];

                        chatLogger.Add(currentMessage);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, chatLogger));
        }
    }
}
