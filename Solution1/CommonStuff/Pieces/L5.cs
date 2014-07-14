using System;
using System.Linq;
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticly.  *
 * Do not try to manualy modify or understand it.          *
 * Any such attempts will end in a failiure.               *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
namespace BlokusAI.CommonStuff.Pieces
{
    public class L5 : Piece
    {
        public static L5 instance = new L5();
        public L5()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(3,0),
            new Coord(3,1)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,2),
            new Nukleation(3,0,4),
            new Nukleation(3,1,6),
            new Nukleation(3,1,0)},
                new Piece[]{
            L5.instance,
            L590.instance,
            L5180.instance,
            L5270.instance,
            L5R.instance,
            L5R90.instance,
            L5R180.instance,
            L5R270.instance})
        { }
    }

    public class L590 : Piece
    {
        public static L590 instance = new L590();
        public L590()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(0,-3),
            new Coord(1,-3)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,4),
            new Nukleation(0,-3,6),
            new Nukleation(1,-3,0),
            new Nukleation(1,-3,2)},
                new Piece[]{
            L5.instance,
            L590.instance,
            L5180.instance,
            L5270.instance,
            L5R.instance,
            L5R90.instance,
            L5R180.instance,
            L5R270.instance})
        { }
    }

    public class L5180 : Piece
    {
        public static L5180 instance = new L5180();
        public L5180()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-3,0),
            new Coord(-3,-1)},
                new Nukleation[]{
            new Nukleation(0,0,4),
            new Nukleation(0,0,6),
            new Nukleation(-3,0,0),
            new Nukleation(-3,-1,2),
            new Nukleation(-3,-1,4)},
                new Piece[]{
            L5.instance,
            L590.instance,
            L5180.instance,
            L5270.instance,
            L5R.instance,
            L5R90.instance,
            L5R180.instance,
            L5R270.instance})
        { }
    }

    public class L5270 : Piece
    {
        public static L5270 instance = new L5270();
        public L5270()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(0,3),
            new Coord(-1,3)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(0,0,0),
            new Nukleation(0,3,2),
            new Nukleation(-1,3,4),
            new Nukleation(-1,3,6)},
                new Piece[]{
            L5.instance,
            L590.instance,
            L5180.instance,
            L5270.instance,
            L5R.instance,
            L5R90.instance,
            L5R180.instance,
            L5R270.instance})
        { }
    }

    public class L5R : Piece
    {
        public static L5R instance = new L5R();
        public L5R()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-3,0),
            new Coord(-3,1)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(0,0,4),
            new Nukleation(-3,0,2),
            new Nukleation(-3,1,0),
            new Nukleation(-3,1,6)},
                new Piece[]{
            L5.instance,
            L590.instance,
            L5180.instance,
            L5270.instance,
            L5R.instance,
            L5R90.instance,
            L5R180.instance,
            L5R270.instance})
        { }
    }

    public class L5R90 : Piece
    {
        public static L5R90 instance = new L5R90();
        public L5R90()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(0,-3),
            new Coord(-1,-3)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,6),
            new Nukleation(0,-3,4),
            new Nukleation(-1,-3,2),
            new Nukleation(-1,-3,0)},
                new Piece[]{
            L5.instance,
            L590.instance,
            L5180.instance,
            L5270.instance,
            L5R.instance,
            L5R90.instance,
            L5R180.instance,
            L5R270.instance})
        { }
    }

    public class L5R180 : Piece
    {
        public static L5R180 instance = new L5R180();
        public L5R180()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(3,0),
            new Coord(3,-1)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,0),
            new Nukleation(3,0,6),
            new Nukleation(3,-1,4),
            new Nukleation(3,-1,2)},
                new Piece[]{
            L5.instance,
            L590.instance,
            L5180.instance,
            L5270.instance,
            L5R.instance,
            L5R90.instance,
            L5R180.instance,
            L5R270.instance})
        { }
    }

    public class L5R270 : Piece
    {
        public static L5R270 instance = new L5R270();
        public L5R270()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(0,3),
            new Coord(1,3)},
                new Nukleation[]{
            new Nukleation(0,0,4),
            new Nukleation(0,0,2),
            new Nukleation(0,3,0),
            new Nukleation(1,3,6),
            new Nukleation(1,3,4)},
                new Piece[]{
            L5.instance,
            L590.instance,
            L5180.instance,
            L5270.instance,
            L5R.instance,
            L5R90.instance,
            L5R180.instance,
            L5R270.instance})
        { }
    }

}