using System;
using System.Linq;

namespace BlokusAI.CommonStuff.Pieces
{
    public class N : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(2,1),
            new Coord(3,1)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,0),
            new Nukleation(0,0,2),
            new Nukleation(2,0,4),
            new Nukleation(2,1,6),
            new Nukleation(3,1,4),
            new Nukleation(3,1,6)
      };
        public Piece[] Orbits = {
            new N(),
            new N90(),
            new N180(),
            new N270(),
            new NR(),
            new NR90(),
            new NR180(),
            new NR270()
      };
    }

    public class N90 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(1,-2),
            new Coord(1,-3)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,2),
            new Nukleation(0,0,4),
            new Nukleation(0,-2,6),
            new Nukleation(1,-2,0),
            new Nukleation(1,-3,6),
            new Nukleation(1,-3,0)
      };
        public Piece[] Orbits = {
            new N(),
            new N90(),
            new N180(),
            new N270(),
            new NR(),
            new NR90(),
            new NR180(),
            new NR270()
      };
    }

    public class N180 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-2,-1),
            new Coord(-3,-1)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,4),
            new Nukleation(0,0,6),
            new Nukleation(-2,0,0),
            new Nukleation(-2,-1,2),
            new Nukleation(-3,-1,0),
            new Nukleation(-3,-1,2)
      };
        public Piece[] Orbits = {
            new N(),
            new N90(),
            new N180(),
            new N270(),
            new NR(),
            new NR90(),
            new NR180(),
            new NR270()
      };
    }

    public class N270 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(-1,2),
            new Coord(-1,3)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,6),
            new Nukleation(0,0,0),
            new Nukleation(0,2,2),
            new Nukleation(-1,2,4),
            new Nukleation(-1,3,2),
            new Nukleation(-1,3,4)
      };
        public Piece[] Orbits = {
            new N(),
            new N90(),
            new N180(),
            new N270(),
            new NR(),
            new NR90(),
            new NR180(),
            new NR270()
      };
    }

    public class NR : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-2,1),
            new Coord(-3,1)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,6),
            new Nukleation(0,0,4),
            new Nukleation(-2,0,2),
            new Nukleation(-2,1,0),
            new Nukleation(-3,1,2),
            new Nukleation(-3,1,0)
      };
        public Piece[] Orbits = {
            new N(),
            new N90(),
            new N180(),
            new N270(),
            new NR(),
            new NR90(),
            new NR180(),
            new NR270()
      };
    }

    public class NR90 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(-1,-2),
            new Coord(-1,-3)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,0),
            new Nukleation(0,0,6),
            new Nukleation(0,-2,4),
            new Nukleation(-1,-2,2),
            new Nukleation(-1,-3,4),
            new Nukleation(-1,-3,2)
      };
        public Piece[] Orbits = {
            new N(),
            new N90(),
            new N180(),
            new N270(),
            new NR(),
            new NR90(),
            new NR180(),
            new NR270()
      };
    }

    public class NR180 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(2,-1),
            new Coord(3,-1)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,2),
            new Nukleation(0,0,0),
            new Nukleation(2,0,6),
            new Nukleation(2,-1,4),
            new Nukleation(3,-1,6),
            new Nukleation(3,-1,4)
      };
        public Piece[] Orbits = {
            new N(),
            new N90(),
            new N180(),
            new N270(),
            new NR(),
            new NR90(),
            new NR180(),
            new NR270()
      };
    }

    public class NR270 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(1,2),
            new Coord(1,3)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,4),
            new Nukleation(0,0,2),
            new Nukleation(0,2,0),
            new Nukleation(1,2,6),
            new Nukleation(1,3,0),
            new Nukleation(1,3,6)
      };
        public Piece[] Orbits = {
            new N(),
            new N90(),
            new N180(),
            new N270(),
            new NR(),
            new NR90(),
            new NR180(),
            new NR270()
      };
    }

}