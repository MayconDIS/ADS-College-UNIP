using System;
using static System.Console;

namespace FiguraGeometricaPrivado
{
    class Quadrado : Retangulo
    {
        public void InformarValores()
        {
            WriteLine("\nInforme o comprimento do quadrado: ");
            A = double.Parse(Console.ReadLine());
            B = A;          
            CalculaArea();
        }
      /*  public void Exibir()
        {
            Write("Área do Quadrado de ");
            // WriteLine($"Comprimento: {LadoA}");
            Console.WriteLine("comprimento: " + LadoA);
            WriteLine($"Area: {GetArea()}");
        }*/
    }
}