using System;
using static System.Console;
namespace EncapsulamentoPrivado
{
    class Retangulo
    {
        private double _comprimento;
        private double _largura;

        public double GetArea()
        {
            return _comprimento * _largura;
        }
        /*
        public void SetComprimento(double Comprimento)
        {
            _comprimento = Comprimento;
        }
        public void SetLargura(double Largura)
        {
            _largura = Largura;
        }
        */
        public virtual void InformarValores()
        {
            WriteLine("Informe o comprimento: ");
            _comprimento = double.Parse(Console.ReadLine());
            WriteLine("Informe a largura : ");
            _largura = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void Exibir()
        {
            WriteLine("Área do Retângulo\n");
           // WriteLine($"Comprimento: {_comprimento}");
            Console.WriteLine("Comprimento: " + _comprimento);
            WriteLine($"Largura: {_largura}");
            WriteLine($"Area: {GetArea()}");
        }
    }
}
