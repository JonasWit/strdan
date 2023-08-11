/* Plik przykładowy do rozdziału 4 - Słowniki i zbiory. */

using System;
using System.Collections.Generic;
using System.Linq;

namespace SetPools
{
    class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            Dictionary<PoolTypeEnum, HashSet<int>> tickets = new Dictionary<PoolTypeEnum, HashSet<int>>()
            {
                { PoolTypeEnum.REKREACYJNY, new HashSet<int>() },
                { PoolTypeEnum.SPORTOWY, new HashSet<int>() },
                { PoolTypeEnum.TERMALNY, new HashSet<int>() },
                { PoolTypeEnum.DZIECI, new HashSet<int>() }
            };

            for (int i = 1; i < 100; i++)
            {
                foreach (KeyValuePair<PoolTypeEnum, HashSet<int>> type in tickets)
                {
                    if (GetRandomBoolean())
                    {
                        type.Value.Add(i);
                    }
                }
            }

            Console.WriteLine("Liczba odwiedzających według typu basenu:");
            foreach (KeyValuePair<PoolTypeEnum, HashSet<int>> type in tickets)
            {
                Console.WriteLine($" - {type.Key.ToString().ToLower()}: {type.Value.Count}");
            }

            PoolTypeEnum maxVisitors = tickets
                .OrderByDescending(t => t.Value.Count)
                .Select(t => t.Key)
                .FirstOrDefault();
            Console.WriteLine($"Najbardziej popularny był basen '{maxVisitors.ToString().ToLower()}'.");

            HashSet<int> any = new HashSet<int>(tickets[PoolTypeEnum.REKREACYJNY]);
            any.UnionWith(tickets[PoolTypeEnum.SPORTOWY]);
            any.UnionWith(tickets[PoolTypeEnum.TERMALNY]);
            any.UnionWith(tickets[PoolTypeEnum.DZIECI]);
            Console.WriteLine($"{any.Count} - tyle osób poszło na co najmniej jeden basen.");

            HashSet<int> all = new HashSet<int>(tickets[PoolTypeEnum.REKREACYJNY]);
            all.IntersectWith(tickets[PoolTypeEnum.SPORTOWY]);
            all.IntersectWith(tickets[PoolTypeEnum.TERMALNY]);
            all.IntersectWith(tickets[PoolTypeEnum.DZIECI]);
            Console.WriteLine($"{all.Count} - tyle osób było na wszystkich basenach.");

            Console.WriteLine("REKREACYJNY: " + string.Join(" ", tickets[PoolTypeEnum.REKREACYJNY]));
            Console.WriteLine("SPORTOWY: " + string.Join(" ", tickets[PoolTypeEnum.SPORTOWY]));
            Console.WriteLine("TERMALNY: " + string.Join(" ", tickets[PoolTypeEnum.TERMALNY]));
            Console.WriteLine("DZIECI: " + string.Join(" ", tickets[PoolTypeEnum.DZIECI]));
        }

        private static bool GetRandomBoolean()
        {
            return random.Next(2) == 1;
        }
    }
}
