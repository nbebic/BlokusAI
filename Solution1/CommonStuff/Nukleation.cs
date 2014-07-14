using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokusAI.CommonStuff
{
    public struct Nukleation
    {
        int X;
        int Y;
        NukleationOrientation Orientation;
        public Nukleation(int x, int y, byte orientation)
        {
            X = x;
            Y = y;
            Orientation = (NukleationOrientation)orientation;
        }

        public static implicit operator Coord(Nukleation n)
        {
            return new Coord(n.X, n.Y);
        }
    }
}
