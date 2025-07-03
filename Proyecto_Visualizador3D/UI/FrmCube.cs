using Proyecto_Visualizador3D.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Visualizador3D
{
    public partial class FrmCube : Form
    {

        private IFigure3D figure;
        private FigureRenderer renderer;
        public FrmCube()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            // Ejemplo: usa un cubo inicialmente
            figure = new Cube3D(100);
            renderer = new FigureRenderer();
            picCanvas.BackColor = Color.FromArgb(30, 30, 30);
            cuboToolStripMenuItem.ForeColor = Color.FromArgb(30, 30, 30);
        }



        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            renderer.DrawFigure(e.Graphics, figure, picCanvas.ClientSize);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            figure.OffsetY -= 10;
            picCanvas.Invalidate();
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            figure.OffsetY += 10;
            picCanvas.Invalidate();
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            figure.OffsetX -= 10;
            picCanvas.Invalidate();
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            figure.OffsetX += 10;
            picCanvas.Invalidate();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            figure.Zoom *= 1.1f;
            picCanvas.Invalidate();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            figure.Zoom /= 1.1f;
            picCanvas.Invalidate();
        }

        private float DegreesToRadians(int degrees)
        {
            return (float)(Math.PI * degrees / 180.0);
        }

        private void trackBarX_Scroll(object sender, EventArgs e)
        {
            figure.AngleX = DegreesToRadians(trackBarX.Value);
            picCanvas.Invalidate();
        }

        private void trackBarY_Scroll(object sender, EventArgs e)
        {
            figure.AngleY = DegreesToRadians(trackBarY.Value);
            picCanvas.Invalidate();
        }

        private void trackBarZ_Scroll(object sender, EventArgs e)
        {
            figure.AngleZ = DegreesToRadians(trackBarZ.Value);
            picCanvas.Invalidate();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmHome frm = new FrmHome())
            {
                frm.ShowDialog();
            }

            this.Close();
        }

        private void conoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmCone frm = new FrmCone())
            {
                frm.ShowDialog();
            }

            this.Close();
        }

        private void cilindroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmCylinder frm = new FrmCylinder())
            {
                frm.ShowDialog();
            }

            this.Close();
        }

        private void pirámideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmPyramid frm = new FrmPyramid())
            {
                frm.ShowDialog();
            }

            this.Close();
        }

        private void esféaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmSphere frm = new FrmSphere())
            {
                frm.ShowDialog();
            }

            this.Close();
        }
    }
}
