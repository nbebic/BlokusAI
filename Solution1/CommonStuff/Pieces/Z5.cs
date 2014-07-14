using System;
using System.Linq;

namespace BlokusAI.CommonStuff.Pieces
{
    public class Z5 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(1,0),
            new Coord(1,1),
            new Coord(1,2),
            new Coord(2,2)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,0),
            new Nukleation(0,0,2),
            new Nukleation(1,0,4),
            new Nukleation(1,2,0),
            new Nukleation(2,2,4),
            new Nukleation(2,2,6)
      };
        public Piece[] Orbits = {
            new Z5(),
            new Z590(),
            new Z5R(),
            new Z5R90()
      };
    }

    public class Z590 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(1,-1),
            new Coord(2,-1),
            new Coord(2,-2)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,2),
            new Nukleation(0,0,4),
            new Nukleation(0,-1,6),
            new Nukleation(2,-1,2),
            new Nukleation(2,-2,6),
            new Nukleation(2,-2,0)
      };
        public Piece[] Orbits = {
            new Z5(),
            new Z590(),
            new Z5R(),
            new Z5R90()
      };
    }

    public class Z5R : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-1,1),
            new Coord(-1,2),
            new Coord(-2,2)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,6),
            new Nukleation(0,0,4),
            new Nukleation(-1,0,2),
            new Nukleation(-1,2,6),
            new Nukleation(-2,2,2),
            new Nukleation(-2,2,0)
      };
        public Piece[] Orbits = {
            new Z5(),
            new Z590(),
            new Z5R(),
            new Z5R90()
      };
    }

    public class Z5R90 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(-1,-1),
            new Coord(-2,-1),
            new Coord(-2,-2)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,0),
            new Nukleation(0,0,6),
            new Nukleation(0,-1,4),
            new Nukleation(-2,-1,0),
            new Nukleation(-2,-2,4),
            new Nukleation(-2,-2,2)
      };
        public Piece[] Orbits = {
            new Z5(),
            new Z590(),
            new Z5R(),
            new Z5R90()
      };
    }

}
