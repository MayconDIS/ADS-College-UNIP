using System;

namespace FiguraGeometricaProtected
{
    public class FiguraGeometrica
    {
        protected double A;
        protected double B;
        protected double C;
        protected double Raio;

        public void SetA(double a)
        {
            A = a;
        }
        public double GetA()
        {
            return A;
        }
        public void SetB(double b)
        {
            B = b;
        }
        public double GetB()
        {
            return B;
        }
        public void SetC(double c)
        {
            C = c;
        }
        public double GetC()
        {
            return C;
        }
        public void SetRaio(double raio)
        {
            Raio = raio;
        }
        public double GetRaio()
        {
            return Raio;
        }

    }
}
