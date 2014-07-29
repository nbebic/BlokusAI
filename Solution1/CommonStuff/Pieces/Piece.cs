using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BlokusAI.CommonStuff.Pieces
{
    public partial class Piece : ICloneable
    {
        public Coord[] D { get; set; }
        public Nukleation[] Nukleations { get; set; }
        public Piece[] Orbits { get; set; }
        public Piece()
        { }
        public Piece(int dl, int nl, int ol)
        {
            this.D = new Coord[dl];
            for (int i = 0; i < D.Length; i++)
                D[i] = new Coord(0, 0);
            this.Nukleations = new Nukleation[nl];
            for (int i = 0; i < Nukleations.Length; i++)
                Nukleations[i] = new Nukleation(0, 0, 0);
            this.Orbits = new Piece[ol];
        }

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
            var copy = (Piece)this.Clone();
            for (int i = 0; i < D.Length; i++)
                copy.D[i].Y = -D[i].Y;
            for (int i = 0; i < Nukleations.Length; i++)
            {
                copy.Nukleations[i].Y = -Nukleations[i].Y;
                copy.Nukleations[i].Orientation =
                    (NukleationOrientation)((neglect(
                        ((int)Nukleations[i].Orientation + 2) % 8
                    ) + 6) % 8);
            }
            return copy;
        }

        protected virtual Piece ReflectY()
        {
            var copy = (Piece)this.Clone();
            for (int i = 0; i < D.Length; i++)
                copy.D[i].X = -D[i].X;
            for (int i = 0; i < Nukleations.Length; i++)
            {
                copy.Nukleations[i].X = -Nukleations[i].X;
                copy.Nukleations[i].Orientation =
                    (NukleationOrientation)neglect((int)Nukleations[i].Orientation);
            }
            return copy;
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
            var copy = (Piece)this.Clone();
            for (int i = 0; i < D.Length; i++)
            {
                copy.D[i] = new Coord(D[i].Y, ((sbyte)-D[i].X));

            }
            for (int i = 0; i < Nukleations.Length; i++)
            {
                copy.Nukleations[i] = new Nukleation(
                    Nukleations[i].Y,
                    ((sbyte)-Nukleations[i].X),
                    (byte)(((int)Nukleations[i].Orientation + 6) % 8)
                    );
            }
            return copy;
        }

        protected virtual Piece Rot180()
        { return Rot90().Rot90(); }

        protected virtual Piece Rot270()
        { return Rot180().Rot90(); }

        public object Clone()
        {
            var copy = new Piece(D.Length, Nukleations.Length, Orbits.Length);
            copy.D = this.D;
            copy.Nukleations = this.Nukleations;
            copy.Orbits = this.Orbits;
            return copy;
        }

        public static int neglect(int a)
        {
            switch (a)
            {
                case 0: return 6;
                case 6: return 0;
                case 2: return 4;
                case 4: return 2;
                default: return 0;
            }
        }
    }
}