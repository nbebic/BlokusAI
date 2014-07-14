using System;
using System.Linq;
using System.Windows.Forms;
using BlokusAI.CommonStuff;

namespace WindowsFormsApplication2
{
    public partial class FormPlayFFS : Form
    {

        private readonly IBlokusAI pl1;
        private readonly IBlokusAI pl2;

        public FormPlayFFS(IBlokusAI pl1, IBlokusAI pl2)
        {
            this.pl1 = pl1;
            this.pl2 = pl2;
            InitializeComponent();
        }
        /// <summary>
        /// Starts da fight!!!1!
        /// </summary>
        /// <returns>1 if pl. one won, 2 if pl. two won, or 0 if draw</returns>
        public int Start()
        {
            pl1.Activate(1);
            pl2.Activate(2);
            var b1 = true;
            var b2 = true;
            var board = new CounterGrid();
            while (b1 && b2)
            {
                b1 = pl1.Move(board);
                lblPl1.Text = board.CountPl1.ToString();
                b2 = pl2.Move(board);
                lblPl2.Text = board.CountPl2.ToString();
            }
            while (b1)
            {
                b1 = pl1.Move(board);
                lblPl1.Text = board.CountPl1.ToString();
            }
            while (b2)
            {
                b2 = pl2.Move(board);
                lblPl2.Text = board.CountPl2.ToString();
            }
            return (board.CountPl1 > board.CountPl2) ? 1 : (board.CountPl1 == board.CountPl2) ? 0 : 2;
        }

        private class CounterGrid : CommonGrid
        {
            public int CountPl1 { get; protected set; }
            public int CountPl2 { get; protected set; }

            public CounterGrid() : base()
            {
                CountPl1 = 0;
                CountPl2 = 0;
            }

            public override CommonGrid Move(BlokusAI.CommonStuff.Pieces.Piece p, byte x, byte y, byte player, bool manualOverride)
            {
                if (player == 1)
                    CountPl1 += p.D.Length;
                else
                    CountPl2 += p.D.Length;

                return base.Move(p, x, y, player, manualOverride);
            }
        }
    }
}
