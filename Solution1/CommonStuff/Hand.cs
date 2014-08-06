using BlokusAI.CommonStuff.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlokusAI.CommonStuff
{
    public class Hand
    {
        public List<Piece> Pieces;
        public Hand(List<Piece> p)
        {
            this.Pieces = p;
        }

        public static Hand FullHand = new Hand(new List<Piece>
        {
            Piece.l5,
            Piece.y ,
            Piece.n ,
            Piece.v3,
            Piece.u ,
            Piece.v5,
            Piece.z5,
            Piece.x ,
            Piece.t5,
            Piece.w ,
            Piece.p ,
            Piece.f ,
            Piece.o4,
            Piece.l4,
            Piece.t4,
            Piece.z4,
            Piece.i1,
            Piece.i2,
            Piece.i3,
            Piece.i4,
            Piece.i5
        }
            );
    }
}
