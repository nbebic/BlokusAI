using System;
using System.Linq;

namespace BlokusAI.CommonStuff.Pieces
{
    public class V5 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(1,2),
            new Coord(2,2)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,2),
            new Nukleation(0,0,4),
            new Nukleation(0,2,0),
            new Nukleation(2,2,4),
            new Nukleation(2,2,6)
      };
        public Piece[] Orbits = {
            new V5(),
            new V590(),
            new V5180(),
            new V5270()
      };
    }

    public class V590 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(2,-1),
            new Coord(2,-2)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,4),
            new Nukleation(0,0,6),
            new Nukleation(2,0,2),
            new Nukleation(2,-2,6),
            new Nukleation(2,-2,0)
      };
        public Piece[] Orbits = {
            new V5(),
            new V590(),
            new V5180(),
            new V5270()
      };
    }

    public class V5180 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(-1,-2),
            new Coord(-2,-2)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,6),
            new Nukleation(0,0,0),
            new Nukleation(0,-2,4),
            new Nukleation(-2,-2,0),
            new Nukleation(-2,-2,2)
      };
        public Piece[] Orbits = {
            new V5(),
            new V590(),
            new V5180(),
            new V5270()
      };
    }

    public class V5270 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-2,1),
            new Coord(-2,2)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,0),
            new Nukleation(0,0,2),
            new Nukleation(-2,0,6),
            new Nukleation(-2,2,2),
            new Nukleation(-2,2,4)
      };
        public Piece[] Orbits = {
            new V5(),
            new V590(),
            new V5180(),
            new V5270()
      };
    }

}
