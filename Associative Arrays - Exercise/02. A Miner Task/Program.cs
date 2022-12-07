using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> recourcesAndQuantity = new Dictionary<string, int>();

            string word = string.Empty;
            string resource = string.Empty;
            int count = 0;

            while((word = Console.ReadLine()) != "stop")
            {
                count++;

                if (count % 2 != 0)
                {
                    resource = word;
                    if (!recourcesAndQuantity.ContainsKey(resource))
                    {
                        recourcesAndQuantity.Add(resource, 0);
                    }
                }
                else
                {
                    int quantity = int.Parse(word);
                    recourcesAndQuantity[resource] += quantity;
                }
            }

            foreach(var myResource in recourcesAndQuantity)
            {
                Console.WriteLine($"{myResource.Key} -> {myResource.Value}");
            }
        }
    }
}
