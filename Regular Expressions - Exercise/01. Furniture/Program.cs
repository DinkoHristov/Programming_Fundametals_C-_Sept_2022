using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<count>\d+)(\.\d+)?$";
            Regex regex = new Regex(pattern);

            List<string> furniture = new List<string>();
            double totalSpend = 0;
            string input = string.Empty;
            while((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);
                if(match.Success)
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int count = int.Parse(match.Groups["count"].Value);

                    double totalPrice = count * price;
                    totalSpend += totalPrice;
                    furniture.Add(furnitureName);
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach(string furnitureName in furniture)
            {
                Console.WriteLine($"{furnitureName}");
            }
            Console.WriteLine($"Total money spend: {totalSpend:F2}");
        }
    }
}
