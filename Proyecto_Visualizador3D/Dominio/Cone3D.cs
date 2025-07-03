using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Visualizador3D.Dominio
{
    public class Cone3D : BaseFigure3D
    {
        public Cone3D(float radius, float height, int segments = 20)
        {
            List<Point3D> points = new List<Point3D>();
            List<(int, int)> edgeList = new List<(int, int)>();

            // Base circular
            for (int i = 0; i < segments; i++)
            {
                double angle = 2 * Math.PI * i / segments;
                float x = radius * (float)Math.Cos(angle);
                float y = -height / 2f; // base en Y negativa
                float z = radius * (float)Math.Sin(angle);
                points.Add(new Point3D(x, y, z));
            }

            // Punta del cono
            Point3D apex = new Point3D(0, height / 2f, 0);
            points.Add(apex);
            int apexIndex = points.Count - 1;

            // Aristas de la base
            for (int i = 0; i < segments; i++)
            {
                int next = (i + 1) % segments;
                edgeList.Add((i, next));        // borde de la base
                edgeList.Add((i, apexIndex));   // arista hacia la punta
            }

            Vertices = points.ToArray();
            Edges = new int[edgeList.Count, 2];
            for (int k = 0; k < edgeList.Count; k++)
            {
                Edges[k, 0] = edgeList[k].Item1;
                Edges[k, 1] = edgeList[k].Item2;
            }
        }
    }
}
