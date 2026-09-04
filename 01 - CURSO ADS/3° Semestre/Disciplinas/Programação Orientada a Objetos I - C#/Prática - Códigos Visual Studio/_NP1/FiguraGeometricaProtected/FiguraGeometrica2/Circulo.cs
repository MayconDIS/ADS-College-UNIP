using System;

namespace FiguraGeometricaProtected
{
    class Circulo: FiguraGeometrica    {
        public double CalculaArea()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
