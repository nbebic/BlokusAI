using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BlokusAI.CommonStuff;
using BlokusAI.CommonStuff.Pieces;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        { InitializeComponent(); }

        private Piece p = Piece.AllPieces["X"];
        private CommonGrid grid = new CommonGrid();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.FromArgb(255, 85, 85, 85));
            var graph = CreateGraphics();
            for (int i = 0; i < 15; i++)
            {
                graph.DrawLine(pen, 0, i * 21, 295, i * 21);
                graph.DrawLine(pen, i * 21, 0, i * 21, 295);
            }
            var br = new SolidBrush(Color.Orange);
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                { 
                    if (grid.Squares[i,j] > 0)
                    {
                        var ax = i * 21;
                        var ay = j * 21;
                        graph.FillRectangle(br, ax + 1, ay + 1, 20, 20);
                    }
                }
            }

            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (grid.Nukleation[i, j] > 0)
                    {
                        var ax = i * 21;
                        var ay = j * 21;
                        graph.DrawEllipse(pen, ax + 6, ay + 6, 10, 10);
                    }
                }
            }

            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (grid.Nope[i, j] > 0)
                    {
                        var ax = i * 21;
                        var ay = j * 21;
                        graph.DrawRectangle(pen, ax + 6, ay + 6, 10, 10);
                    }
                }
            }
 
            pen.Dispose();
            graph.Dispose();
            br.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Piece.AllPieces.ContainsKey(textBox1.Text))
            { 
                p = Piece.AllPieces[textBox1.Text];
                grid = new CommonGrid();
                grid.Move(p, 6, 6, 1, true);
                CreateGraphics().Clear(this.BackColor);
                this.RaisePaintEvent(null, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.Rotate(270);
            p = Piece.AllPieces[textBox1.Text];
            grid = new CommonGrid();
            grid.Move(p, 6, 6, 1, true);
            CreateGraphics().Clear(this.BackColor);
            this.RaisePaintEvent(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.Rotate(90);
            p = Piece.AllPieces[textBox1.Text];
            grid = new CommonGrid();
            grid.Move(p, 6, 6, 1, true);
            CreateGraphics().Clear(this.BackColor);
            this.RaisePaintEvent(null, null);
        }
    }
}