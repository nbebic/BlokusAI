using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlokusAI.CommonStuff;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            var r = ofdPlayer1.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
                txtPlayer1.Text = ofdPlayer1.FileName;
        }

        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            var r = ofdPlayer2.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
                txtPlayer2.Text = ofdPlayer2.FileName;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            IBlokusAI pl1, pl2;
            if (ValidateAssembly(txtPlayer1.Text, out pl1))
            {
                if (ValidateAssembly(txtPlayer2.Text, out pl2))
                {
                    FormPlay form = new FormPlay(pl1, pl2);
                    form.Show();
                    form.Start();
                }
                else
                    MessageBox.Show("Player 2 Assembly is not a Valid Player Assembly!", "Stuff gone wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Player 1 Assembly is not a Valid Player Assembly!", "Stuff gone wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidateAssembly(string path, out IBlokusAI ai)
        {
            try
            {
                var dll = Assembly.LoadFile(path);
                foreach (var t in dll.GetExportedTypes())
                { 
                    var c = Activator.CreateInstance(t);
                    if (c is IBlokusAI)
                    {
                        var fai = c as IBlokusAI;
                        if (fai.Validate())
                        {
                            ai = fai;
                            return true;
                        }
                    }
                }
            }
            catch (Exception e)
            { 
                //Print an informational message, but two messages will pop up, so, yeah...
            }
            ai = null;
            return false;
        }
    }
}
