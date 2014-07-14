using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *        Any such attempts will end in a failiure.        *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class O4 : Piece
    {
        public static O4 instance = new O4();
        public O4()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(0,1),
            new Coord(1,1)},
                new Nukleation[]{
            new Nukleation(0,1,0),
            new Nukleation(0,0,2),
            new Nukleation(1,0,4),
            new Nukleation(1,1,6)},
                new Piece[]{
            O4.instance})
        { }
    }

}
