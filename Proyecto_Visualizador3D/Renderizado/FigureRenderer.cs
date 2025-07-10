using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Visualizador3D
{
    public class FigureRenderer
    {
        public void DrawFigure(Graphics g, IFigure3D figure, Size areaSize)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Point3D[] transformed = figure.GetTransformedVertices();
            int[,] edges = figure.GetEdges();

            PointF[] projected = new PointF[transformed.Length];
            for (int i = 0; i < transformed.Length; i++)
            {
                projected[i] = Projection3D.Project(
                    transformed[i],
                    figure.Zoom,
                    figure.OffsetX,
                    figure.OffsetY,
                    areaSize);
            }

            Pen pen = Pens.Red;
            for (int i = 0; i < edges.GetLength(0); i++)
            {
                PointF p1 = projected[edges[i, 0]];
                PointF p2 = projected[edges[i, 1]];
                g.DrawLine(pen, p1, p2);
            }
        }
    }
}
