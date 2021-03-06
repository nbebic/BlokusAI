﻿using System;
using System.Linq;

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * The following batch of code was generated automaticaly. *
 *     Do not try to manualy modify or understand it.      *
 *        Any such attempts will end in a failiure.        *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace BlokusAI.CommonStuff.Pieces
{
    public class X : Piece
    {
        public static X instance = new X();
        public X()
            : base(new Coord[]{
            new Coord(1,0),
            new Coord(0,1),
            new Coord(1,1),
            new Coord(2,1),
            new Coord(1,2)},
                new Nukleation[]{
            new Nukleation(1,0,2),
            new Nukleation(1,0,4),
            new Nukleation(2,1,4),
            new Nukleation(2,1,6),
            new Nukleation(1,2,6),
            new Nukleation(1,2,0),
            new Nukleation(0,1,0),
            new Nukleation(0,1,2)},
                new Piece[]{
            X.instance})
        { }
    }

}
