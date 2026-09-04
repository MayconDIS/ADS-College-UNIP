using System;

namespace FiguraGeometrica2
{
    class Circulo: FiguraGeometrica
    {
        public double CalculaArea()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
