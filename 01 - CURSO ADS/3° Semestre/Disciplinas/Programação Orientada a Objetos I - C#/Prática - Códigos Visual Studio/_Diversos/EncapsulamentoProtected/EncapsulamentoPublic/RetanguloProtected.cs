using static System.Console;
using System;
namespace EncapsulamentoProtected
{
    class Retangulo
    {
        protected double _comprimento;
        private double _largura;

        public double GetArea()
        {
            return _comprimento * _largura;
        }
        public void Exibir()
        {
            Write("Área do Retângulo\n");
            WriteLine($"Comprimento: {_comprimento}");
            WriteLine($"Largura: {_largura}");
            WriteLine($"Area: {GetArea()}");
        }
        public void InformarValores()
        {
            WriteLine("\nInforme o comprimento: ");
            _comprimento = double.Parse(Console.ReadLine());
            WriteLine("Informe a largura : ");
            _largura = Convert.ToDouble(Console.ReadLine());
        }
    }
}
