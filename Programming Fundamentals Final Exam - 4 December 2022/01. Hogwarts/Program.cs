using System;

namespace _01._Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We will receive an encrypted spell
            string spell = Console.ReadLine();

            //We will receive commands until "Abracadabra"
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Abracadabra")
            {
                //Command arguments will be splitted by space
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArgs[0];
                //We will have 5 different command types:
                //1.Abjuration
                if (commandType == "Abjuration")
                {
                    spell = spell.ToUpper();
                    Console.WriteLine(spell);
                }
                //2.Necromancy
                else if (commandType == "Necromancy")
                {
                    spell = spell.ToLower();
                    Console.WriteLine(spell);
                }
                //3.Illusion
                else if (commandType == "Illusion")
                {
                    //Illusion {index} {letter}
                    int index = int.Parse(commandArgs[1]);
                    string letter = commandArgs[2];

                    if (index >= 0 && index < spell.Length)
                    {
                        //Valid index
                        spell = spell.Remove(index, 1);
                        spell = spell.Insert(index, letter);
                        Console.WriteLine("Done!");
                        continue;
                    }

                    //If the index is not valid
                    Console.WriteLine("The spell was too weak.");
                }
                //4.Divination
                else if (commandType == "Divination")
                {
                    //Divination {firstSubstring} {secondSubstring}
                    string firstSubstring = commandArgs[1];
                    string secondSubstring = commandArgs[2];

                    if (spell.Contains(firstSubstring))
                    {
                        //If spell contains old string
                        spell = spell.Replace(firstSubstring, secondSubstring);
                        Console.WriteLine(spell);
                    }
                    else
                    {
                        //Skip
                        continue;
                    }
                }
                //5.Alteration
                else if (commandType == "Alteration")
                {
                    //Alteration {substring}
                    string substring = commandArgs[1];

                    if (spell.Contains(substring))
                    {
                        //If the spell contains our string
                        int index = spell.IndexOf(substring);
                        int length = substring.Length;
                        spell = spell.Remove(index, length);
                        Console.WriteLine(spell);
                        continue;
                    }
                    else
                    {
                        //Skip
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
            }
        }
    }
}
