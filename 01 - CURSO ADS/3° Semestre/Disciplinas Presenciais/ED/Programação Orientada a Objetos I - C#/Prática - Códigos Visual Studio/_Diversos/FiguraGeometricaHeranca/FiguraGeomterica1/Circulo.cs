using System;

namespace FiguraGeometrica1
{
    class Circulo: FiguraGeometrica
    {
        public double CalculaArea()
        {
            return Math.PI * GetRaio() * GetRaio();
        }
    }
}
