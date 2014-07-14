using System;
using System.Linq;

namespace BlokusAI.CommonStuff.Pieces
{
    public class L5 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(3,0),
            new Coord(3,1)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,0),
            new Nukleation(0,0,2),
            new Nukleation(3,0,4),
            new Nukleation(3,1,6),
            new Nukleation(3,1,0)
      };
        public Piece[] Orbits = {
            new L5(),
            new L590(),
            new L5180(),
            new L5270(),
            new L5R(),
            new L5R90(),
            new L5R180(),
            new L5R270()
      };
    }

    public class L590 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(0,-3),
            new Coord(1,-3)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,2),
            new Nukleation(0,0,4),
            new Nukleation(0,-3,6),
            new Nukleation(1,-3,0),
            new Nukleation(1,-3,2)
      };
        public Piece[] Orbits = {
            new L5(),
            new L590(),
            new L5180(),
            new L5270(),
            new L5R(),
            new L5R90(),
            new L5R180(),
            new L5R270()
      };
    }

    public class L5180 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-3,0),
            new Coord(-3,-1)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,4),
            new Nukleation(0,0,6),
            new Nukleation(-3,0,0),
            new Nukleation(-3,-1,2),
            new Nukleation(-3,-1,4)
      };
        public Piece[] Orbits = {
            new L5(),
            new L590(),
            new L5180(),
            new L5270(),
            new L5R(),
            new L5R90(),
            new L5R180(),
            new L5R270()
      };
    }

    public class L5270 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(0,3),
            new Coord(-1,3)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,6),
            new Nukleation(0,0,0),
            new Nukleation(0,3,2),
            new Nukleation(-1,3,4),
            new Nukleation(-1,3,6)
      };
        public Piece[] Orbits = {
            new L5(),
            new L590(),
            new L5180(),
            new L5270(),
            new L5R(),
            new L5R90(),
            new L5R180(),
            new L5R270()
      };
    }

    public class L5R : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-3,0),
            new Coord(-3,1)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,6),
            new Nukleation(0,0,4),
            new Nukleation(-3,0,2),
            new Nukleation(-3,1,0),
            new Nukleation(-3,1,6)
      };
        public Piece[] Orbits = {
            new L5(),
            new L590(),
            new L5180(),
            new L5270(),
            new L5R(),
            new L5R90(),
            new L5R180(),
            new L5R270()
      };
    }

    public class L5R90 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(0,-3),
            new Coord(-1,-3)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,0),
            new Nukleation(0,0,6),
            new Nukleation(0,-3,4),
            new Nukleation(-1,-3,2),
            new Nukleation(-1,-3,0)
      };
        public Piece[] Orbits = {
            new L5(),
            new L590(),
            new L5180(),
            new L5270(),
            new L5R(),
            new L5R90(),
            new L5R180(),
            new L5R270()
      };
    }

    public class L5R180 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(3,0),
            new Coord(3,-1)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,2),
            new Nukleation(0,0,0),
            new Nukleation(3,0,6),
            new Nukleation(3,-1,4),
            new Nukleation(3,-1,2)
      };
        public Piece[] Orbits = {
            new L5(),
            new L590(),
            new L5180(),
            new L5270(),
            new L5R(),
            new L5R90(),
            new L5R180(),
            new L5R270()
      };
    }

    public class L5R270 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(0,3),
            new Coord(1,3)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,4),
            new Nukleation(0,0,2),
            new Nukleation(0,3,0),
            new Nukleation(1,3,6),
            new Nukleation(1,3,4)
      };
        public Piece[] Orbits = {
            new L5(),
            new L590(),
            new L5180(),
            new L5270(),
            new L5R(),
            new L5R90(),
            new L5R180(),
            new L5R270()
      };
    }
}
