using System;
using System.Linq;


namespace BlokusAI.CommonStuff.Pieces
{
    public class Coord
    {
        public Coord(sbyte x, sbyte y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public sbyte Y { get; set; }
    }
}
