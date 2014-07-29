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
        public Player player;
        public Nukleation(int x, int y, NukleationOrientation orientation, Player player)
        {
            X = x;
            Y = y;
            Orientation = orientation;
            this.player = player;
        }
        internal Nukleation(int x, int y, byte o)
            : this(x, y, (NukleationOrientation)(o==0?4:((o==4)?0:o)), Player.Both) { }

        public static implicit operator Coord(Nukleation n)
        {
            return new Coord(n.X, n.Y);
        }
    }
}
