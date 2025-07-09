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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cilindroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pirámideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esféaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(12, 90);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(758, 501);
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
            // FrmCylinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picCanvas);
            this.KeyPreview = true;
            this.Name = "FrmCylinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCylinder";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCylinder_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmCylinder_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}