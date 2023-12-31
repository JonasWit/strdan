﻿/* Plik przykładowy do rozdziału 2 - Tablice i listy. */

using System;
using System.Threading;

namespace CircularLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList<string> categories = new CircularLinkedList<string>();
            categories.AddLast("Sport");
            categories.AddLast("Kultura");
            categories.AddLast("Historia");
            categories.AddLast("Geografia");
            categories.AddLast("Ludzie");
            categories.AddLast("Technologia");
            categories.AddLast("Przyroda");
            categories.AddLast("Nauka");

            Random random = new Random();
            int totalTime = 0;
            int remainingTime = 0;
            foreach (string category in categories)
            {
                if (remainingTime <= 0)
                {
                    Console.WriteLine("Naciśnij klawisz [Enter], aby zacząć, lub dowolny inny, aby wyjść.");
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.Enter:
                            totalTime = random.Next(1000, 5000);
                            remainingTime = totalTime;
                            break;
                        default:
                            return;
                    }
                }

                int categoryTime = (-450 * remainingTime) / (totalTime - 50) + 500 + (22500 / (totalTime - 50));
                remainingTime -= categoryTime;
                Thread.Sleep(categoryTime);

                Console.ForegroundColor = remainingTime <= 0 ? ConsoleColor.Red : ConsoleColor.Gray;
                Console.WriteLine(category);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
