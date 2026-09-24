using System;

namespace FiguraGeometrica1
{
    class Retangulo: FiguraGeometrica
    {
        public double CalculaArea()
        {
            return GetA() * GetB();
        }
    }
}
