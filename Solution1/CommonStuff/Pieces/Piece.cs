using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BlokusAI.CommonStuff.Pieces
{
    public partial class Piece
    {
        public Coord[] D;

        public Piece()
        { }

        public Piece(List<Coord> list)
        { D = list.ToArray(); }

        public virtual Piece Reflect(Axis axis)
        {
            switch (axis)
            {
                case Axis.None: return this;
                case Axis.X: return ReflectX();
                case Axis.Y: return ReflectY();
                case Axis.Both: return ReflectBoth();
                default:
                    throw new Exception("Something went wrong, something bad"); //this should never happen, but still...
            }
        }

        protected virtual Piece ReflectX()
        {
            foreach (Coord c in D)
                c.Y = (sbyte)-c.Y;
            return this;
        }

        protected virtual Piece ReflectY()
        {
            foreach (Coord c in D)
                c.X = (sbyte)-c.X;
            return this;
        }

        protected virtual Piece ReflectBoth()
        { return ReflectX().ReflectY(); }

        public virtual Piece Rotate(int amount)
        {
            if (amount % 90 != 0)
                throw new ArgumentException("Must be a multiple of 90");
            amount %= 360;
            switch (amount)
            {
                case 0: return this;
                case 90: return Rot90();
                case 180: return Rot180();
                case 270: return Rot270();
                default:
                    throw new Exception("Something happend, something bad");//this should never happen, but still...
            }
        }

        protected virtual Piece Rot90()
        {
            for (int i = 0; i < D.Length; i++)
                D[i] = new Coord(D[i].Y, ((sbyte)-D[i].X));
            return this;
        }

        protected virtual Piece Rot180()
        { return Rot90().Rot90(); }

        protected virtual Piece Rot270()
        { return Rot180().Rot90(); }
    }
}