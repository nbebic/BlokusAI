using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *        Any such attempts will end in a failiure.        *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class Z4 : Piece
    {
        public static Z4 instance = new Z4();
        public Z4()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(1,1),
            new Coord(2,1)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,2),
            new Nukleation(1,0,4),
            new Nukleation(1,1,0),
            new Nukleation(2,1,4),
            new Nukleation(2,1,6)},
                new Piece[]{
            Z4.instance,
            Z490.instance,
            Z4R.instance,
            Z4R90.instance})
        { }
    }

    public class Z490 : Piece
    {
        public static Z490 instance = new Z490();
        public Z490()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(1,-1),
            new Coord(1,-2)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,4),
            new Nukleation(0,-1,6),
            new Nukleation(1,-1,2),
            new Nukleation(1,-2,6),
            new Nukleation(1,-2,0)},
                new Piece[]{
            Z4.instance,
            Z490.instance,
            Z4R.instance,
            Z4R90.instance})
        { }
    }

    public class Z4R : Piece
    {
        public static Z4R instance = new Z4R();
        public Z4R()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-1,1),
            new Coord(-2,1)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(0,0,4),
            new Nukleation(-1,0,2),
            new Nukleation(-1,1,6),
            new Nukleation(-2,1,2),
            new Nukleation(-2,1,0)},
                new Piece[]{
            Z4.instance,
            Z490.instance,
            Z4R.instance,
            Z4R90.instance})
        { }
    }

    public class Z4R90 : Piece
    {
        public static Z4R90 instance = new Z4R90();
        public Z4R90()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(-1,-1),
            new Coord(-1,-2)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,6),
            new Nukleation(0,-1,4),
            new Nukleation(-1,-1,0),
            new Nukleation(-1,-2,4),
            new Nukleation(-1,-2,2)},
                new Piece[]{
            Z4.instance,
            Z490.instance,
            Z4R.instance,
            Z4R90.instance})
        { }
    }

}
