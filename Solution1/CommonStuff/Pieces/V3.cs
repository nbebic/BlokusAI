using System;
using System.Linq;

namespace BlokusAI.CommonStuff.Pieces
{
    public class V3 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,1),
            new Coord(1,1)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,2),
            new Nukleation(0,0,4),
            new Nukleation(0,1,0),
            new Nukleation(1,1,4),
            new Nukleation(1,1,6)
      };
        public Piece[] Orbits = {
            new V3(),
            new V390(),
            new V3180(),
            new V3270()
      };
    }

    public class V390 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(1,0),
            new Coord(1,-1)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,4),
            new Nukleation(0,0,6),
            new Nukleation(1,0,2),
            new Nukleation(1,-1,6),
            new Nukleation(1,-1,0)
      };
        public Piece[] Orbits = {
            new V3(),
            new V390(),
            new V3180(),
            new V3270()
      };
    }

    public class V3180 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(-1,-1)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,6),
            new Nukleation(0,0,0),
            new Nukleation(0,-1,4),
            new Nukleation(-1,-1,0),
            new Nukleation(-1,-1,2)
      };
        public Piece[] Orbits = {
            new V3(),
            new V390(),
            new V3180(),
            new V3270()
      };
    }

    public class V3270 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-1,1)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,0),
            new Nukleation(0,0,2),
            new Nukleation(-1,0,6),
            new Nukleation(-1,1,2),
            new Nukleation(-1,1,4)
      };
        public Piece[] Orbits = {
            new V3(),
            new V390(),
            new V3180(),
            new V3270()
      };
    }

}

