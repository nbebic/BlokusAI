using System;
using System.Linq;
using BlokusAI.CommonStuff.Pieces;
using System.Collections.Generic;

namespace BlokusAI.CommonStuff
{
    /// <summary>
    /// Represents a Common Grid, only Public Version of Grid
    /// </summary>
    public class CommonGrid
    {
        public CommonGrid()
        {
            nopeList = new List<NopeSquare>();
            nukleations = new List<Nukleation>();
        }
        
        public byte[,] squares = new byte[14, 14];

        public List<NopeSquare> nopeList
        {
            get;
            protected set;
        }

        public List<Nukleation> nukleations
        {
            get;
            protected set;
        }

        //=========================================================//

        public void AddNukleation(int x, int y, NukleationOrientation orient, Player player)
        {
            nukleations.Add(new Nukleation(x, y, orient, player));
        }

        public bool HasNukleation(int x, int y, NukleationOrientation orient, Player player)
        {
            foreach (Nukleation n in nukleations)
            {
                if (n.X == x)
                    if (n.Y == y)
                        if (n.Orientation == orient)
                            if (n.player == player)
                                return true;
            }
            return false;
        }
        public bool HasNukleation(int x, int y, Player player)
        {
            foreach (Nukleation n in nukleations)
            {
                if (n.X == x)
                    if (n.Y == y)
                        if (n.player == player)
                            return true;
            }
            return false;
        }

        public void DelNukleation(int x, int y, Player player)
        {
            var c = nukleations;
            foreach (Nukleation n in nukleations)
                if (n.X == x)
                    if (n.Y == y)
                        if (n.player == player)
                            c.Remove(n);
            nukleations = c;
        }
        public void DelNukleation(int x, int y)
        {
            var c = nukleations.ToList();
            foreach (Nukleation n in nukleations)
                if (n.X == x)
                    if (n.Y == y)
                        c.Remove(n);
            nukleations = c;
        }

        //=========================================================//

        public void AddNope(int x, int y, Player player)
        {
            nopeList.Add(new NopeSquare(x, y, player));
        }
        public void AddNope(int x, int y)
        {
            AddNope(x, y, Player.PL1);
            AddNope(x, y, Player.PL2);
        }

        public bool HasNope(int x, int y, Player player)
        {
            foreach (NopeSquare n in nopeList)
            {
                if (n.x == x)
                    if (n.y == y)
                        if (n.player == player)
                            return true;
            }
            return false;
        }

        public void DelNope(int x, int y)
        {
            foreach (NopeSquare n in nopeList)
                if (n.x == x)
                    if (n.y == y)
                        nopeList.Remove(n);
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
                r.nopeList = this.nopeList;
                r.nukleations = this.nukleations;
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
        public virtual CommonGrid Move(Piece p, int x, int y, Player player, bool manualOverride)
        {
            if (!(manualOverride || SafeToMove(p, x, y, player)))
                throw new IllegalMoveException("nope");// TODO Add some more descriptive text

            foreach (Coord c in p.D)
            {
                int ax = c.X + x, ay = c.Y + y;
                if (!((ax < 0) || (ay < 0) || (ax > 13) || (ay > 13)))
                {
                    squares[ax, ay] |= (byte)player;
                    DelNukleation(ax, ay);
                    AddNope(ax, ay);
                }
                if (ax > 0)
                    AddNope(ax - 1, ay, player);
                if (ax < 13)
                    AddNope(ax + 1, ay, player);
                if (ay > 0)
                    AddNope(ax, ay - 1, player);
                if (ay < 13)
                    AddNope(ax, ay + 1, player);
            }

            foreach (Coord c in p.D)
            {
                int ax = c.X + x, ay = c.Y + y;
                if (ay < 13)
                {
                    //NE
                    if (ax > 0)
                        if (squares[ax-1, ay+1] == 0)
                            if (!HasNope(ax-1, ay+1,player))
                                AddNukleation(ax - 1, ay + 1, NukleationOrientation.NE, player);
                    //SE
                    if (ax < 13)
                        if (squares[ax+1, ay+1] == 0)
                            if (!HasNope(ax+1, ay+1,player))
                                AddNukleation(ax + 1, ay + 1, NukleationOrientation.SE, player);
                }
                if (ay > 0)
                {
                    //NW
                    if (ax > 0)
                        if (squares[ax-1, ay-1] == 0)
                            if (!HasNope(ax-1, ay-1,player))
                                AddNukleation(ax - 1, ay - 1, NukleationOrientation.NW, player);
                    //SW
                    if (ax < 13)
                        if (squares[ax+1, ay-1] == 0)
                            if (!HasNope(ax+1, ay-1,player))
                                AddNukleation(ax + 1, ay - 1, NukleationOrientation.SW, player);
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
        /// <returns>this</returns>
        public virtual CommonGrid Move(Piece p, int x, int y, Player player)
        { return Move(p, x, y, player, false); }

        public bool SafeToMove(Piece p, int x, int y, Player player)
        {
            var b = false;
            for (int i = 0; i < p.D.Length; i++)
            {
                int ax = p.D[i].X + x, ay = p.D[i].Y + y;
                if ((ax < 0) || (ay < 0) || (ax > 13) || (ay > 13))
                    return false;
                if (squares[ax, ay] != 0)
                    return false;
                if (HasNope(ax, ay, player))
                    return false;
                if (HasNukleation(ax, ay, player))
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