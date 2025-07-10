using Proyecto_Visualizador3D.Dominio;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            keyTimer.Interval = 30;
            keyTimer.Tick += KeyTimer_Tick;
            keyTimer.Start();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            DrawGrid(g, picCanvas.ClientSize); // Dibuja cuadrícula 3D sincronizada

            renderer.DrawFigure(g, figure, picCanvas.ClientSize); // Dibuja cilindro encima
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
                picCanvas.Invalidate();
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
            using (FrmCone frm = new FrmCone()) frm.ShowDialog();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmHome frm = new FrmHome()) frm.ShowDialog();
            this.Close();
        }

        private void cuboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmCube frm = new FrmCube()) frm.ShowDialog();
            this.Close();
        }

        private void pirámideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmPyramid frm = new FrmPyramid()) frm.ShowDialog();
            this.Close();
        }

        private void esféaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmSphere frm = new FrmSphere()) frm.ShowDialog();
            this.Close();
        }

        // -------------------------------
        // Cuadrícula sincronizada con figura
        // -------------------------------
        private void DrawGrid(Graphics g, Size canvasSize, int spacing = 25, int range = 10)
        {
            Pen gridPen = new Pen(Color.FromArgb(50, 180, 180, 180)); // Gris claro

            List<Line3D> gridLines = new List<Line3D>();

            for (int i = -range; i <= range; i++)
            {
                // Paralelas al eje Z
                gridLines.Add(new Line3D(
                    new Point3D(i * spacing, 0, -range * spacing),
                    new Point3D(i * spacing, 0, range * spacing)
                ));

                // Paralelas al eje X
                gridLines.Add(new Line3D(
                    new Point3D(-range * spacing, 0, i * spacing),
                    new Point3D(range * spacing, 0, i * spacing)
                ));
            }

            foreach (var line in gridLines)
            {
                PointF p1 = Project3D(line.Start, figure);
                PointF p2 = Project3D(line.End, figure);
                g.DrawLine(gridPen, p1, p2);
            }

            gridPen.Dispose();
        }

        private PointF Project3D(Point3D point, IFigure3D fig)
        {
            float x = point.X;
            float y = point.Y;
            float z = point.Z;

            // Rotaciones
            float cosX = (float)Math.Cos(fig.AngleX);
            float sinX = (float)Math.Sin(fig.AngleX);
            float cosY = (float)Math.Cos(fig.AngleY);
            float sinY = (float)Math.Sin(fig.AngleY);
            float cosZ = (float)Math.Cos(fig.AngleZ);
            float sinZ = (float)Math.Sin(fig.AngleZ);

            float y1 = y * cosX - z * sinX;
            float z1 = y * sinX + z * cosX;

            float x2 = x * cosY + z1 * sinY;
            float z2 = -x * sinY + z1 * cosY;

            float x3 = x2 * cosZ - y1 * sinZ;
            float y3 = x2 * sinZ + y1 * cosZ;

            x3 *= fig.Zoom;
            y3 *= fig.Zoom;

            float screenX = picCanvas.Width / 2 + x3 + fig.OffsetX;
            float screenY = picCanvas.Height / 2 - y3 + fig.OffsetY;

            return new PointF(screenX, screenY);
        }
    }

    public class Line3D
    {
        public Point3D Start, End;
        public Line3D(Point3D start, Point3D end)
        {
            Start = start;
            End = end;
        }
    }
}
