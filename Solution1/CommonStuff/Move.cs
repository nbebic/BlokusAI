using BlokusAI.CommonStuff.Pieces;
using System;
using System.Linq;

namespace BlokusAI.CommonStuff
{
    struct Move
    {
        public Piece P;
        public byte X;
        public byte Y;

        Move(Piece p, byte x, byte y)
        { 
            this.P = p;
            this.X = x;
            this.Y = y;
        }

        public bool IsValid(CommonGrid grid, byte player)
        {
            return grid.SafeToMove(this.P, this.X, this.Y, player);
        }
    }
}
