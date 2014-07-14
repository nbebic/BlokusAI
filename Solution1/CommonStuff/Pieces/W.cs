using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *        Any such attempts will end in a failiure.        *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class W : Piece
    {
        public static W instance = new W();
        public W()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(1,1),
            new Coord(1,2),
            new Coord(2,2)},
                new Nukleation[]{
            new Nukleation(0,0,4),
            new Nukleation(0,1,0),
            new Nukleation(1,1,4),
            new Nukleation(1,2,0),
            new Nukleation(2,2,4),
            new Nukleation(2,2,6),
            new Nukleation(0,0,2)},
                new Piece[]{
            W.instance,
            W90.instance,
            W180.instance,
            W270.instance})
        { }
    }

    public class W90 : Piece
    {
        public static W90 instance = new W90();
        public W90()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(1,-1),
            new Coord(2,-1),
            new Coord(2,-2)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(1,0,2),
            new Nukleation(1,-1,6),
            new Nukleation(2,-1,2),
            new Nukleation(2,-2,6),
            new Nukleation(2,-2,0),
            new Nukleation(0,0,4)},
                new Piece[]{
            W.instance,
            W90.instance,
            W180.instance,
            W270.instance})
        { }
    }

    public class W180 : Piece
    {
        public static W180 instance = new W180();
        public W180()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(-1,-1),
            new Coord(-1,-2),
            new Coord(-2,-2)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,-1,4),
            new Nukleation(-1,-1,0),
            new Nukleation(-1,-2,4),
            new Nukleation(-2,-2,0),
            new Nukleation(-2,-2,2),
            new Nukleation(0,0,6)},
                new Piece[]{
            W.instance,
            W90.instance,
            W180.instance,
            W270.instance})
        { }
    }

    public class W270 : Piece
    {
        public static W270 instance = new W270();
        public W270()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-1,1),
            new Coord(-2,1),
            new Coord(-2,2)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(-1,0,6),
            new Nukleation(-1,1,2),
            new Nukleation(-2,1,6),
            new Nukleation(-2,2,2),
            new Nukleation(-2,2,4),
            new Nukleation(0,0,0)},
                new Piece[]{
            W.instance,
            W90.instance,
            W180.instance,
            W270.instance})
        { }
    }

}
