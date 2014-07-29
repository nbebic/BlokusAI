using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokusAI.CommonStuff
{
    class HelperFunctions
    {
        public static List<Move> GetAllMoves(CommonGrid g, Hand h, Player player)
        {
            return (from n in g.nukleations
                    from p in h.Pieces
                    from o in p.Orbits
                    from k in o.Nukleations
                    where ((k.Orientation == n.Orientation) &&
                    g.SafeToMove(p, n.X - k.X, n.Y - k.Y, player))
                    select new Move(p, n.X - k.X, n.Y - k.Y)).ToList<Move>();
        }
    }
}
