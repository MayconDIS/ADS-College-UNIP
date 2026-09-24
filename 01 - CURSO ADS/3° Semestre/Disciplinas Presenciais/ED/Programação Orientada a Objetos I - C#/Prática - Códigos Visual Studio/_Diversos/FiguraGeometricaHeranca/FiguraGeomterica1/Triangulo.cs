using System;


namespace FiguraGeometrica1 
{
    class Triangulo: FiguraGeometrica
    {

          public  double CalculaArea()
        {
            double p = (GetA() + GetB() + GetC()) / 2.0;
            return Math.Sqrt(p * (p - GetA()) * (p - GetB()) * (p - GetC()));
        }
    }
}
