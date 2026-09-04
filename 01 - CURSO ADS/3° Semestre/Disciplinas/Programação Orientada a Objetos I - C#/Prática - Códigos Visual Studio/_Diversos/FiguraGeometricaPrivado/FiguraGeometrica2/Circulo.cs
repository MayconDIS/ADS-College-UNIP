using System;

namespace FiguraGeometricaPrivado
{
    class Circulo: FiguraGeometrica
    {
        public double CalculaArea()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
