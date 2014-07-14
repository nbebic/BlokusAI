using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *        Any such attempts will end in a failiure.        *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class I1 : Piece
    {
        public static I1 instance = new I1();
        public I1()
            : base(new Coord[]{
            new Coord(0,0)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,2),
            new Nukleation(0,0,4),
            new Nukleation(0,0,6)},
                new Piece[]{
            I1.instance})
        { }
    }

}
