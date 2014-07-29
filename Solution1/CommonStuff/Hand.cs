using BlokusAI.CommonStuff.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlokusAI.CommonStuff
{
    class Hand
    {
        public List<Piece> Pieces;
        public Hand(List<Piece> p)
        {
            this.Pieces = p;
        }
    }
}
