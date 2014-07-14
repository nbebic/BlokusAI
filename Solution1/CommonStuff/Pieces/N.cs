using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *       Any such attempts will end in a failiure.         *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class N : Piece
    {
        public static N instance = new N();
        public N()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(2,1),
            new Coord(3,1)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,2),
            new Nukleation(2,0,4),
            new Nukleation(2,1,6),
            new Nukleation(3,1,4),
            new Nukleation(3,1,6)},
                new Piece[]{
            N.instance,
            N90.instance,
            N180.instance,
            N270.instance,
            NR.instance,
            NR90.instance,
            NR180.instance,
            NR270.instance})
        { }
    }

    public class N90 : Piece
    {
        public static N90 instance = new N90();
        public N90()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(1,-2),
            new Coord(1,-3)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,4),
            new Nukleation(0,-2,6),
            new Nukleation(1,-2,0),
            new Nukleation(1,-3,6),
            new Nukleation(1,-3,0)},
                new Piece[]{
            N.instance,
            N90.instance,
            N180.instance,
            N270.instance,
            NR.instance,
            NR90.instance,
            NR180.instance,
            NR270.instance})
        { }
    }

    public class N180 : Piece
    {
        public static N180 instance = new N180();
        public N180()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-2,-1),
            new Coord(-3,-1)},
                new Nukleation[]{
            new Nukleation(0,0,4),
            new Nukleation(0,0,6),
            new Nukleation(-2,0,0),
            new Nukleation(-2,-1,2),
            new Nukleation(-3,-1,0),
            new Nukleation(-3,-1,2)},
                new Piece[]{
            N.instance,
            N90.instance,
            N180.instance,
            N270.instance,
            NR.instance,
            NR90.instance,
            NR180.instance,
            NR270.instance})
        { }
    }

    public class N270 : Piece
    {
        public static N270 instance = new N270();
        public N270()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(-1,2),
            new Coord(-1,3)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(0,0,0),
            new Nukleation(0,2,2),
            new Nukleation(-1,2,4),
            new Nukleation(-1,3,2),
            new Nukleation(-1,3,4)},
                new Piece[]{
            N.instance,
            N90.instance,
            N180.instance,
            N270.instance,
            NR.instance,
            NR90.instance,
            NR180.instance,
            NR270.instance})
        { }
    }

    public class NR : Piece
    {
        public static NR instance = new NR();
        public NR()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-2,1),
            new Coord(-3,1)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(0,0,4),
            new Nukleation(-2,0,2),
            new Nukleation(-2,1,0),
            new Nukleation(-3,1,2),
            new Nukleation(-3,1,0)},
                new Piece[]{
            N.instance,
            N90.instance,
            N180.instance,
            N270.instance,
            NR.instance,
            NR90.instance,
            NR180.instance,
            NR270.instance})
        { }
    }

    public class NR90 : Piece
    {
        public static NR90 instance = new NR90();
        public NR90()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(-1,-2),
            new Coord(-1,-3)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,6),
            new Nukleation(0,-2,4),
            new Nukleation(-1,-2,2),
            new Nukleation(-1,-3,4),
            new Nukleation(-1,-3,2)},
                new Piece[]{
            N.instance,
            N90.instance,
            N180.instance,
            N270.instance,
            NR.instance,
            NR90.instance,
            NR180.instance,
            NR270.instance})
        { }
    }

    public class NR180 : Piece
    {
        public static NR180 instance = new NR180();
        public NR180()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(2,-1),
            new Coord(3,-1)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,0),
            new Nukleation(2,0,6),
            new Nukleation(2,-1,4),
            new Nukleation(3,-1,6),
            new Nukleation(3,-1,4)},
                new Piece[]{
            N.instance,
            N90.instance,
            N180.instance,
            N270.instance,
            NR.instance,
            NR90.instance,
            NR180.instance,
            NR270.instance})
        { }
    }

    public class NR270 : Piece
    {
        public static NR270 instance = new NR270();
        public NR270()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(1,2),
            new Coord(1,3)},
                new Nukleation[]{
            new Nukleation(0,0,4),
            new Nukleation(0,0,2),
            new Nukleation(0,2,0),
            new Nukleation(1,2,6),
            new Nukleation(1,3,0),
            new Nukleation(1,3,6)},
                new Piece[]{
            N.instance,
            N90.instance,
            N180.instance,
            N270.instance,
            NR.instance,
            NR90.instance,
            NR180.instance,
            NR270.instance})
        { }
    }

}