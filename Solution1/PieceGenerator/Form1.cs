using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PieceGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GenClass(
            string name, string ext,
            string dx1, string dy1,
            string dx2, string dy2,
            string dx3, string dy3,
            string dx4, string dy4,
            string dx5, string dy5,
            string nx1, string ny1, string no1,
            string nx2, string ny2, string no2,
            string nx3, string ny3, string no3,
            string nx4, string ny4, string no4,
            string nx5, string ny5, string no5,
            string nx6, string ny6, string no6,
            string nx7, string ny7, string no7,
            string nx8, string ny8, string no8
            )
        {
            var str = new StringBuilder();

            #region coords
            str.AppendLine("    public class [NAME][EXT] : Piece {");
            str.AppendLine("        public Coord[] D = {");
            if (cbxD1.Checked)
                str.AppendLine("            new Coord([DX1],[DY1]),");
            if (cbxD2.Checked)
                str.AppendLine("            new Coord([DX2],[DY2]),");
            if (cbxD3.Checked)
                str.AppendLine("            new Coord([DX3],[DY3]),");
            if (cbxD4.Checked)
                str.AppendLine("            new Coord([DX4],[DY4]),");
            if (cbxD5.Checked)
                str.AppendLine("            new Coord([DX5],[DY5]),");
            #endregion
            str.Remove(str.Length - 3, 3);
            str.AppendLine("\n};");

            #region nukleations
            str.AppendLine("        public Nukleation[] Nukleations = {");
            if (cbxN1.Checked)
                str.AppendLine("            new Nukleation([NX1],[NY1],[NO1]),");
            if (cbxN2.Checked)
                str.AppendLine("            new Nukleation([NX2],[NY2],[NO2]),");
            if (cbxN3.Checked)
                str.AppendLine("            new Nukleation([NX3],[NY3],[NO3]),");
            if (cbxN4.Checked)
                str.AppendLine("            new Nukleation([NX4],[NY4],[NO4]),");
            if (cbxN5.Checked)
                str.AppendLine("            new Nukleation([NX5],[NY5],[NO5]),");
            if (cbxN6.Checked)
                str.AppendLine("            new Nukleation([NX6],[NY6],[NO6]),");
            if (cbxN7.Checked)
                str.AppendLine("            new Nukleation([NX7],[NY7],[NO7]),");
            if (cbxN8.Checked)
                str.AppendLine("            new Nukleation([NX8],[NY8],[NO8]),");
            #endregion
            str.Remove(str.Length - 3, 3);
            str.AppendLine("\n};");

            Orbits(ref str);

            str.AppendLine("    }");

            #region replaces
            str.Replace("[NAME]", name);
            str.Replace("[EXT]", ext);
            str.Replace("[DX1]", dx1);
            str.Replace("[DX2]", dx2);
            str.Replace("[DX3]", dx3);
            str.Replace("[DX4]", dx4);
            str.Replace("[DX5]", dx5);
            str.Replace("[DY1]", dy1);
            str.Replace("[DY2]", dy2);
            str.Replace("[DY3]", dy3);
            str.Replace("[DY4]", dy4);
            str.Replace("[DY5]", dy5);
            str.Replace("[NX1]", nx1);
            str.Replace("[NX2]", nx2);
            str.Replace("[NX3]", nx3);
            str.Replace("[NX4]", nx4);
            str.Replace("[NX5]", nx5);
            str.Replace("[NX6]", nx6);
            str.Replace("[NX7]", nx7);
            str.Replace("[NX8]", nx8);
            str.Replace("[NY1]", ny1);
            str.Replace("[NY2]", ny2);
            str.Replace("[NY3]", ny3);
            str.Replace("[NY4]", ny4);
            str.Replace("[NY5]", ny5);
            str.Replace("[NY6]", ny6);
            str.Replace("[NY7]", ny7);
            str.Replace("[NY8]", ny8);
            str.Replace("[NO1]", no1);
            str.Replace("[NO2]", no2);
            str.Replace("[NO3]", no3);
            str.Replace("[NO4]", no4);
            str.Replace("[NO5]", no5);
            str.Replace("[NO6]", no6);
            str.Replace("[NO7]", no7);
            str.Replace("[NO8]", no8);
            #endregion
            return str.ToString();
        }

        private void Orbits(ref StringBuilder str)
        {
            str.AppendLine("        public Piece[] Orbits = {");
            str.AppendLine("            new [NAME](),");
            if (cbxR90.Checked)
                str.AppendLine("            new [NAME]90(),");
            if (cbxR180.Checked)
                str.AppendLine("            new [NAME]180(),");
            if (cbxR270.Checked)
                str.AppendLine("            new [NAME]270(),");
            if (cbxRR.Checked)
                str.AppendLine("            new [NAME]R(),");
            if (cbxRR90.Checked)
                str.AppendLine("            new [NAME]R90(),");
            if (cbxRR180.Checked)
                str.AppendLine("            new [NAME]R180(),");
            if (cbxRR270.Checked)
                str.AppendLine("            new [NAME]R270(),");
            str.Remove(str.Length - 3, 3);
            str.AppendLine("\n};");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var str = new StringBuilder();
            str.AppendLine("using System;");
            str.AppendLine("using System.Linq;");
            str.AppendLine();
            str.AppendLine("namespace BlokusAI.CommonStuff.Pieces {");
            #region def
            int dx1 = 0;
            int dx2 = 0;
            int dx3 = 0;
            int dx4 = 0;
            int dx5 = 0;
            int dy1 = 0;
            int dy2 = 0;
            int dy3 = 0;
            int dy4 = 0;
            int dy5 = 0;
            int nx1 = 0;
            int nx2 = 0;
            int nx3 = 0;
            int nx4 = 0;
            int nx5 = 0;
            int nx6 = 0;
            int nx7 = 0;
            int nx8 = 0;
            int ny1 = 0;
            int ny2 = 0;
            int ny3 = 0;
            int ny4 = 0;
            int ny5 = 0;
            int ny6 = 0;
            int ny7 = 0;
            int ny8 = 0;
            int no1 = 0;
            int no2 = 0;
            int no3 = 0;
            int no4 = 0;
            int no5 = 0;
            int no6 = 0;
            int no7 = 0;
            int no8 = 0;
            #endregion def
            #region assign
            try { dx1 = Int32.Parse(txtX1.Text); }
            catch (Exception ex) { }
            try { dx2 = Int32.Parse(txtX2.Text); }
            catch (Exception ex) { }
            try { dx3 = Int32.Parse(txtX3.Text); }
            catch (Exception ex) { }
            try { dx4 = Int32.Parse(txtX4.Text); }
            catch (Exception ex) { }
            try { dx5 = Int32.Parse(txtX5.Text); }
            catch (Exception ex) { }
            try { dy1 = Int32.Parse(txtY1.Text); }
            catch (Exception ex) { }
            try { dy2 = Int32.Parse(txtY2.Text); }
            catch (Exception ex) { }
            try { dy3 = Int32.Parse(txtY3.Text); }
            catch (Exception ex) { }
            try { dy4 = Int32.Parse(txtY4.Text); }
            catch (Exception ex) { }
            try { dy5 = Int32.Parse(txtY5.Text); }
            catch (Exception ex) { }
            try { nx1 = Int32.Parse(txtNX1.Text); }
            catch (Exception ex) { }
            try { nx2 = Int32.Parse(txtNX2.Text); }
            catch (Exception ex) { }
            try { nx3 = Int32.Parse(txtNX3.Text); }
            catch (Exception ex) { }
            try { nx4 = Int32.Parse(txtNX4.Text); }
            catch (Exception ex) { }
            try { nx5 = Int32.Parse(txtNX5.Text); }
            catch (Exception ex) { }
            try { nx6 = Int32.Parse(txtNX6.Text); }
            catch (Exception ex) { }
            try { nx7 = Int32.Parse(txtNX7.Text); }
            catch (Exception ex) { }
            try { nx8 = Int32.Parse(txtNX8.Text); }
            catch (Exception ex) { }
            try { ny1 = Int32.Parse(txtNY1.Text); }
            catch (Exception ex) { }
            try { ny2 = Int32.Parse(txtNY2.Text); }
            catch (Exception ex) { }
            try { ny3 = Int32.Parse(txtNY3.Text); }
            catch (Exception ex) { }
            try { ny4 = Int32.Parse(txtNY4.Text); }
            catch (Exception ex) { }
            try { ny5 = Int32.Parse(txtNY5.Text); }
            catch (Exception ex) { }
            try { ny6 = Int32.Parse(txtNY6.Text); }
            catch (Exception ex) { }
            try { ny7 = Int32.Parse(txtNY7.Text); }
            catch (Exception ex) { }
            try { ny8 = Int32.Parse(txtNY8.Text); }
            catch (Exception ex) { }
            try { no1 = Int32.Parse(txtNO1.Text); }
            catch (Exception ex) { }
            try { no2 = Int32.Parse(txtNO2.Text); }
            catch (Exception ex) { }
            try { no3 = Int32.Parse(txtNO3.Text); }
            catch (Exception ex) { }
            try { no4 = Int32.Parse(txtNO4.Text); }
            catch (Exception ex) { }
            try { no5 = Int32.Parse(txtNO5.Text); }
            catch (Exception ex) { }
            try { no6 = Int32.Parse(txtNO6.Text); }
            catch (Exception ex) { }
            try { no7 = Int32.Parse(txtNO7.Text); }
            catch (Exception ex) { }
            try { no8 = Int32.Parse(txtNO8.Text); }
            catch (Exception ex) { }
            #endregion assign
            str.AppendLine(GenClass
                (
                txtPieceName.Text, "",
                dx1.ToString(), dy1.ToString(),
                dx2.ToString(), dy2.ToString(),
                dx3.ToString(), dy3.ToString(),
                dx4.ToString(), dy4.ToString(),
                dx5.ToString(), dy5.ToString(),
                nx1.ToString(), ny1.ToString(), no1.ToString(),
                nx2.ToString(), ny2.ToString(), no2.ToString(),
                nx3.ToString(), ny3.ToString(), no3.ToString(),
                nx4.ToString(), ny4.ToString(), no4.ToString(),
                nx5.ToString(), ny5.ToString(), no5.ToString(),
                nx6.ToString(), ny6.ToString(), no6.ToString(),
                nx7.ToString(), ny7.ToString(), no7.ToString(),
                nx8.ToString(), ny8.ToString(), no8.ToString()));

            if (cbxR90.Checked)
                str.AppendLine(GenClass
                (
                txtPieceName.Text, "90",
                dy1.ToString(), (-dx1).ToString(),
                dy2.ToString(), (-dx2).ToString(),
                dy3.ToString(), (-dx3).ToString(),
                dy4.ToString(), (-dx4).ToString(),
                dy5.ToString(), (-dx5).ToString(),
                ny1.ToString(), (-nx1).ToString(), ((no1 + 2) % 8).ToString(),
                ny2.ToString(), (-nx2).ToString(), ((no2 + 2) % 8).ToString(),
                ny3.ToString(), (-nx3).ToString(), ((no3 + 2) % 8).ToString(),
                ny4.ToString(), (-nx4).ToString(), ((no4 + 2) % 8).ToString(),
                ny5.ToString(), (-nx5).ToString(), ((no5 + 2) % 8).ToString(),
                ny6.ToString(), (-nx6).ToString(), ((no6 + 2) % 8).ToString(),
                ny7.ToString(), (-nx7).ToString(), ((no7 + 2) % 8).ToString(),
                ny8.ToString(), (-nx8).ToString(), ((no8 + 2) % 8).ToString()));

            if (cbxR180.Checked)
                str.AppendLine(GenClass
                (
                txtPieceName.Text, "180",
                (-dx1).ToString(), (-dy1).ToString(),
                (-dx2).ToString(), (-dy2).ToString(),
                (-dx3).ToString(), (-dy3).ToString(),
                (-dx4).ToString(), (-dy4).ToString(),
                (-dx5).ToString(), (-dy5).ToString(),
                (-nx1).ToString(), (-ny1).ToString(), ((no1 + 4) % 8).ToString(),
                (-nx2).ToString(), (-ny2).ToString(), ((no2 + 4) % 8).ToString(),
                (-nx3).ToString(), (-ny3).ToString(), ((no3 + 4) % 8).ToString(),
                (-nx4).ToString(), (-ny4).ToString(), ((no4 + 4) % 8).ToString(),
                (-nx5).ToString(), (-ny5).ToString(), ((no5 + 4) % 8).ToString(),
                (-nx6).ToString(), (-ny6).ToString(), ((no6 + 4) % 8).ToString(),
                (-nx7).ToString(), (-ny7).ToString(), ((no7 + 4) % 8).ToString(),
                (-nx8).ToString(), (-ny8).ToString(), ((no8 + 4) % 8).ToString()));

            if (cbxR270.Checked)
                str.AppendLine(GenClass
                (
                txtPieceName.Text, "270",
                (-dy1).ToString(), (dx1).ToString(),
                (-dy2).ToString(), (dx2).ToString(),
                (-dy3).ToString(), (dx3).ToString(),
                (-dy4).ToString(), (dx4).ToString(),
                (-dy5).ToString(), (dx5).ToString(),
                (-ny1).ToString(), (nx1).ToString(), ((no1 + 6) % 8).ToString(),
                (-ny2).ToString(), (nx2).ToString(), ((no2 + 6) % 8).ToString(),
                (-ny3).ToString(), (nx3).ToString(), ((no3 + 6) % 8).ToString(),
                (-ny4).ToString(), (nx4).ToString(), ((no4 + 6) % 8).ToString(),
                (-ny5).ToString(), (nx5).ToString(), ((no5 + 6) % 8).ToString(),
                (-ny6).ToString(), (nx6).ToString(), ((no6 + 6) % 8).ToString(),
                (-ny7).ToString(), (nx7).ToString(), ((no7 + 6) % 8).ToString(),
                (-ny8).ToString(), (nx8).ToString(), ((no8 + 6) % 8).ToString()));

            /*==========================================================*/
            if (cbxRR.Checked)
                str.AppendLine(GenClass
                (
                txtPieceName.Text, "R",
                (-dx1).ToString(), dy1.ToString(),
                (-dx2).ToString(), dy2.ToString(),
                (-dx3).ToString(), dy3.ToString(),
                (-dx4).ToString(), dy4.ToString(),
                (-dx5).ToString(), dy5.ToString(),
                (-nx1).ToString(), ny1.ToString(), neglect(no1).ToString(),
                (-nx2).ToString(), ny2.ToString(), neglect(no2).ToString(),
                (-nx3).ToString(), ny3.ToString(), neglect(no3).ToString(),
                (-nx4).ToString(), ny4.ToString(), neglect(no4).ToString(),
                (-nx5).ToString(), ny5.ToString(), neglect(no5).ToString(),
                (-nx6).ToString(), ny6.ToString(), neglect(no6).ToString(),
                (-nx7).ToString(), ny7.ToString(), neglect(no7).ToString(),
                (-nx8).ToString(), ny8.ToString(), neglect(no8).ToString()));

            if (cbxRR90.Checked)
                str.AppendLine(GenClass
                (
                txtPieceName.Text, "R90",
                (-dy1).ToString(), (-dx1).ToString(),
                (-dy2).ToString(), (-dx2).ToString(),
                (-dy3).ToString(), (-dx3).ToString(),
                (-dy4).ToString(), (-dx4).ToString(),
                (-dy5).ToString(), (-dx5).ToString(),
                (-ny1).ToString(), (-nx1).ToString(), ((neglect(no1) + 2) % 8).ToString(),
                (-ny2).ToString(), (-nx2).ToString(), ((neglect(no2) + 2) % 8).ToString(),
                (-ny3).ToString(), (-nx3).ToString(), ((neglect(no3) + 2) % 8).ToString(),
                (-ny4).ToString(), (-nx4).ToString(), ((neglect(no4) + 2) % 8).ToString(),
                (-ny5).ToString(), (-nx5).ToString(), ((neglect(no5) + 2) % 8).ToString(),
                (-ny6).ToString(), (-nx6).ToString(), ((neglect(no6) + 2) % 8).ToString(),
                (-ny7).ToString(), (-nx7).ToString(), ((neglect(no7) + 2) % 8).ToString(),
                (-ny8).ToString(), (-nx8).ToString(), ((neglect(no8) + 2) % 8).ToString()));

            if (cbxRR180.Checked)
                str.AppendLine(GenClass
                (
                txtPieceName.Text, "R180",
                (dx1).ToString(), (-dy1).ToString(),
                (dx2).ToString(), (-dy2).ToString(),
                (dx3).ToString(), (-dy3).ToString(),
                (dx4).ToString(), (-dy4).ToString(),
                (dx5).ToString(), (-dy5).ToString(),
                (nx1).ToString(), (-ny1).ToString(), ((neglect(no1) + 4) % 8).ToString(),
                (nx2).ToString(), (-ny2).ToString(), ((neglect(no2) + 4) % 8).ToString(),
                (nx3).ToString(), (-ny3).ToString(), ((neglect(no3) + 4) % 8).ToString(),
                (nx4).ToString(), (-ny4).ToString(), ((neglect(no4) + 4) % 8).ToString(),
                (nx5).ToString(), (-ny5).ToString(), ((neglect(no5) + 4) % 8).ToString(),
                (nx6).ToString(), (-ny6).ToString(), ((neglect(no6) + 4) % 8).ToString(),
                (nx7).ToString(), (-ny7).ToString(), ((neglect(no7) + 4) % 8).ToString(),
                (nx8).ToString(), (-ny8).ToString(), ((neglect(no8) + 4) % 8).ToString()));

            if (cbxRR270.Checked)
                str.AppendLine(GenClass
                (
                txtPieceName.Text, "R270",
                (dy1).ToString(), (dx1).ToString(),
                (dy2).ToString(), (dx2).ToString(),
                (dy3).ToString(), (dx3).ToString(),
                (dy4).ToString(), (dx4).ToString(),
                (dy5).ToString(), (dx5).ToString(),
                (ny1).ToString(), (nx1).ToString(), ((neglect(no1) + 6) % 8).ToString(),
                (ny2).ToString(), (nx2).ToString(), ((neglect(no2) + 6) % 8).ToString(),
                (ny3).ToString(), (nx3).ToString(), ((neglect(no3) + 6) % 8).ToString(),
                (ny4).ToString(), (nx4).ToString(), ((neglect(no4) + 6) % 8).ToString(),
                (ny5).ToString(), (nx5).ToString(), ((neglect(no5) + 6) % 8).ToString(),
                (ny6).ToString(), (nx6).ToString(), ((neglect(no6) + 6) % 8).ToString(),
                (ny7).ToString(), (nx7).ToString(), ((neglect(no7) + 6) % 8).ToString(),
                (ny8).ToString(), (nx8).ToString(), ((neglect(no8) + 6) % 8).ToString()));

            str.AppendLine("}");
            textBox1.Text = str.ToString();
            
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