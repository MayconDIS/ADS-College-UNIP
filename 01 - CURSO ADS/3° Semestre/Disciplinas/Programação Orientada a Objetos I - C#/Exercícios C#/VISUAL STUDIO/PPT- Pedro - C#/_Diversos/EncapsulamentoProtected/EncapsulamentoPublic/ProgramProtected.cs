using System;
using static System.Console;
namespace EncapsulamentoProtected
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Retangulo();
            var q = new Quadrado();
           // r._comprimento = double.Parse(Console.ReadLine());
            r.InformarValores();
            r.Exibir();
            q.InformarValores();
            q.Exibir();
            ReadLine();
        }
    }
}
