﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int aX, int aY)
        {
            X = aX;
            Y = aY;
        }

        public override bool Equals(object o)
        {
            Point p = (Point)o;
            return X == p.X && Y == p.Y;
        }

    }
}
