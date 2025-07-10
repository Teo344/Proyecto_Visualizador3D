namespace Proyecto_Visualizador3D.UI
{
    partial class FrmCylinder
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cilindroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pirámideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esféaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnZoomOut = new System.Windows.Forms.PictureBox();
            this.btnZoomIn = new System.Windows.Forms.PictureBox();
            this.btnright = new System.Windows.Forms.PictureBox();
            this.btndown = new System.Windows.Forms.PictureBox();
            this.btnleft = new System.Windows.Forms.PictureBox();
            this.btnUp = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnZoomOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZoomIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.conoToolStripMenuItem,
            this.cilindroToolStripMenuItem,
            this.cuboToolStripMenuItem,
            this.pirámideToolStripMenuItem,
            this.esféaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 37);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(96, 33);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // conoToolStripMenuItem
            // 
            this.conoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.conoToolStripMenuItem.Name = "conoToolStripMenuItem";
            this.conoToolStripMenuItem.Size = new System.Drawing.Size(89, 33);
            this.conoToolStripMenuItem.Text = "Cono";
            this.conoToolStripMenuItem.Click += new System.EventHandler(this.conoToolStripMenuItem_Click);
            // 
            // cilindroToolStripMenuItem
            // 
            this.cilindroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.cilindroToolStripMenuItem.Name = "cilindroToolStripMenuItem";
            this.cilindroToolStripMenuItem.Size = new System.Drawing.Size(119, 33);
            this.cilindroToolStripMenuItem.Text = "Cilíndro";
            // 
            // cuboToolStripMenuItem
            // 
            this.cuboToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.cuboToolStripMenuItem.Name = "cuboToolStripMenuItem";
            this.cuboToolStripMenuItem.Size = new System.Drawing.Size(89, 33);
            this.cuboToolStripMenuItem.Text = "Cubo";
            this.cuboToolStripMenuItem.Click += new System.EventHandler(this.cuboToolStripMenuItem_Click);
            // 
            // pirámideToolStripMenuItem
            // 
            this.pirámideToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.pirámideToolStripMenuItem.Name = "pirámideToolStripMenuItem";
            this.pirámideToolStripMenuItem.Size = new System.Drawing.Size(132, 33);
            this.pirámideToolStripMenuItem.Text = "Pirámide";
            this.pirámideToolStripMenuItem.Click += new System.EventHandler(this.pirámideToolStripMenuItem_Click);
            // 
            // esféaToolStripMenuItem
            // 
            this.esféaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.esféaToolStripMenuItem.Name = "esféaToolStripMenuItem";
            this.esféaToolStripMenuItem.Size = new System.Drawing.Size(102, 33);
            this.esféaToolStripMenuItem.Text = "Esfera";
            this.esféaToolStripMenuItem.Click += new System.EventHandler(this.esféaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.btnZoomOut);
            this.panel1.Controls.Add(this.btnZoomIn);
            this.panel1.Controls.Add(this.btnright);
            this.panel1.Controls.Add(this.btndown);
            this.panel1.Controls.Add(this.btnleft);
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trackBarY);
            this.panel1.Controls.Add(this.trackBarZ);
            this.panel1.Controls.Add(this.trackBarX);
            this.panel1.Location = new System.Drawing.Point(1078, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 670);
            this.panel1.TabIndex = 5;
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomOut.Image = global::Proyecto_Visualizador3D.Properties.Resources.glass__1_;
            this.btnZoomOut.Location = new System.Drawing.Point(220, 271);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(93, 79);
            this.btnZoomOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnZoomOut.TabIndex = 27;
            this.btnZoomOut.TabStop = false;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomIn.Image = global::Proyecto_Visualizador3D.Properties.Resources.glass;
            this.btnZoomIn.Location = new System.Drawing.Point(46, 271);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(93, 79);
            this.btnZoomIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnZoomIn.TabIndex = 26;
            this.btnZoomIn.TabStop = false;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnright
            // 
            this.btnright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnright.Image = global::Proyecto_Visualizador3D.Properties.Resources.flecha_hacia_abajo__3_;
            this.btnright.Location = new System.Drawing.Point(204, 115);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(79, 77);
            this.btnright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnright.TabIndex = 25;
            this.btnright.TabStop = false;
            this.btnright.Click += new System.EventHandler(this.btnright_Click);
            // 
            // btndown
            // 
            this.btndown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndown.Image = global::Proyecto_Visualizador3D.Properties.Resources.flecha_hacia_abajo__4_;
            this.btndown.Location = new System.Drawing.Point(147, 172);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(79, 77);
            this.btndown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btndown.TabIndex = 24;
            this.btndown.TabStop = false;
            this.btndown.Click += new System.EventHandler(this.btndown_Click);
            // 
            // btnleft
            // 
            this.btnleft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnleft.Image = global::Proyecto_Visualizador3D.Properties.Resources.flecha_hacia_abajo__2_;
            this.btnleft.Location = new System.Drawing.Point(90, 115);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(79, 77);
            this.btnleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnleft.TabIndex = 23;
            this.btnleft.TabStop = false;
            this.btnleft.Click += new System.EventHandler(this.btnleft_Click);
            // 
            // btnUp
            // 
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.Image = global::Proyecto_Visualizador3D.Properties.Resources.flecha_hacia_abajo__1_;
            this.btnUp.Location = new System.Drawing.Point(147, 59);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(79, 77);
            this.btnUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUp.TabIndex = 22;
            this.btnUp.TabStop = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Rotación al costado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Rotación alrededor:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(16, 373);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(290, 29);
            this.lbl2.TabIndex = 19;
            this.lbl2.Text = "Rotación para adelante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(41, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Botones de movimiento:";
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(33, 505);
            this.trackBarY.Maximum = 360;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(279, 56);
            this.trackBarY.TabIndex = 16;
            this.trackBarY.Scroll += new System.EventHandler(this.trackBarY_Scroll);
            // 
            // trackBarZ
            // 
            this.trackBarZ.Location = new System.Drawing.Point(33, 600);
            this.trackBarZ.Maximum = 360;
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Size = new System.Drawing.Size(273, 56);
            this.trackBarZ.TabIndex = 15;
            this.trackBarZ.Scroll += new System.EventHandler(this.trackBarZ_Scroll);
            // 
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(33, 409);
            this.trackBarX.Maximum = 360;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(287, 56);
            this.trackBarX.TabIndex = 14;
            this.trackBarX.Scroll += new System.EventHandler(this.trackBarX_Scroll);
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(12, 49);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(1060, 670);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            // 
            // FrmCylinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picCanvas);
            this.KeyPreview = true;
            this.Name = "FrmCylinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCylinder";
            this.Load += new System.EventHandler(this.FrmCylinder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCylinder_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmCylinder_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnZoomOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZoomIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cilindroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pirámideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esféaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.TrackBar trackBarZ;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.PictureBox btnUp;
        private System.Windows.Forms.PictureBox btnright;
        private System.Windows.Forms.PictureBox btndown;
        private System.Windows.Forms.PictureBox btnleft;
        private System.Windows.Forms.PictureBox btnZoomIn;
        private System.Windows.Forms.PictureBox btnZoomOut;
    }
}