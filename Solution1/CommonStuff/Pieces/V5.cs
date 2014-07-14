using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *        Any such attempts will end in a failiure.        *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class V5 : Piece
    {
        public static V5 instance = new V5();
        public V5()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(1,2),
            new Coord(2,2)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,4),
            new Nukleation(0,2,0),
            new Nukleation(2,2,4),
            new Nukleation(2,2,6)},
                new Piece[]{
            V5.instance,
            V590.instance,
            V5180.instance,
            V5270.instance})
        { }
    }

    public class V590 : Piece
    {
        public static V590 instance = new V590();
        public V590()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(2,-1),
            new Coord(2,-2)},
                new Nukleation[]{
            new Nukleation(0,0,4),
            new Nukleation(0,0,6),
            new Nukleation(2,0,2),
            new Nukleation(2,-2,6),
            new Nukleation(2,-2,0)},
                new Piece[]{
            V5.instance,
            V590.instance,
            V5180.instance,
            V5270.instance})
        { }
    }

    public class V5180 : Piece
    {
        public static V5180 instance = new V5180();
        public V5180()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(-1,-2),
            new Coord(-2,-2)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(0,0,0),
            new Nukleation(0,-2,4),
            new Nukleation(-2,-2,0),
            new Nukleation(-2,-2,2)},
                new Piece[]{
            V5.instance,
            V590.instance,
            V5180.instance,
            V5270.instance})
        { }
    }

    public class V5270 : Piece
    {
        public static V5270 instance = new V5270();
        public V5270()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-2,1),
            new Coord(-2,2)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,2),
            new Nukleation(-2,0,6),
            new Nukleation(-2,2,2),
            new Nukleation(-2,2,4)},
                new Piece[]{
            V5.instance,
            V590.instance,
            V5180.instance,
            V5270.instance})
        { }
    }

}
