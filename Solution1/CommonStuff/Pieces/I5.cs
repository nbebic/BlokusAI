using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *        Any such attempts will end in a failiure.        *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class I5 : Piece
    {
        public static I5 instance = new I5();
        public I5()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(0,3),
            new Coord(0,4)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,0),
            new Nukleation(0,4,0),
            new Nukleation(0,4,0)},
                new Piece[]{
            I5.instance,
            I590.instance})
        { }
    }

    public class I590 : Piece
    {
        public static I590 instance = new I590();
        public I590()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(3,0),
            new Coord(4,0)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,2),
            new Nukleation(4,0,2),
            new Nukleation(4,0,2)},
                new Piece[]{
            I5.instance,
            I590.instance})
        { }
    }

}
