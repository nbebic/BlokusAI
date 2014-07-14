using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *       Any such attempts will end in a failiure.         *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class V3 : Piece
    {
        public static V3 instance = new V3();
        public V3()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,1),
            new Coord(1,1)},
                new Nukleation[]{
            new Nukleation(0,0,2),
            new Nukleation(0,0,4),
            new Nukleation(0,1,0),
            new Nukleation(1,1,4),
            new Nukleation(1,1,6)},
                new Piece[]{
            V3.instance,
            V390.instance,
            V3180.instance,
            V3270.instance})
        { }
    }

    public class V390 : Piece
    {
        public static V390 instance = new V390();
        public V390()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(1,0),
            new Coord(1,-1)},
                new Nukleation[]{
            new Nukleation(0,0,4),
            new Nukleation(0,0,6),
            new Nukleation(1,0,2),
            new Nukleation(1,-1,6),
            new Nukleation(1,-1,0)},
                new Piece[]{
            V3.instance,
            V390.instance,
            V3180.instance,
            V3270.instance})
        { }
    }

    public class V3180 : Piece
    {
        public static V3180 instance = new V3180();
        public V3180()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(0,-1),
            new Coord(-1,-1)},
                new Nukleation[]{
            new Nukleation(0,0,6),
            new Nukleation(0,0,0),
            new Nukleation(0,-1,4),
            new Nukleation(-1,-1,0),
            new Nukleation(-1,-1,2)},
                new Piece[]{
            V3.instance,
            V390.instance,
            V3180.instance,
            V3270.instance})
        { }
    }

    public class V3270 : Piece
    {
        public static V3270 instance = new V3270();
        public V3270()
            : base(new Coord[]{
            new Coord(0,0),
            new Coord(-1,0),
            new Coord(-1,1)},
                new Nukleation[]{
            new Nukleation(0,0,0),
            new Nukleation(0,0,2),
            new Nukleation(-1,0,6),
            new Nukleation(-1,1,2),
            new Nukleation(-1,1,4)},
                new Piece[]{
            V3.instance,
            V390.instance,
            V3180.instance,
            V3270.instance})
        { }
    }

}
