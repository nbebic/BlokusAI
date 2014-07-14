using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *        Any such attempts will end in a failiure.        *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class Y : Piece
    {
        public static Y instance = new Y();
        public Y()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(3,0),
            new Coord(1,1)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,2),
            new Nukleation(3,0,4),
            new Nukleation(3,0,6),
            new Nukleation(1,1,0),
            new Nukleation(1,1,6)},
                new Piece[]{
            Y.instance,
            Y90.instance,
            Y180.instance,
            Y270.instance,
            YR.instance,
            YR90.instance,
            YR180.instance,
            YR270.instance})
        { }
    }

    public class Y90 : Piece
    {
        public static Y90 instance = new Y90();
        public Y90()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(0,-3),
            new Coord(1,-1)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,4),
            new Nukleation(0,-3,6),
            new Nukleation(0,-3,0),
            new Nukleation(1,-1,2),
            new Nukleation(1,-1,0)},
                new Piece[]{
            Y.instance,
            Y90.instance,
            Y180.instance,
            Y270.instance,
            YR.instance,
            YR90.instance,
            YR180.instance,
            YR270.instance})
        { }
    }

    public class Y180 : Piece
    {
        public static Y180 instance = new Y180();
        public Y180()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-3,0),
            new Coord(-1,-1)},
                new Nukleation[]{
            new Nukleation(0,0,4),
            new Nukleation(0,0,6),
            new Nukleation(-3,0,0),
            new Nukleation(-3,0,2),
            new Nukleation(-1,-1,4),
            new Nukleation(-1,-1,2)},
                new Piece[]{
            Y.instance,
            Y90.instance,
            Y180.instance,
            Y270.instance,
            YR.instance,
            YR90.instance,
            YR180.instance,
            YR270.instance})
        { }
    }

    public class Y270 : Piece
    {
        public static Y270 instance = new Y270();
        public Y270()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(0,3),
            new Coord(-1,1)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(0,0,0),
            new Nukleation(0,3,2),
            new Nukleation(0,3,4),
            new Nukleation(-1,1,6),
            new Nukleation(-1,1,4)},
                new Piece[]{
            Y.instance,
            Y90.instance,
            Y180.instance,
            Y270.instance,
            YR.instance,
            YR90.instance,
            YR180.instance,
            YR270.instance})
        { }
    }

    public class YR : Piece
    {
        public static YR instance = new YR();
        public YR()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-3,0),
            new Coord(-1,1)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(0,0,4),
            new Nukleation(-3,0,2),
            new Nukleation(-3,0,0),
            new Nukleation(-1,1,6),
            new Nukleation(-1,1,0)},
                new Piece[]{
            Y.instance,
            Y90.instance,
            Y180.instance,
            Y270.instance,
            YR.instance,
            YR90.instance,
            YR180.instance,
            YR270.instance})
        { }
    }

    public class YR90 : Piece
    {
        public static YR90 instance = new YR90();
        public YR90()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(0,-3),
            new Coord(-1,-1)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,6),
            new Nukleation(0,-3,4),
            new Nukleation(0,-3,2),
            new Nukleation(-1,-1,0),
            new Nukleation(-1,-1,2)},
                new Piece[]{
            Y.instance,
            Y90.instance,
            Y180.instance,
            Y270.instance,
            YR.instance,
            YR90.instance,
            YR180.instance,
            YR270.instance})
        { }
    }

    public class YR180 : Piece
    {
        public static YR180 instance = new YR180();
        public YR180()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(3,0),
            new Coord(1,-1)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,0),
            new Nukleation(3,0,6),
            new Nukleation(3,0,4),
            new Nukleation(1,-1,2),
            new Nukleation(1,-1,4)},
                new Piece[]{
            Y.instance,
            Y90.instance,
            Y180.instance,
            Y270.instance,
            YR.instance,
            YR90.instance,
            YR180.instance,
            YR270.instance})
        { }
    }

    public class YR270 : Piece
    {
        public static YR270 instance = new YR270();
        public YR270()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(0,3),
            new Coord(1,1)},
                new Nukleation[]{
            new Nukleation(0,0,4),
            new Nukleation(0,0,2),
            new Nukleation(0,3,0),
            new Nukleation(0,3,6),
            new Nukleation(1,1,4),
            new Nukleation(1,1,6)},
                new Piece[]{
            Y.instance,
            Y90.instance,
            Y180.instance,
            Y270.instance,
            YR.instance,
            YR90.instance,
            YR180.instance,
            YR270.instance})
        { }
    }

}