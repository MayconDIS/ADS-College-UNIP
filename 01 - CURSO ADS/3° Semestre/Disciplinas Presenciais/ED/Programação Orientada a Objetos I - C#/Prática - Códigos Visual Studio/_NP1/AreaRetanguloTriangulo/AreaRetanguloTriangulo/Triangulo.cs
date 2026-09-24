using System;
using System.Collections.Generic;
using System.Text;

namespace AreaRetanguloTriangulo
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public void InformarValores()
        {
            Console.WriteLine("Informe o lado A do triângulo)");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o lado B do triângulo)");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o lado C do triângulo)");
            C = double.Parse(Console.ReadLine());
        }
        public void Exibir()
        {
            Console.WriteLine("A área do tritângulo é: " + AreaTriangulo());
            Console.WriteLine("O seu perímetro é: " + 2*SemiPerimetro());
        }
        public double AreaTriangulo()
        {
            double p = SemiPerimetro();
           // Console.WriteLine("Semi perímetro = " + p.ToString("F2"));
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
           
        }
        public double SemiPerimetro()
        {
             return   (A + B + C) / 2;
           
        }
    }
}
