using BlokusAI.CommonStuff.Pieces;
using System;
using System.Linq;

namespace BlokusAI.CommonStuff
{
    public struct Move
    {
        public Piece P;
        public int X;
        public int Y;

        public Move(Piece p, int x, int y)
        { 
            this.P = p;
            this.X = x;
            this.Y = y;
        }
    }
}
