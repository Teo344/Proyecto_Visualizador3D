using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Visualizador3D
{
    public static class Projection3D
    {
        /// <summary>
        /// Proyecta un punto 3D a 2D usando perspectiva simple.
        /// </summary>
        public static PointF Project(Point3D p, float zoom, float offsetX, float offsetY, Size clientSize)
        {
            float distance = 900; // Distancia de cámara
            float factor = distance / (distance - p.Z);

            float x = p.X * factor * zoom + clientSize.Width / 2 + offsetX;
            float y = -p.Y * factor * zoom + clientSize.Height / 2 + offsetY;

            return new PointF(x, y);
        }
    }
}
