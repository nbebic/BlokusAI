using System;
using System.Linq;

namespace BlokusAI.CommonStuff.Pieces
{
    public class U : Piece
    {
        public Coord[] D = {
            new Coord(1,0),
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(1,2)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,2),
            new Nukleation(1,0,4),
            new Nukleation(1,0,6),
            new Nukleation(0,2,0),
            new Nukleation(1,2,4),
            new Nukleation(1,2,6)
      };
        public Piece[] Orbits = {
            new U(),
            new U90(),
            new U180(),
            new U270()
      };
    }

    public class U90 : Piece
    {
        public Coord[] D = {
            new Coord(0,-1),
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(2,-1)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,4),
            new Nukleation(0,-1,6),
            new Nukleation(0,-1,0),
            new Nukleation(2,0,2),
            new Nukleation(2,-1,6),
            new Nukleation(2,-1,0)
      };
        public Piece[] Orbits = {
            new U(),
            new U90(),
            new U180(),
            new U270()
      };
    }

    public class U180 : Piece
    {
        public Coord[] D = {
            new Coord(-1,0),
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(-1,-2)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,6),
            new Nukleation(-1,0,0),
            new Nukleation(-1,0,2),
            new Nukleation(0,-2,4),
            new Nukleation(-1,-2,0),
            new Nukleation(-1,-2,2)
      };
        public Piece[] Orbits = {
            new U(),
            new U90(),
            new U180(),
            new U270()
      };
    }

    public class U270 : Piece
    {
        public Coord[] D = {
            new Coord(0,1),
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-2,1)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,0),
            new Nukleation(0,1,2),
            new Nukleation(0,1,4),
            new Nukleation(-2,0,6),
            new Nukleation(-2,1,2),
            new Nukleation(-2,1,4)
      };
        public Piece[] Orbits = {
            new U(),
            new U90(),
            new U180(),
            new U270()
      };
    }

}
