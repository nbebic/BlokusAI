using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *        Any such attempts will end in a failiure.        *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class F : Piece
    {
        public static F instance = new F();
        public F()
            : base(new Coord[]{
            new Coord(1,0),
            new Coord(2,0),
            new Coord(0,1),
            new Coord(1,1),
            new Coord(1,2)},
                new Nukleation[]{
            new Nukleation(1,0,2),
            new Nukleation(2,0,4),
            new Nukleation(2,0,6),
            new Nukleation(0,1,0),
            new Nukleation(0,1,2),
            new Nukleation(1,2,0),
            new Nukleation(1,2,6)},
                new Piece[]{
            F.instance,
            F90.instance,
            F180.instance,
            F270.instance,
            FR.instance,
            FR90.instance,
            FR180.instance,
            FR270.instance})
        { }
    }

    public class F90 : Piece
    {
        public static F90 instance = new F90();
        public F90()
            : base(new Coord[]{
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(1,0),
            new Coord(1,-1),
            new Coord(2,-1)},
                new Nukleation[]{
            new Nukleation(0,-1,4),
            new Nukleation(0,-2,6),
            new Nukleation(0,-2,0),
            new Nukleation(1,0,2),
            new Nukleation(1,0,4),
            new Nukleation(2,-1,2),
            new Nukleation(2,-1,0)},
                new Piece[]{
            F.instance,
            F90.instance,
            F180.instance,
            F270.instance,
            FR.instance,
            FR90.instance,
            FR180.instance,
            FR270.instance})
        { }
    }

    public class F180 : Piece
    {
        public static F180 instance = new F180();
        public F180()
            : base(new Coord[]{
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(0,-1),
            new Coord(-1,-1),
            new Coord(-1,-2)},
                new Nukleation[]{
            new Nukleation(-1,0,6),
            new Nukleation(-2,0,0),
            new Nukleation(-2,0,2),
            new Nukleation(0,-1,4),
            new Nukleation(0,-1,6),
            new Nukleation(-1,-2,4),
            new Nukleation(-1,-2,2)},
                new Piece[]{
            F.instance,
            F90.instance,
            F180.instance,
            F270.instance,
            FR.instance,
            FR90.instance,
            FR180.instance,
            FR270.instance})
        { }
    }

    public class F270 : Piece
    {
        public static F270 instance = new F270();
        public F270()
            : base(new Coord[]{
            new Coord(0,1),
            new Coord(0,2),
            new Coord(-1,0),
            new Coord(-1,1),
            new Coord(-2,1)},
                new Nukleation[]{
            new Nukleation(0,1,0),
            new Nukleation(0,2,2),
            new Nukleation(0,2,4),
            new Nukleation(-1,0,6),
            new Nukleation(-1,0,0),
            new Nukleation(-2,1,6),
            new Nukleation(-2,1,4)},
                new Piece[]{
            F.instance,
            F90.instance,
            F180.instance,
            F270.instance,
            FR.instance,
            FR90.instance,
            FR180.instance,
            FR270.instance})
        { }
    }

    public class FR : Piece
    {
        public static FR instance = new FR();
        public FR()
            : base(new Coord[]{
            new Coord(-1,0),
            new Coord(-2,0),
            new Coord(0,1),
            new Coord(-1,1),
            new Coord(-1,2)},
                new Nukleation[]{
            new Nukleation(-1,0,4),
            new Nukleation(-2,0,2),
            new Nukleation(-2,0,0),
            new Nukleation(0,1,6),
            new Nukleation(0,1,4),
            new Nukleation(-1,2,6),
            new Nukleation(-1,2,0)},
                new Piece[]{
            F.instance,
            F90.instance,
            F180.instance,
            F270.instance,
            FR.instance,
            FR90.instance,
            FR180.instance,
            FR270.instance})
        { }
    }

    public class FR90 : Piece
    {
        public static FR90 instance = new FR90();
        public FR90()
            : base(new Coord[]{
            new Coord(0,-1),
            new Coord(0,-2),
            new Coord(-1,0),
            new Coord(-1,-1),
            new Coord(-2,-1)},
                new Nukleation[]{
            new Nukleation(0,-1,6),
            new Nukleation(0,-2,4),
            new Nukleation(0,-2,2),
            new Nukleation(-1,0,0),
            new Nukleation(-1,0,6),
            new Nukleation(-2,-1,0),
            new Nukleation(-2,-1,2)},
                new Piece[]{
            F.instance,
            F90.instance,
            F180.instance,
            F270.instance,
            FR.instance,
            FR90.instance,
            FR180.instance,
            FR270.instance})
        { }
    }

    public class FR180 : Piece
    {
        public static FR180 instance = new FR180();
        public FR180()
            : base(new Coord[]{
            new Coord(1,0),
            new Coord(2,0),
            new Coord(0,-1),
            new Coord(1,-1),
            new Coord(1,-2)},
                new Nukleation[]{
            new Nukleation(1,0,0),
            new Nukleation(2,0,6),
            new Nukleation(2,0,4),
            new Nukleation(0,-1,2),
            new Nukleation(0,-1,0),
            new Nukleation(1,-2,2),
            new Nukleation(1,-2,4)},
                new Piece[]{
            F.instance,
            F90.instance,
            F180.instance,
            F270.instance,
            FR.instance,
            FR90.instance,
            FR180.instance,
            FR270.instance})
        { }
    }

    public class FR270 : Piece
    {
        public static FR270 instance = new FR270();
        public FR270()
            : base(new Coord[]{
            new Coord(0,1),
            new Coord(0,2),
            new Coord(1,0),
            new Coord(1,1),
            new Coord(2,1)},
                new Nukleation[]{
            new Nukleation(0,1,2),
            new Nukleation(0,2,0),
            new Nukleation(0,2,6),
            new Nukleation(1,0,4),
            new Nukleation(1,0,2),
            new Nukleation(2,1,4),
            new Nukleation(2,1,6)},
                new Piece[]{
            F.instance,
            F90.instance,
            F180.instance,
            F270.instance,
            FR.instance,
            FR90.instance,
            FR180.instance,
            FR270.instance})
        { }
    }

}
