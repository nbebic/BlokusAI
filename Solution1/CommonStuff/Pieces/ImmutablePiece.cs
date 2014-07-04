using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokusAI.CommonStuff.Pieces
{
    public partial class ImmutablePiece : Piece
    {
        private List<Coord> list;

        public ImmutablePiece(List<Coord> list):base(list)
        { }
        public override Piece Reflect(Axis axis)
        {
            return this;
        }

        public override Piece Rotate(int amount)
        {
            return this;
        }
    }
}
