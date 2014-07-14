using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *       Any such attempts will end in a failiure.         *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class U : Piece
    {
        public static U instance = new U();
        public U()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(1,2)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(1,0,4),
            new Nukleation(1,0,6),
            new Nukleation(0,2,0),
            new Nukleation(1,2,4),
            new Nukleation(1,2,6)},
                new Piece[]{
            U.instance,
            U90.instance,
            U180.instance,
            U270.instance})
        { }
    }

    public class U90 : Piece
    {
        public static U90 instance = new U90();
        public U90()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(2,-1)},
                new Nukleation[]{
            new Nukleation(0,0,4),
            new Nukleation(0,-1,6),
            new Nukleation(0,-1,0),
            new Nukleation(2,0,2),
            new Nukleation(2,-1,6),
            new Nukleation(2,-1,0)},
                new Piece[]{
            U.instance,
            U90.instance,
            U180.instance,
            U270.instance})
        { }
    }

    public class U180 : Piece
    {
        public static U180 instance = new U180();
        public U180()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(-1,-2)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(-1,0,0),
            new Nukleation(-1,0,2),
            new Nukleation(0,-2,4),
            new Nukleation(-1,-2,0),
            new Nukleation(-1,-2,2)},
                new Piece[]{
            U.instance,
            U90.instance,
            U180.instance,
            U270.instance})
        { }
    }

    public class U270 : Piece
    {
        public static U270 instance = new U270();
        public U270()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-2,1)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,1,2),
            new Nukleation(0,1,4),
            new Nukleation(-2,0,6),
            new Nukleation(-2,1,2),
            new Nukleation(-2,1,4)},
                new Piece[]{
            U.instance,
            U90.instance,
            U180.instance,
            U270.instance})
        { }
    }

}
