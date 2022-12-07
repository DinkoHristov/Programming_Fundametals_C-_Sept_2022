using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _1._Winning_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ',', ' '};
            string[] input = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"^.*([\@]{6,10}|[\#]{6,10}|[\$]{6,10}|[\^]{6,10}).*\1.*$";
            Regex regex = new Regex(pattern);

            foreach (string currTicket in input)
            {
                if(currTicket.Length == 20)
                {
                    //Considered to be a winning ticket
                    //But we need to have 6 characters uninteruptedly repeating
                    //[$, @, ^, #] are the chars
                    Match match = regex.Match(currTicket);
                    if (match.Success)
                    {
                        string leftHalf = currTicket.Substring(0, currTicket.Length / 2);
                        string rightHalf = currTicket.Substring(currTicket.Length / 2, currTicket.Length / 2);

                        //Winning pick must contains atleast 6 of this symbols to be a winning ticket
                        //pattern = @"[\@\#\$\^]{6,10}";
                        pattern = @"(\@|\#|\$|\^)\1{5,10}";
                        regex = new Regex(pattern);
                        Match matchLeft = regex.Match(leftHalf);
                        Match matchRight = regex.Match(rightHalf);

                        if (matchLeft.Success && matchRight.Success)
                        {
                            char matchValue = matchRight.Value[1];

                            int matchCount = 0;
                            if (matchLeft.Length > matchRight.Length)
                            {
                                matchCount = matchRight.Length;
                            }
                            else
                            {
                                matchCount = matchLeft.Length;
                            }

                            //It is a lottery ticket
                            if (matchCount >= 6 && matchCount <= 9)
                            {
                                Console.WriteLine($"ticket \"{currTicket}\" - {matchCount}{matchValue}");
                            }
                            else if (matchCount == 10)
                            {
                                //Jackpot!
                                Console.WriteLine($"ticket \"{currTicket}\" - {matchCount}{matchValue} Jackpot!");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{currTicket}\" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{currTicket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
