using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *        Any such attempts will end in a failiure.        *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class T4 : Piece
    {
        public static T4 instance = new T4();
        public T4()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(1,1)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,2),
            new Nukleation(2,0,4),
            new Nukleation(2,0,6),
            new Nukleation(1,1,0),
            new Nukleation(1,1,6)},
                new Piece[]{
            T4.instance,
            T490.instance,
            T4180.instance,
            T4270.instance})
        { }
    }

    public class T490 : Piece
    {
        public static T490 instance = new T490();
        public T490()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(1,-1)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,4),
            new Nukleation(0,-2,6),
            new Nukleation(0,-2,0),
            new Nukleation(1,-1,2),
            new Nukleation(1,-1,0)},
                new Piece[]{
            T4.instance,
            T490.instance,
            T4180.instance,
            T4270.instance})
        { }
    }

    public class T4180 : Piece
    {
        public static T4180 instance = new T4180();
        public T4180()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(-1,-1)},
                new Nukleation[]{
            new Nukleation(0,0,4),
            new Nukleation(0,0,6),
            new Nukleation(-2,0,0),
            new Nukleation(-2,0,2),
            new Nukleation(-1,-1,4),
            new Nukleation(-1,-1,2)},
                new Piece[]{
            T4.instance,
            T490.instance,
            T4180.instance,
            T4270.instance})
        { }
    }

    public class T4270 : Piece
    {
        public static T4270 instance = new T4270();
        public T4270()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(-1,1)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(0,0,0),
            new Nukleation(0,2,2),
            new Nukleation(0,2,4),
            new Nukleation(-1,1,6),
            new Nukleation(-1,1,4)},
                new Piece[]{
            T4.instance,
            T490.instance,
            T4180.instance,
            T4270.instance})
        { }
    }

}
