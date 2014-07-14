using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *        Any such attempts will end in a failiure.        *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class I2 : Piece
    {
        public static I2 instance = new I2();
        public I2()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,0),
            new Nukleation(0,1,0),
            new Nukleation(0,1,0)},
                new Piece[]{
            I2.instance,
            I290.instance})
        { }
    }

    public class I290 : Piece
    {
        public static I290 instance = new I290();
        public I290()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,2),
            new Nukleation(1,0,2),
            new Nukleation(1,0,2)},
                new Piece[]{
            I2.instance,
            I290.instance})
        { }
    }

}
