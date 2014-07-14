using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BlokusAI.CommonStuff.Pieces
{
    public partial class Piece
    {
        public Coord[] D { get; set; }
        public Nukleation[] Nukleations { get; set; }
        public Piece[] Orbits { get; set; }
        public Piece()
        { }

        public Piece(Coord[] d, Nukleation[] n, Piece[] orb)
        {
            this.D = d;
            this.Nukleations = n;
            this.Orbits = orb;
        }

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
            foreach (var c in D)
                c.X = -c.X;
            foreach (var n in Nukleations)
                n.X = -n.X;
            return this;
        }

        protected virtual Piece ReflectY()
        {
            foreach (var c in D)
                c.X = -c.X;
            foreach (var n in Nukleations)
                n.X = -n.X;
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
            {
                D[i] = new Coord(D[i].Y, ((sbyte)-D[i].X));
                Nukleations[i] = new Nukleation(Nukleations[i].Y, ((sbyte)-Nukleations[i].X), (byte)(((int)Nukleations[i].Orientation + 6) % 8));
            }
            return this;
        }

        protected virtual Piece Rot180()
        { return Rot90().Rot90(); }

        protected virtual Piece Rot270()
        { return Rot180().Rot90(); }
    }
}