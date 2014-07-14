using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *        Any such attempts will end in a failiure.        *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class P : Piece
    {
        public static P instance = new P();
        public P()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(0,1),
            new Coord(1,1),
            new Coord(0,2)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(1,0,4),
            new Nukleation(1,1,6),
            new Nukleation(0,2,0),
            new Nukleation(0,2,6)},
                new Piece[]{
            P.instance,
            P90.instance,
            P180.instance,
            P270.instance,
            PR.instance,
            PR90.instance,
            PR180.instance,
            PR270.instance})
        { }
    }

    public class P90 : Piece
    {
        public static P90 instance = new P90();
        public P90()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(1,0),
            new Coord(1,-1),
            new Coord(2,0)},
                new Nukleation[]{
            new Nukleation(0,0,4),
            new Nukleation(0,-1,6),
            new Nukleation(1,-1,0),
            new Nukleation(2,0,2),
            new Nukleation(2,0,0)},
                new Piece[]{
            P.instance,
            P90.instance,
            P180.instance,
            P270.instance,
            PR.instance,
            PR90.instance,
            PR180.instance,
            PR270.instance})
        { }
    }

    public class P180 : Piece
    {
        public static P180 instance = new P180();
        public P180()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(0,-1),
            new Coord(-1,-1),
            new Coord(0,-2)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(-1,0,0),
            new Nukleation(-1,-1,2),
            new Nukleation(0,-2,4),
            new Nukleation(0,-2,2)},
                new Piece[]{
            P.instance,
            P90.instance,
            P180.instance,
            P270.instance,
            PR.instance,
            PR90.instance,
            PR180.instance,
            PR270.instance})
        { }
    }

    public class P270 : Piece
    {
        public static P270 instance = new P270();
        public P270()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(-1,0),
            new Coord(-1,1),
            new Coord(-2,0)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,1,2),
            new Nukleation(-1,1,4),
            new Nukleation(-2,0,6),
            new Nukleation(-2,0,4)},
                new Piece[]{
            P.instance,
            P90.instance,
            P180.instance,
            P270.instance,
            PR.instance,
            PR90.instance,
            PR180.instance,
            PR270.instance})
        { }
    }

    public class PR : Piece
    {
        public static PR instance = new PR();
        public PR()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(0,1),
            new Coord(-1,1),
            new Coord(0,2)},
                new Nukleation[]{
            new Nukleation(0,0,4),
            new Nukleation(-1,0,2),
            new Nukleation(-1,1,0),
            new Nukleation(0,2,6),
            new Nukleation(0,2,0)},
                new Piece[]{
            P.instance,
            P90.instance,
            P180.instance,
            P270.instance,
            PR.instance,
            PR90.instance,
            PR180.instance,
            PR270.instance})
        { }
    }

    public class PR90 : Piece
    {
        public static PR90 instance = new PR90();
        public PR90()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(-1,0),
            new Coord(-1,-1),
            new Coord(-2,0)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(0,-1,4),
            new Nukleation(-1,-1,2),
            new Nukleation(-2,0,0),
            new Nukleation(-2,0,2)},
                new Piece[]{
            P.instance,
            P90.instance,
            P180.instance,
            P270.instance,
            PR.instance,
            PR90.instance,
            PR180.instance,
            PR270.instance})
        { }
    }

    public class PR180 : Piece
    {
        public static PR180 instance = new PR180();
        public PR180()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(0,-1),
            new Coord(1,-1),
            new Coord(0,-2)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(1,0,6),
            new Nukleation(1,-1,4),
            new Nukleation(0,-2,2),
            new Nukleation(0,-2,4)},
                new Piece[]{
            P.instance,
            P90.instance,
            P180.instance,
            P270.instance,
            PR.instance,
            PR90.instance,
            PR180.instance,
            PR270.instance})
        { }
    }

    public class PR270 : Piece
    {
        public static PR270 instance = new PR270();
        public PR270()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(1,0),
            new Coord(1,1),
            new Coord(2,0)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,1,0),
            new Nukleation(1,1,6),
            new Nukleation(2,0,4),
            new Nukleation(2,0,6)},
                new Piece[]{
            P.instance,
            P90.instance,
            P180.instance,
            P270.instance,
            PR.instance,
            PR90.instance,
            PR180.instance,
            PR270.instance})
        { }
    }

}
