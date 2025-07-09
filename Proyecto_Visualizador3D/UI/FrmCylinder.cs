using Proyecto_Visualizador3D.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Visualizador3D.UI
{
    public partial class FrmCylinder : Form
    {
        private IFigure3D figure;
        private FigureRenderer renderer;
        private HashSet<Keys> keysPressed = new HashSet<Keys>();
        private Timer keyTimer;


        public FrmCylinder()
        {
            InitializeComponent();
            figure = new Cylinder3D(radius: 100, height: 200, segments: 20);
            renderer = new FigureRenderer();
            picCanvas.BackColor = Color.FromArgb(30, 30, 30);
            cilindroToolStripMenuItem.ForeColor = Color.FromArgb(30, 30, 30);

            keyTimer = new Timer();
            keyTimer.Interval = 30; // 30 ms (~33 FPS)
            keyTimer.Tick += KeyTimer_Tick;
            keyTimer.Start();

        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            renderer.DrawFigure(e.Graphics, figure, picCanvas.ClientSize);
        }


        private void KeyTimer_Tick(object sender, EventArgs e)
        {
            bool changed = false;

            if (keysPressed.Contains(Keys.W)) { figure.OffsetY -= 5; changed = true; }
            if (keysPressed.Contains(Keys.S)) { figure.OffsetY += 5; changed = true; }
            if (keysPressed.Contains(Keys.A)) { figure.OffsetX -= 5; changed = true; }
            if (keysPressed.Contains(Keys.D)) { figure.OffsetX += 5; changed = true; }

            if (keysPressed.Contains(Keys.Oemplus) || keysPressed.Contains(Keys.Add))
            {
                figure.Zoom *= 1.02f;
                changed = true;
            }

            if (keysPressed.Contains(Keys.OemMinus) || keysPressed.Contains(Keys.Subtract))
            {
                figure.Zoom /= 1.02f;
                changed = true;
            }

            if (keysPressed.Contains(Keys.U)) { figure.AngleX += (float)(Math.PI / 180); changed = true; }
            if (keysPressed.Contains(Keys.J)) { figure.AngleX -= (float)(Math.PI / 180); changed = true; }
            if (keysPressed.Contains(Keys.I)) { figure.AngleY += (float)(Math.PI / 180); changed = true; }
            if (keysPressed.Contains(Keys.K)) { figure.AngleY -= (float)(Math.PI / 180); changed = true; }
            if (keysPressed.Contains(Keys.O)) { figure.AngleZ += (float)(Math.PI / 180); changed = true; }
            if (keysPressed.Contains(Keys.L)) { figure.AngleZ -= (float)(Math.PI / 180); changed = true; }

            if (changed)
            {
                picCanvas.Invalidate();
            }
        }



        private void FrmCylinder_KeyDown(object sender, KeyEventArgs e)
        {
         
            keysPressed.Add(e.KeyCode);
        }

        private void FrmCylinder_KeyUp(object sender, KeyEventArgs e)
        {
            keysPressed.Remove(e.KeyCode);
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmHome frm = new FrmHome())
            {
                frm.ShowDialog();
            }

            this.Close();
        }

        private void cuboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmCube frm = new FrmCube())
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
