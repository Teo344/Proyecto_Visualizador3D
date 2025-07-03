using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Visualizador3D.Dominio
{
    public class Cylinder3D : BaseFigure3D
    {
        public Cylinder3D(float radius, float height, int segments = 20)
        {
            List<Point3D> points = new List<Point3D>();
            List<(int, int)> edgeList = new List<(int, int)>();

            // Base inferior y superior
            for (int i = 0; i < segments; i++)
            {
                double angle = 2 * Math.PI * i / segments;

                float x = radius * (float)Math.Cos(angle);
                float z = radius * (float)Math.Sin(angle);

                // Inferior (Y negativa)
                points.Add(new Point3D(x, -height / 2f, z));

                // Superior (Y positiva)
                points.Add(new Point3D(x, height / 2f, z));
            }

            // Aristas
            for (int i = 0; i < segments; i++)
            {
                int next = (i + 1) % segments;

                int lowerCurr = i * 2;
                int upperCurr = i * 2 + 1;
                int lowerNext = next * 2;
                int upperNext = next * 2 + 1;

                // Base inferior
                edgeList.Add((lowerCurr, lowerNext));
                // Base superior
                edgeList.Add((upperCurr, upperNext));
                // Verticales
                edgeList.Add((lowerCurr, upperCurr));
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
