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

        private Piece p = Piece.AllPieces["L5"];
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

            //SQUARES

            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                { 
                    if (grid.Squares[i, j] > 0)
                    {
                        var ax = i * 21;
                        var ay = j * 21;
                        graph.FillRectangle(br, ax + 1, ay + 1, 20, 20);
                    }
                }
            }

            //NUKLEATIONS

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

            foreach (Nukleation n in p.Nukleations)
            {
                var ax = (n.X + 6) * 21;
                var ay = (n.Y + 6) * 21;
                switch (n.Orientation)
                {
                    case NukleationOrientation.NE:
                        graph.DrawLine(pen, ax + 15, ay + 5, ax + 20, ay);
                        break;
                    case NukleationOrientation.SE:
                        graph.DrawLine(pen, ax + 15, ay + 15, ax + 20, ay + 20);
                        break;
                    case NukleationOrientation.SW:
                        graph.DrawLine(pen, ax + 5, ay + 15, ax, ay + 20);
                        break;
                    case NukleationOrientation.NW:
                        graph.DrawLine(pen, ax + 5, ay + 5, ax, ay);
                        break;
                }
            }

            //NOPES

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

            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (grid.Nukleation[i, j] > 0)
                    {
                        var a = grid.Nukleation[i, j];
                        var ax = i * 21;
                        var ay = j * 21;
                        if (((a) & 3) > 0)
                            graph.DrawLine(pen, ax + 10, ay + 10, ax + 15, ay + 5);
                        if (((a >> 2) & 3) > 0)
                            graph.DrawLine(pen, ax + 10, ay + 10, ax + 5, ay + 5);
                        if (((a >> 4) & 3) > 0)
                            graph.DrawLine(pen, ax + 10, ay + 10, ax + 5, ay + 15);
                        if (((a >> 6) & 3) > 0)
                            graph.DrawLine(pen, ax + 10, ay + 10, ax + 15, ay + 15);
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

        private void button4_Click(object sender, EventArgs e)
        {
            int x2,y2;
            if (Int32.TryParse(textBox2.Text, out x2))
                if (Int32.TryParse(textBox3.Text, out y2))
                {
                    var x = (byte)x2;
                    var y = (byte)y2;
                    textBox4.Text = Convert.ToString(grid.Squares[x, y], 2);
                    while (textBox4.Text.Length < 8)
                        textBox4.Text = "0" + textBox4.Text;
                    textBox5.Text = Convert.ToString(grid.Nope[x, y], 2);
                    while (textBox5.Text.Length < 8)
                        textBox5.Text = "0" + textBox5.Text;
                    textBox6.Text = Convert.ToString(grid.Nukleation[x, y], 2);
                    while (textBox6.Text.Length < 8)
                        textBox6.Text = "0" + textBox6.Text;
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p = p.Reflect(Axis.X);
            CreateGraphics().Clear(this.BackColor);
            this.RaisePaintEvent(null, null);
        }
    }
}