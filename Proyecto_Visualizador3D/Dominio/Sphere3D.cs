using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Visualizador3D
{
    public class Sphere3D : BaseFigure3D
    {
        public Sphere3D(float radius, int segmentsLat = 20, int segmentsLon = 20)
        {
            List<Point3D> points = new List<Point3D>();
            List<(int, int)> edgeList = new List<(int, int)>();

            for (int i = 0; i <= segmentsLat; i++)
            {
                double theta = Math.PI * i / segmentsLat;
                for (int j = 0; j <= segmentsLon; j++)
                {
                    double phi = 2 * Math.PI * j / segmentsLon;

                    float x = radius * (float)(Math.Sin(theta) * Math.Cos(phi));
                    float y = radius * (float)(Math.Cos(theta));
                    float z = radius * (float)(Math.Sin(theta) * Math.Sin(phi));

                    points.Add(new Point3D(x, y, z));
                }
            }

            for (int i = 0; i < segmentsLat; i++)
            {
                for (int j = 0; j < segmentsLon; j++)
                {
                    int current = i * (segmentsLon + 1) + j;
                    int nextLon = current + 1;
                    int nextLat = current + (segmentsLon + 1);

                    if (j < segmentsLon)
                        edgeList.Add((current, nextLon));
                    if (i < segmentsLat)
                        edgeList.Add((current, nextLat));
                }
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
