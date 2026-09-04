using System;

namespace Area1Triangulo
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;
        public double p;

        public double AreaTriangulo()
        {
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            // return LadoA *LadoB;
        }
        public double SemiPerimetro()
        {
            return p = (A + B + C) / 2;
        }
    }
}
