using System;

namespace FiguraGeometrica1
{
  public class FiguraGeometrica
    {
        private double A;
        private double B;
        private double C;
        private double Raio;

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