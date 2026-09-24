using System;
using System.Collections.Generic;
namespace FiguraGeometricaAbstrata.Referencies{
    public class Quadrado : FormaGeometrica
    {
        private double lado;

        public double Lado
        {
            get  { return lado; }
            set  { lado = value; }
        }
        public override void CalcularArea()
        {
            this.Area = lado * lado;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = 4 * lado;
        }
    }

}

