using System;
using System.Linq;

namespace BlokusAI.CommonStuff.Pieces
{
    public class Y : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(1,0),
            new Coord(1,1),
            new Coord(2,0),
            new Coord(3,0)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,0),
            new Nukleation(0,0,2),
            new Nukleation(3,0,4),
            new Nukleation(3,0,6),
            new Nukleation(1,1,0),
            new Nukleation(1,1,6)
      };
        public Piece[] Orbits = {
            new Y(),
            new Y90(),
            new Y180(),
            new Y270(),
            new YR(),
            new YR90(),
            new YR180(),
            new YR270()
      };
    }

    public class Y90 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(1,-1),
            new Coord(0,-2),
            new Coord(0,-3)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,2),
            new Nukleation(0,0,4),
            new Nukleation(0,-3,6),
            new Nukleation(0,-3,0),
            new Nukleation(1,-1,2),
            new Nukleation(1,-1,0)
      };
        public Piece[] Orbits = {
            new Y(),
            new Y90(),
            new Y180(),
            new Y270(),
            new YR(),
            new YR90(),
            new YR180(),
            new YR270()
      };
    }

    public class Y180 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-1,-1),
            new Coord(-2,0),
            new Coord(-3,0)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,4),
            new Nukleation(0,0,6),
            new Nukleation(-3,0,0),
            new Nukleation(-3,0,2),
            new Nukleation(-1,-1,4),
            new Nukleation(-1,-1,2)
      };
        public Piece[] Orbits = {
            new Y(),
            new Y90(),
            new Y180(),
            new Y270(),
            new YR(),
            new YR90(),
            new YR180(),
            new YR270()
      };
    }

    public class Y270 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,1),
            new Coord(-1,1),
            new Coord(0,2),
            new Coord(0,3)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,6),
            new Nukleation(0,0,0),
            new Nukleation(0,3,2),
            new Nukleation(0,3,4),
            new Nukleation(-1,1,6),
            new Nukleation(-1,1,4)
      };
        public Piece[] Orbits = {
            new Y(),
            new Y90(),
            new Y180(),
            new Y270(),
            new YR(),
            new YR90(),
            new YR180(),
            new YR270()
      };
    }

    public class YR : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-1,1),
            new Coord(-2,0),
            new Coord(-3,0)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,6),
            new Nukleation(0,0,4),
            new Nukleation(-3,0,2),
            new Nukleation(-3,0,0),
            new Nukleation(-1,1,6),
            new Nukleation(-1,1,0)
      };
        public Piece[] Orbits = {
            new Y(),
            new Y90(),
            new Y180(),
            new Y270(),
            new YR(),
            new YR90(),
            new YR180(),
            new YR270()
      };
    }

    public class YR90 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(-1,-1),
            new Coord(0,-2),
            new Coord(0,-3)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,0),
            new Nukleation(0,0,6),
            new Nukleation(0,-3,4),
            new Nukleation(0,-3,2),
            new Nukleation(-1,-1,0),
            new Nukleation(-1,-1,2)
      };
        public Piece[] Orbits = {
            new Y(),
            new Y90(),
            new Y180(),
            new Y270(),
            new YR(),
            new YR90(),
            new YR180(),
            new YR270()
      };
    }

    public class YR180 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(1,0),
            new Coord(1,-1),
            new Coord(2,0),
            new Coord(3,0)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,2),
            new Nukleation(0,0,0),
            new Nukleation(3,0,6),
            new Nukleation(3,0,4),
            new Nukleation(1,-1,2),
            new Nukleation(1,-1,4)
      };
        public Piece[] Orbits = {
            new Y(),
            new Y90(),
            new Y180(),
            new Y270(),
            new YR(),
            new YR90(),
            new YR180(),
            new YR270()
      };
    }

    public class YR270 : Piece
    {
        public Coord[] D = {
            new Coord(0,0),
            new Coord(0,1),
            new Coord(1,1),
            new Coord(0,2),
            new Coord(0,3)
      };
        public Nukleation[] Nukleations = {
            new Nukleation(0,0,4),
            new Nukleation(0,0,2),
            new Nukleation(0,3,0),
            new Nukleation(0,3,6),
            new Nukleation(1,1,4),
            new Nukleation(1,1,6)
      };
        public Piece[] Orbits = {
            new Y(),
            new Y90(),
            new Y180(),
            new Y270(),
            new YR(),
            new YR90(),
            new YR180(),
            new YR270()
      };
    }

}
