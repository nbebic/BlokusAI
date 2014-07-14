using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *        Any such attempts will end in a failiure.        *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class Z5 : Piece
    {
        public static Z5 instance = new Z5();
        public Z5()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(1,1),
            new Coord(1,2),
            new Coord(2,2)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,2),
            new Nukleation(1,0,4),
            new Nukleation(1,2,0),
            new Nukleation(2,2,4),
            new Nukleation(2,2,6)},
                new Piece[]{
            Z5.instance,
            Z590.instance,
            Z5R.instance,
            Z5R90.instance})
        { }
    }

    public class Z590 : Piece
    {
        public static Z590 instance = new Z590();
        public Z590()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(1,-1),
            new Coord(2,-1),
            new Coord(2,-2)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,4),
            new Nukleation(0,-1,6),
            new Nukleation(2,-1,2),
            new Nukleation(2,-2,6),
            new Nukleation(2,-2,0)},
                new Piece[]{
            Z5.instance,
            Z590.instance,
            Z5R.instance,
            Z5R90.instance})
        { }
    }

    public class Z5R : Piece
    {
        public static Z5R instance = new Z5R();
        public Z5R()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-1,1),
            new Coord(-1,2),
            new Coord(-2,2)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(0,0,4),
            new Nukleation(-1,0,2),
            new Nukleation(-1,2,6),
            new Nukleation(-2,2,2),
            new Nukleation(-2,2,0)},
                new Piece[]{
            Z5.instance,
            Z590.instance,
            Z5R.instance,
            Z5R90.instance})
        { }
    }

    public class Z5R90 : Piece
    {
        public static Z5R90 instance = new Z5R90();
        public Z5R90()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(-1,-1),
            new Coord(-2,-1),
            new Coord(-2,-2)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,6),
            new Nukleation(0,-1,4),
            new Nukleation(-2,-1,0),
            new Nukleation(-2,-2,4),
            new Nukleation(-2,-2,2)},
                new Piece[]{
            Z5.instance,
            Z590.instance,
            Z5R.instance,
            Z5R90.instance})
        { }
    }

}
