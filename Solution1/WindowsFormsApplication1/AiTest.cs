using BlokusAI.CommonStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class AiTest
    {
        public static int Play(CommonGrid grid)
        {
            var list = HelperFunctions.GetAllMoves(grid,Hand.FullHand,Player.PL1);
            if (list.Count == 0)
                return 0;
            var r = new Random();
            var m = list[r.Next(list.Count)];
            grid.Move(m.P, m.X, m.Y, Player.PL1);
            return 1;
        }
    }
}
