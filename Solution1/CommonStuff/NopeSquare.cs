using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokusAI.CommonStuff
{
    public class NopeSquare
    {
        public int x;
        public int y;
        public Player player;

        public NopeSquare(int x, int y, Player player)
        {
            this.x = x;
            this.y = y;
            this.player = player;
        }
    }
}
