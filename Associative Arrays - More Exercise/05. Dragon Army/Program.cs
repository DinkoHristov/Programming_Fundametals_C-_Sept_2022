using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace _05._Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Format -> Key(type), Value(Key(name), Value(damage, health, armor))
            Dictionary<string, SortedDictionary<string, List<int>>> dragons =
                new Dictionary<string, SortedDictionary<string, List<int>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] dragonInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = dragonInfo[0];
                string name = dragonInfo[1];
                string damage = dragonInfo[2];
                string health = dragonInfo[3];
                string armor = dragonInfo[4];

                if (damage == "null")
                {
                    damage = "45";
                }

                if (health == "null")
                {
                    health = "250";
                }

                if (armor == "null")
                {
                    armor = "10";
                }

                int intDamage = int.Parse(damage);
                int intHealth = int.Parse(health);
                int intArmor = int.Parse(armor);

                if (dragons.ContainsKey(type))
                {
                    if (!dragons[type].ContainsKey(name))
                    {
                        List<int> attributes = new List<int>();
                        attributes.Add(intDamage);
                        attributes.Add(intHealth);
                        attributes.Add(intArmor);
                        dragons[type].Add(name, attributes);
                    }
                    else
                    {
                        List<int> attributes = new List<int>();
                        attributes.Add(intDamage);
                        attributes.Add(intHealth);
                        attributes.Add(intArmor);
                        dragons[type][name] = attributes;
                    }
                }
                else
                {
                    dragons.Add(type, new SortedDictionary<string, List<int>>());
                    List<int> attributes = new List<int>();
                    attributes.Add(intDamage);
                    attributes.Add(intHealth);
                    attributes.Add(intArmor);
                    dragons[type].Add(name, attributes);
                }
            }

            List<string> dragonStats = new List<string>();

            foreach (var dragon in dragons.Values)
            {
                double damage = 0;
                double health = 0;
                double armor = 0;
                int count = 0;

                foreach (var stat in dragon.Values)
                {
                    damage += stat[0];
                    health += stat[1];
                    armor += stat[2];
                    count++;
                }

                string attributes = $"({damage / count:F2}/{health / count:F2}/{armor / count:F2})";
                dragonStats.Add(attributes);
            }

            int countStats = 0;
            foreach (var type in dragons)
            {
                string item = dragonStats[countStats];

                Console.WriteLine($"{type.Key}::{item}");

                foreach (var dragon in type.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> " +
                        $"damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }

                countStats++;
            }
        }
    }
}
