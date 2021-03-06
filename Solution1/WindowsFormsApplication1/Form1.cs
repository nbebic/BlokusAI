﻿using System;
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

            foreach (Nukleation n in grid.nukleations)
            {
                var ax = n.X * 21;
                var ay = n.Y * 21;
                graph.DrawEllipse(pen, ax + 6, ay + 6, 10, 10);
                switch (n.Orientation)
                {
                    case NukleationOrientation.NE:
                        graph.DrawLine(new Pen(Color.Yellow), ax + 10, ay + 10, ax + 15, ay + 5);
                        break;
                    case NukleationOrientation.SE:
                        graph.DrawLine(new Pen(Color.Red), ax + 10, ay + 10, ax + 5, ay + 5);
                        break;
                    case NukleationOrientation.SW:
                        graph.DrawLine(new Pen(Color.Blue), ax + 10, ay + 10, ax + 5, ay + 15);
                        break;
                    case NukleationOrientation.NW:
                        graph.DrawLine(new Pen(Color.Green), ax + 10, ay + 10, ax + 15, ay + 15);
                        break;
                }
            }

            foreach (Nukleation n in p.Nukleations)
            {
                var ax = (n.X + 6) * 21;
                var ay = (n.Y + 6) * 21;
                switch (n.Orientation)
                {
                    case NukleationOrientation.NE:
                        graph.DrawLine(new Pen(Color.Yellow), ax + 10, ay + 10, ax + 15, ay + 5);
                        break;
                    case NukleationOrientation.SE:
                        graph.DrawLine(new Pen(Color.Red), ax + 10, ay + 10, ax + 5, ay + 5);
                        break;
                    case NukleationOrientation.SW:
                        graph.DrawLine(new Pen(Color.Blue), ax + 10, ay + 10, ax + 5, ay + 15);
                        break;
                    case NukleationOrientation.NW:
                        graph.DrawLine(new Pen(Color.Green), ax + 10, ay + 10, ax + 15, ay + 15);
                        break;
                }
            }

            //NOPES

            foreach (NopeSquare n in grid.nopeList)
            {
                var ax = n.x * 21;
                var ay = n.y * 21;
                graph.DrawRectangle(pen, ax + 6, ay + 6, 10, 10);
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
                grid.Move(p, 6, 6, Player.PL1, true);
                CreateGraphics().Clear(this.BackColor);
                this.RaisePaintEvent(null, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p = p.Rotate(270);
            grid = new CommonGrid();
            grid.Move(p, 6, 6, Player.PL1, true);
            CreateGraphics().Clear(this.BackColor);
            this.RaisePaintEvent(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p = p.Rotate(90);
            grid = new CommonGrid();
            grid.Move(p, 6, 6, Player.PL1, true);
            CreateGraphics().Clear(this.BackColor);
            this.RaisePaintEvent(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            while (AiTest.Play(grid) == 1);
            this.CreateGraphics().Clear(this.BackColor);
            this.RaisePaintEvent(null, null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p = p.Reflect(Axis.X);
            grid = new CommonGrid();
            grid.Move(p, 6, 6, Player.PL1, true);
            CreateGraphics().Clear(this.BackColor);
            this.RaisePaintEvent(null, null);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p = p.Reflect(Axis.Y);
            grid = new CommonGrid();
            grid.Move(p, 6, 6, Player.PL1, true);
            CreateGraphics().Clear(this.BackColor);
            this.RaisePaintEvent(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grid = new CommonGrid();
            grid.Move(p, 6, 6, Player.PL1, true);
        }
    }
}