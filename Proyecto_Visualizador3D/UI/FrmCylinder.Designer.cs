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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.btnright = new System.Windows.Forms.Button();
            this.btndown = new System.Windows.Forms.Button();
            this.btnleft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cilindroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pirámideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esféaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnZoomOut);
            this.panel1.Controls.Add(this.btnZoomIn);
            this.panel1.Controls.Add(this.trackBarY);
            this.panel1.Controls.Add(this.trackBarZ);
            this.panel1.Controls.Add(this.trackBarX);
            this.panel1.Controls.Add(this.btnright);
            this.panel1.Controls.Add(this.btndown);
            this.panel1.Controls.Add(this.btnleft);
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(476, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 548);
            this.panel1.TabIndex = 2;
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnZoomOut.Location = new System.Drawing.Point(173, 249);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(61, 43);
            this.btnZoomOut.TabIndex = 29;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnZoomIn.Location = new System.Drawing.Point(60, 249);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(61, 43);
            this.btnZoomIn.TabIndex = 28;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(23, 399);
            this.trackBarY.Maximum = 360;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(249, 56);
            this.trackBarY.TabIndex = 27;
            this.trackBarY.Scroll += new System.EventHandler(this.trackBarY_Scroll);
            // 
            // trackBarZ
            // 
            this.trackBarZ.Location = new System.Drawing.Point(23, 471);
            this.trackBarZ.Maximum = 360;
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Size = new System.Drawing.Size(249, 56);
            this.trackBarZ.TabIndex = 26;
            this.trackBarZ.Scroll += new System.EventHandler(this.trackBarZ_Scroll);
            // 
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(23, 324);
            this.trackBarX.Maximum = 360;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(249, 56);
            this.trackBarX.TabIndex = 25;
            this.trackBarX.Scroll += new System.EventHandler(this.trackBarX_Scroll);
            // 
            // btnright
            // 
            this.btnright.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnright.Location = new System.Drawing.Point(182, 123);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(61, 46);
            this.btnright.TabIndex = 23;
            this.btnright.Text = "→";
            this.btnright.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnright.UseVisualStyleBackColor = true;
            this.btnright.Click += new System.EventHandler(this.btnright_Click);
            // 
            // btndown
            // 
            this.btndown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndown.Location = new System.Drawing.Point(114, 183);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(61, 46);
            this.btndown.TabIndex = 22;
            this.btndown.Text = "↓";
            this.btndown.UseVisualStyleBackColor = true;
            this.btndown.Click += new System.EventHandler(this.btndown_Click);
            // 
            // btnleft
            // 
            this.btnleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnleft.Location = new System.Drawing.Point(45, 123);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(61, 46);
            this.btnleft.TabIndex = 21;
            this.btnleft.Text = "←";
            this.btnleft.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnleft.UseVisualStyleBackColor = true;
            this.btnleft.Click += new System.EventHandler(this.btnleft_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(113, 63);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(61, 46);
            this.btnUp.TabIndex = 20;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(112, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 62);
            this.panel2.TabIndex = 19;
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(12, 43);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(458, 548);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
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
            this.menuStrip1.Size = new System.Drawing.Size(782, 37);
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
            this.esféaToolStripMenuItem.Text = "Esféra";
            this.esféaToolStripMenuItem.Click += new System.EventHandler(this.esféaToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Botones de movimiento:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(32, 299);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(198, 22);
            this.lbl2.TabIndex = 30;
            this.lbl2.Text = "Rotación para adelante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Rotación alrededor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Rotación al costado:";
            // 
            // FrmCylinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmCylinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCylinder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.TrackBar trackBarZ;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Button btndown;
        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cilindroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pirámideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esféaToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}