using System;


namespace FiguraGeometricaProtected
{
    class Triangulo : FiguraGeometrica
    {
        public double CalculaArea()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }

}
