using System;
using static System.Console;

namespace EncapsulamentoPrivado
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            r.InformarValores();
           /* WriteLine("Informe o comprimento: ");
            r.SetComprimento (double.Parse(Console.ReadLine()));
            WriteLine("Informe a largura : ");
            r.SetLargura (Convert.ToDouble(Console.ReadLine()));*/
            r.Exibir();

             Quadrado q = new Quadrado();
            q.InformarValores();
            q.Exibir();
            ReadLine();
        }
    }
}
