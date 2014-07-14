namespace WindowsFormsApplication2
{
    partial class FormPlayFFS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDeco = new System.Windows.Forms.Label();
            this.lblPl2 = new System.Windows.Forms.Label();
            this.lblPl1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblPl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPl2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDeco, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(897, 390);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDeco
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblDeco, 2);
            this.lblDeco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeco.Location = new System.Drawing.Point(3, 0);
            this.lblDeco.Name = "lblDeco";
            this.lblDeco.Size = new System.Drawing.Size(891, 70);
            this.lblDeco.TabIndex = 2;
            this.lblDeco.Text = "THE GAME IS ON!";
            this.lblDeco.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPl2
            // 
            this.lblPl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPl2.ForeColor = System.Drawing.Color.Purple;
            this.lblPl2.Location = new System.Drawing.Point(451, 70);
            this.lblPl2.Name = "lblPl2";
            this.lblPl2.Size = new System.Drawing.Size(443, 328);
            this.lblPl2.TabIndex = 6;
            this.lblPl2.Text = "0";
            this.lblPl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPl1
            // 
            this.lblPl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPl1.Location = new System.Drawing.Point(3, 70);
            this.lblPl1.Name = "lblPl1";
            this.lblPl1.Size = new System.Drawing.Size(442, 328);
            this.lblPl1.TabIndex = 8;
            this.lblPl1.Text = "0";
            this.lblPl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormPlayFFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 390);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormPlayFFS";
            this.Text = "FormPlayFFS";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPl2;
        private System.Windows.Forms.Label lblDeco;
        private System.Windows.Forms.Label lblPl1;

    }
}