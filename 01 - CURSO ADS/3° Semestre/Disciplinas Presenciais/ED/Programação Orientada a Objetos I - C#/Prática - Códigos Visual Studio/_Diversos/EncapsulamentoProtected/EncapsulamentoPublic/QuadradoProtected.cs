using System;
using static System.Console;

namespace EncapsulamentoProtected
{
    class Quadrado : Retangulo
    {
        public double GetArea()
        {
            return _comprimento * _comprimento;
        }
        public void Exibir()        {
            
            Write("Área do Quadrado:\n");
            WriteLine($"Comprimento: {_comprimento}");
            WriteLine($"Area: {GetArea()}");
        }
        public void InformarValores()
        {
            WriteLine("\n##################\n");
            WriteLine("Informe o lado do quadrado: ");
            _comprimento = double.Parse(Console.ReadLine());
        }
    }
}
