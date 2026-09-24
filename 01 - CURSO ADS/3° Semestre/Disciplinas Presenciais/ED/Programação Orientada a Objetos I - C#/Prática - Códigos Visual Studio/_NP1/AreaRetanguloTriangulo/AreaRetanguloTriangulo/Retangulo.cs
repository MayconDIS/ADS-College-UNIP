using System;
using System.Collections.Generic;
using System.Text;

namespace AreaRetanguloTriangulo
{
    internal class Retangulo
    {
        public double A;
        public double B;
        public void InformarValores()
        {
            Console.WriteLine("Informe o comprimento do retângulo)");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a largura do retângulo)");
            B = double.Parse(Console.ReadLine());
        }
        public void Exibir()
        {
            Console.WriteLine("A área do retângulo é: " + AreaRetangulo());
            Console.WriteLine("O seu perímetro é: " + SemiPerimetro());
        }
        public double AreaRetangulo()
        {
            return A * B;
        }
        public double SemiPerimetro()
        {
            return (2 * (A + B));
        }
    }
}
