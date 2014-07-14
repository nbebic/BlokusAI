using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *        Any such attempts will end in a failiure.        *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class L4 : Piece
    {
        public static L4 instance = new L4();
        public L4()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(2,1)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,2),
            new Nukleation(2,0,4),
            new Nukleation(2,1,0),
            new Nukleation(2,1,6)},
                new Piece[]{
            L4.instance,
            L490.instance,
            L4180.instance,
            L4270.instance,
            L4R.instance,
            L4R90.instance,
            L4R180.instance,
            L4R270.instance})
        { }
    }

    public class L490 : Piece
    {
        public static L490 instance = new L490();
        public L490()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(1,-2)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,4),
            new Nukleation(0,-2,6),
            new Nukleation(1,-2,2),
            new Nukleation(1,-2,0)},
                new Piece[]{
            L4.instance,
            L490.instance,
            L4180.instance,
            L4270.instance,
            L4R.instance,
            L4R90.instance,
            L4R180.instance,
            L4R270.instance})
        { }
    }

    public class L4180 : Piece
    {
        public static L4180 instance = new L4180();
        public L4180()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-2,-1)},
                new Nukleation[]{
            new Nukleation(0,0,4),
            new Nukleation(0,0,6),
            new Nukleation(-2,0,0),
            new Nukleation(-2,-1,4),
            new Nukleation(-2,-1,2)},
                new Piece[]{
            L4.instance,
            L490.instance,
            L4180.instance,
            L4270.instance,
            L4R.instance,
            L4R90.instance,
            L4R180.instance,
            L4R270.instance})
        { }
    }

    public class L4270 : Piece
    {
        public static L4270 instance = new L4270();
        public L4270()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(-1,2)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(0,0,0),
            new Nukleation(0,2,2),
            new Nukleation(-1,2,6),
            new Nukleation(-1,2,4)},
                new Piece[]{
            L4.instance,
            L490.instance,
            L4180.instance,
            L4270.instance,
            L4R.instance,
            L4R90.instance,
            L4R180.instance,
            L4R270.instance})
        { }
    }

    public class L4R : Piece
    {
        public static L4R instance = new L4R();
        public L4R()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-2,1)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(0,0,4),
            new Nukleation(-2,0,2),
            new Nukleation(-2,1,6),
            new Nukleation(-2,1,0)},
                new Piece[]{
            L4.instance,
            L490.instance,
            L4180.instance,
            L4270.instance,
            L4R.instance,
            L4R90.instance,
            L4R180.instance,
            L4R270.instance})
        { }
    }

    public class L4R90 : Piece
    {
        public static L4R90 instance = new L4R90();
        public L4R90()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(-1,-2)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,6),
            new Nukleation(0,-2,4),
            new Nukleation(-1,-2,0),
            new Nukleation(-1,-2,2)},
                new Piece[]{
            L4.instance,
            L490.instance,
            L4180.instance,
            L4270.instance,
            L4R.instance,
            L4R90.instance,
            L4R180.instance,
            L4R270.instance})
        { }
    }

    public class L4R180 : Piece
    {
        public static L4R180 instance = new L4R180();
        public L4R180()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(2,-1)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,0),
            new Nukleation(2,0,6),
            new Nukleation(2,-1,2),
            new Nukleation(2,-1,4)},
                new Piece[]{
            L4.instance,
            L490.instance,
            L4180.instance,
            L4270.instance,
            L4R.instance,
            L4R90.instance,
            L4R180.instance,
            L4R270.instance})
        { }
    }

    public class L4R270 : Piece
    {
        public static L4R270 instance = new L4R270();
        public L4R270()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(1,2)},
                new Nukleation[]{
            new Nukleation(0,0,4),
            new Nukleation(0,0,2),
            new Nukleation(0,2,0),
            new Nukleation(1,2,4),
            new Nukleation(1,2,6)},
                new Piece[]{
            L4.instance,
            L490.instance,
            L4180.instance,
            L4270.instance,
            L4R.instance,
            L4R90.instance,
            L4R180.instance,
            L4R270.instance})
        { }
    }

}
