using System;
using static System.Console;
namespace EncapsulamentoPrivado
{
    class Quadrado: Retangulo
    {
        public double GetArea()
        {

            return _comprimento * _comprimento;
        }
        //public override void InformarValores()
        public override void InformarValores()
        {
            WriteLine("Informe o comprimento: ");
            _comprimento = double.Parse(Console.ReadLine());
        } 
        public override void Exibir()
        {
            WriteLine("Área do Quadrado\n");
            // WriteLine($"Comprimento: {_comprimento}");
            Console.WriteLine("Comprimento: " + _comprimento);
             WriteLine($"Area: {GetArea()}");
        }
    }
}