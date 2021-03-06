﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Pirate
{
    class Graphics
    {
        public static string[] Intro = File.ReadAllLines("ascii-intropirate.txt");
        public static string[] Player = File.ReadAllLines("ascii-player.txt");
        public static string[] Villain = File.ReadAllLines("ascii-villain.txt");
        public static string[] YourShip = File.ReadAllLines("yourship.txt");
        public static string[] ShipStatus = File.ReadAllLines("Shipstatus.txt");
        public static string[] PlayerAttack = File.ReadAllLines("PlayerAttack.txt");
        public static string[] EnemyAttack = File.ReadAllLines("EnemyAttack.txt");
        public static string[] Lost = File.ReadAllLines("lost.txt");
        public static string[] Won = File.ReadAllLines("won.txt");

        public static void Print(string[] file)
        {
            Console.Clear();
            foreach (var line in file)
            {
                Console.WriteLine(line);
            }
        }

        public static void ContinueAndClear()
        {
            Console.Write("Press enter to continue..");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
