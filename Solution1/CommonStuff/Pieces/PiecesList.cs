using System;
using System.Collections.Generic;
using System.Linq;

namespace BlokusAI.CommonStuff.Pieces
{
    public partial class Piece
    {

        public static Piece l5 = L5.instance; 
        public static Piece y  =  Y.instance;
        public static Piece n  =  N.instance;
        public static Piece v3 = V3.instance;
        public static Piece u  =  U.instance;
        public static Piece v5 = V5.instance;
        public static Piece z5 = Z5.instance;
        public static Piece x  =  X.instance;
        public static Piece t5 = T5.instance;
        public static Piece w  =  W.instance;
        public static Piece p  =  P.instance;
        public static Piece f  =  F.instance;
        public static Piece o4 = O4.instance;
        public static Piece l4 = L4.instance;
        public static Piece t4 = T4.instance;
        public static Piece z4 = Z4.instance;
        public static Piece i1 = I1.instance;
        public static Piece i2 = I2.instance;
        public static Piece i3 = I3.instance;
        public static Piece i4 = I4.instance;
        public static Piece i5 = I5.instance;
        
        public static Dictionary<string, Piece> AllPieces = new Dictionary<string, Piece>
        {
            { "L5", l5 }, 
            { "Y",  y },   
            { "N",  n },   
            { "V3", v3 }, 
            { "U",  u },   
            { "V5", v5 }, 
            { "Z5", z5 }, 
            { "X",  x },   
            { "T5", t5 }, 
            { "W",  w },   
            { "P",  p },   
            { "F",  f },   
            { "O4", o4 }, 
            { "L4", l4 }, 
            { "T4", t4 }, 
            { "Z4", z4 }, 
            { "I1", i1 }, 
            { "I2", i2 }, 
            { "I3", i3 }, 
            { "I4", i4 }, 
            { "I5", i5 }
        };
         
        
    }
  
    
}