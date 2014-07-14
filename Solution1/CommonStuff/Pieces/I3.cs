using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *        Any such attempts will end in a failiure.        *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class I3 : Piece
    {
        public static I3 instance = new I3();
        public I3()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(0,2)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,0),
            new Nukleation(0,2,0),
            new Nukleation(0,2,0)},
                new Piece[]{
            I3.instance,
            I390.instance})
        { }
    }

    public class I390 : Piece
    {
        public static I390 instance = new I390();
        public I390()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(2,0)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,2),
            new Nukleation(2,0,2),
            new Nukleation(2,0,2)},
                new Piece[]{
            I3.instance,
            I390.instance})
        { }
    }

}
