﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            using(Game game = new Game(25, 25, 1))//third int = 0 for normal or 1 for hard
            {
                game.Run(120, 60);
            }
        }
    }
}
