using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *        Any such attempts will end in a failiure.        *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class T5 : Piece
    {
        public static T5 instance = new T5();
        public T5()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(1,1),
            new Coord(1,2)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,2),
            new Nukleation(2,0,4),
            new Nukleation(2,0,6),
            new Nukleation(1,2,0),
            new Nukleation(1,2,6)},
                new Piece[]{
            T5.instance,
            T590.instance,
            T5180.instance,
            T5270.instance})
        { }
    }

    public class T590 : Piece
    {
        public static T590 instance = new T590();
        public T590()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(1,-1),
            new Coord(2,-1)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,4),
            new Nukleation(0,-2,6),
            new Nukleation(0,-2,0),
            new Nukleation(2,-1,2),
            new Nukleation(2,-1,0)},
                new Piece[]{
            T5.instance,
            T590.instance,
            T5180.instance,
            T5270.instance})
        { }
    }

    public class T5180 : Piece
    {
        public static T5180 instance = new T5180();
        public T5180()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-1,-1),
            new Coord(-1,-2)},
                new Nukleation[]{
            new Nukleation(0,0,4),
            new Nukleation(0,0,6),
            new Nukleation(-2,0,0),
            new Nukleation(-2,0,2),
            new Nukleation(-1,-2,4),
            new Nukleation(-1,-2,2)},
                new Piece[]{
            T5.instance,
            T590.instance,
            T5180.instance,
            T5270.instance})
        { }
    }

    public class T5270 : Piece
    {
        public static T5270 instance = new T5270();
        public T5270()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(-1,1),
            new Coord(-2,1)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(0,0,0),
            new Nukleation(0,2,2),
            new Nukleation(0,2,4),
            new Nukleation(-2,1,6),
            new Nukleation(-2,1,4)},
                new Piece[]{
            T5.instance,
            T590.instance,
            T5180.instance,
            T5270.instance})
        { }
    }

}
