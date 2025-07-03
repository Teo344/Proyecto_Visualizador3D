using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Visualizador3D.Dominio
{
    public class Pyramid3D : BaseFigure3D
    {
        public Pyramid3D(float baseSize, float height)
        {
            // Lista de puntos
            Vertices = new Point3D[]
            {
            // Base cuadrada
            new Point3D(-baseSize / 2, -height / 2, -baseSize / 2),
            new Point3D( baseSize / 2, -height / 2, -baseSize / 2),
            new Point3D( baseSize / 2, -height / 2,  baseSize / 2),
            new Point3D(-baseSize / 2, -height / 2,  baseSize / 2),
            // Punta superior
            new Point3D(0, height / 2, 0)
            };

            // Aristas
            Edges = new int[,]
            {
            // Base cuadrada
            {0,1}, {1,2}, {2,3}, {3,0},
            // Laterales
            {0,4}, {1,4}, {2,4}, {3,4}
            };
        }
    }

}
