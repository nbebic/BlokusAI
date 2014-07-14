using System;
using System.Linq;
using BlokusAI.CommonStuff.Pieces;

namespace BlokusAI.CommonStuff
{
    /// <summary>
    /// Represents a Common Grid, only Public Version of Grid
    /// </summary>
    public class CommonGrid
    {
        protected byte[,] squares = new byte[14, 14];
        protected byte[,] nope = new byte[14, 14];
        protected byte[,] nukleation = new byte[14, 14];

        public CommonGrid()
        { }

        /// <summary>
        /// Represents Nukleation Points on the Board in this Bit Pattern:
        /// 0000000X - NE for player 1
        /// 000000X0 - NE for player 2
        /// 00000X00 - SE for player 1
        /// 0000X000 - SE for player 2
        /// 000X0000 - SW for player 1
        /// 00X00000 - SW for player 2
        /// 0X000000 - NW for player 1
        /// X0000000 - NW for player 2
        /// </summary>
        public byte[,] Nukleation
        {
            get { return nukleation; }
        }

        /// <summary>
        /// Represents Nope Squares on the Board in this Bit Pattern:
        /// 00 00 00 01 - Nope for player 1
        /// 00 00 00 10 - Nope for player 2
        /// </summary>
        public byte[,] Nope
        {
            get { return nope; }
        }

        /// <summary>
        /// Represents Square Ocupation on the Board in this Bit Pattern:
        /// 00 00 00 01 - Ocupied by player 1
        /// 00 00 00 10 - Ocupied by player 2
        /// <remarks>
        /// Technicaly a square can be ocupied by both players, the grid
        /// does not check validity of the moves.
        /// </remarks>
        /// </summary>
        public byte[,] Squares
        {
            get { return squares; }
        }

        /// <summary>
        /// Creates a copy of a current Grid
        /// </summary>
        /// <returns>A copy of a current Grid</returns>
        public virtual CommonGrid Copy
        {
            get
            {
                var r = new CommonGrid();
                r.squares = this.squares;
                r.nope = this.nope;
                r.nukleation = this.nukleation;
                return r;
            }
        }

        /// <summary>
        /// Moves, with optional validity checking. ONLY TO BE USED WITH GODMODE PLAYERS/TESTERS!
        /// </summary>
        /// <param name="p">a piece to be placed</param>
        /// <param name="x">x coordinate of the piece origin</param>
        /// <param name="y">y coordinate of the piece origin</param>
        /// <param name="player">player no (1 or 2)</param>
        /// <param name="manualOverride">if set to true, will ignore placing rules, the piece still must not exceed board</param>
        /// <exception cref="IllegalMoveException">Throws if the move is not permited</exception>
        /// <exception cref="ArgumentException">Throws if piece is out of board bounds</exception>
        /// <returns>this</returns>
        public virtual CommonGrid Move(Piece p, byte x, byte y, byte player, bool manualOverride)
        {
            if (x + p.BoundsDown > 13)
                throw new ArgumentException("You're doing it wrong", "x");
            if (x + p.BoundsUp < 0)
                throw new ArgumentException("You're doing it wrong", "x");

            if (y + p.BoundsLeft < 0)
                throw new ArgumentException("You're doing it wrong", "y");
            if (y + p.BoundsRight > 13)
                throw new ArgumentException("You're doing it wrong", "y");

            if (!(manualOverride || SafeToMove(p, x, y, player)))
                throw new IllegalMoveException("nope");// TODO Add some more descriptive text

            foreach (Coord c in p.D)
            {
                int ax = c.X + x, ay = c.Y + y;
                squares[ax, ay] |= player;
                Nukleation[ax, ay] = 0;
                nope[ax, ay] = 3;
                if (ax > 0)
                    nope[ax - 1, ay] |= player;
                if (ax < 13)
                    nope[ax + 1, ay] |= player;
                if (ay > 0)
                    nope[ax, ay - 1] |= player;
                if (ay < 13)
                    nope[ax, ay + 1] |= player;
            }

            foreach (Coord c in p.D)
            {
                int ax = c.X + x, ay = c.Y + y;
                if (ay < 13)
                { 
                    //NE
                    if (ax > 0)
                        nukleation[ax - 1, ay + 1] |= (byte)(((squares[ax - 1, ay + 1] == 0) && ((nope[ax - 1, ay + 1] & player) == 0)) ? player : 0);
                    //SE
                    if (ax < 13)
                        nukleation[ax + 1, ay + 1] |= (byte)(((squares[ax + 1, ay + 1] == 0) && ((nope[ax + 1, ay + 1] & player) == 0)) ? player << 2 : 0);
                }
                if (ay > 0)
                {
                    //NW
                    if (ax > 0)
                        nukleation[ax - 1, ay - 1] |= (byte)(((squares[ax - 1, ay - 1] == 0) && ((nope[ax - 1, ay - 1] & player) == 0)) ? player << 6 : 0);
                    //SW
                    if (ax < 13)
                        nukleation[ax + 1, ay - 1] |= (byte)(((squares[ax + 1, ay - 1] == 0) && ((nope[ax + 1, ay - 1] & player) == 0)) ? player << 4 : 0);
                }
            }
            return this;
        }
  
        /// <summary>
        /// Checks if the move is valid and preforms it if so, else throws an exception
        /// </summary>
        /// <param name="p">a piece to be placed</param>
        /// <param name="x">x coordinate of the piece origin</param>
        /// <param name="y">y coordinate of the piece origin</param>
        /// <param name="player">player no (1 or 2)</param>
        /// <exception cref="IllegalMoveException">Throws if the move is not permited</exception>
        /// <exception cref="ArgumentException">Throws if piece is out of board bounds</exception>
        /// <returns>this</returns>
        public virtual CommonGrid Move(Piece p, byte x, byte y, byte player)
        { return Move(p, x, y, player, false); }
  
        public bool SafeToMove(Piece p, byte x, byte y, byte player)
        {
            var b = false;
            for (int i = 0; i < p.D.Length; i++)
            {
                int ax = p.D[i].X + x, ay = p.D[i].Y + y;
                if (squares[ax, ay] != 0)
                    return false;
                if ((nope[ax, ay] & player) > 0)
                    return false;
                if ((Nukleation[ax, ay] & (player | (player << 2) | (player << 4) | (player << 6))) > 0)
                    b = true;
                if ((ax == 4) && (ay == 4))
                    b = true;
                if ((ax == 9) && (ay == 9))
                    b = true;
            }
            return b;
        }
    }
}