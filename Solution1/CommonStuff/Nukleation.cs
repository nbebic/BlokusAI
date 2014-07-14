using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokusAI.CommonStuff
{
    public class Nukleation
    {
        public int X;
        public int Y;
        public NukleationOrientation Orientation;
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
