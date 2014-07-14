using System;
using System.Linq;

namespace BlokusAI.CommonStuff.Pieces
{
    public class X : Piece
    {
        public Coord[] D = {
            new Coord(1,0),
            new Coord(0,1),
            new Coord(1,1),
            new Coord(2,1),
            new Coord(1,2)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(1,0,2),
            new Nukleation(1,0,4),
            new Nukleation(2,1,4),
            new Nukleation(2,1,6),
            new Nukleation(1,0,6),
            new Nukleation(1,0,0),
            new Nukleation(0,1,0),
            new Nukleation(0,1,2)
      };
        public Piece[] Orbits = {
            new X()
      };
    }

}