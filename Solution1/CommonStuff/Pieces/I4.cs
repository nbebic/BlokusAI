using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *        Any such attempts will end in a failiure.        *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class I4 : Piece
    {
        public static I4 instance = new I4();
        public I4()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2),
            new Coord(0,3)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,0),
            new Nukleation(0,3,0),
            new Nukleation(0,3,0)},
                new Piece[]{
            I4.instance,
            I490.instance})
        { }
    }

    public class I490 : Piece
    {
        public static I490 instance = new I490();
        public I490()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0),
            new Coord(3,0)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,2),
            new Nukleation(3,0,2),
            new Nukleation(3,0,2)},
                new Piece[]{
            I4.instance,
            I490.instance})
        { }
    }

}
