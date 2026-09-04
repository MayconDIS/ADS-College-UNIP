using System;
using static System.Console;

namespace EncapsulamentoPublico
{
    class Retangulo
    {
        public double Comprimento;
        private double _largura;
      //  public double Largura { get; private set; } // auto properties

        public Retangulo(double c, double l) //construtor
        {
            Comprimento = c;
            _largura = l;
        }

        public double GetArea()
        {
            return Comprimento * _largura;
        }
        public void Exibir()
        {
            WriteLine("Área do Retângulo de ");
            WriteLine($"Comprimento: {Comprimento}");
            WriteLine($"Largura: {_largura}");
            WriteLine($"Area: {GetArea()}");
        }
    }
}
