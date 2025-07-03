using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Visualizador3D
{
    public interface IFigure3D
    {
        Point3D[] GetTransformedVertices();
        int[,] GetEdges();

        // Propiedades de transformación
        float AngleX { get; set; }
        float AngleY { get; set; }
        float AngleZ { get; set; }
        float Zoom { get; set; }
        float OffsetX { get; set; }
        float OffsetY { get; set; }
    }

}
