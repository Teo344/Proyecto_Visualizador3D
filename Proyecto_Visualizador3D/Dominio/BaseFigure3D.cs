using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Visualizador3D
{
    public abstract class BaseFigure3D : IFigure3D
    {
        protected Point3D[] Vertices;
        protected int[,] Edges;

        public float AngleX { get; set; }
        public float AngleY { get; set; }
        public float AngleZ { get; set; }
        public float Zoom { get; set; } = 1.0f;
        public float OffsetX { get; set; }
        public float OffsetY { get; set; }

        public int[,] GetEdges() => Edges;

        public Point3D[] GetTransformedVertices()
        {
            Point3D[] transformed = new Point3D[Vertices.Length];
            for (int i = 0; i < Vertices.Length; i++)
            {
                transformed[i] = TransformPoint(Vertices[i]);
            }
            return transformed;
        }

        private Point3D TransformPoint(Point3D p)
        {
            // Rotar X
            float cosX = (float)Math.Cos(AngleX);
            float sinX = (float)Math.Sin(AngleX);
            float y1 = p.Y * cosX - p.Z * sinX;
            float z1 = p.Y * sinX + p.Z * cosX;

            // Rotar Y
            float cosY = (float)Math.Cos(AngleY);
            float sinY = (float)Math.Sin(AngleY);
            float x2 = p.X * cosY + z1 * sinY;
            float z2 = -p.X * sinY + z1 * cosY;

            // Rotar Z
            float cosZ = (float)Math.Cos(AngleZ);
            float sinZ = (float)Math.Sin(AngleZ);
            float x3 = x2 * cosZ - y1 * sinZ;
            float y3 = x2 * sinZ + y1 * cosZ;

            return new Point3D(x3, y3, z2);
        }
    }
   }
