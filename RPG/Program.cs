﻿using System;
using System.Collections.Generic;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.Write("Enter the number of heroes: ");
            
            int numOfHeroes = Int32.Parse(Console.ReadLine());

            if(numOfHeroes % 2 != 0)
            {
                numOfHeroes += 1;
            }
            
            game.Start(numOfHeroes);
            
            Console.ReadKey();
        }
    }
}
