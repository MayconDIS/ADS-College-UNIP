using System;

namespace FiguraGeometrica3
{
    public class FiguraGeometrica
    {
        private double _a;
        private double _b;
        private double _c;
        private double _raio;

        public double A
        {
            get { return _a; }
            set { _a = value; }
        }
        public double B
        {
            get { return _b; }
            set { _b = value; }
        }
        public double C
        {
            get { return _c; }
            set { _c = value; }
        }
        public double Raio
        {
            get { return _raio; }
            set { _raio = value; }
        }
    }
}
