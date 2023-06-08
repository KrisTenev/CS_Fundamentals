using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace E03_LegendaryFarming
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();

            keyMaterials["motes"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["shards"] = 0;

            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();

            //•	Shadowmourne - requires 250 Shards;
            //•	Valanyr - requires 250 Fragments;
            //•	Dragonwrath - requires 250 Motes;

            bool hasToBreak = false;

            while (!hasToBreak)
            {
                string[] input = Console.ReadLine().ToLower().Split(" ");

                hasToBreak = false;

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string materialType = input[i + 1];

                    string keyMaterialTypes = "motes fragments shards";

                    if (keyMaterialTypes.Contains(materialType))
                    {
                        keyMaterials[materialType] += quantity;

                        if (keyMaterials[materialType] >= 250)
                        {
                            switch (materialType)
                            {
                                case "motes":
                                    Console.WriteLine($"Dragonwrath obtained!");
                                    break;
                                    
                                case "fragments":
                                    Console.WriteLine($"Valanyr obtained!");
                                    break;

                                case "shards":
                                    Console.WriteLine($"Shadowmourne obtained!");
                                    break;
                            }

                            keyMaterials[materialType] -= 250;
                            hasToBreak = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(materialType))
                        {
                            junkMaterials[materialType] = 0;
                        }

                        junkMaterials[materialType] += quantity;
                    }
                }
            }

            keyMaterials = keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in keyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junkMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
