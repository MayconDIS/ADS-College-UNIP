using System;

using static System.Console;

namespace FiguraGeometrica1
{
    class Quadrado : Retangulo
    {

        public void InformarValores()
        {
            WriteLine("\nInforme o comprimento do quadrado: ");
            SetA(double.Parse(Console.ReadLine()));
            double b = GetA();
            SetB(b);

            CalculaArea();
        }
    }
}