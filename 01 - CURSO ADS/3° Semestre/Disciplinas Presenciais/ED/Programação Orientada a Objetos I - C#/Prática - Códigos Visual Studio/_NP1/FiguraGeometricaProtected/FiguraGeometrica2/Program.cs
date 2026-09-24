using System;
using System.Globalization;

namespace FiguraGeometricaProtected
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x;
            Retangulo y;
            Circulo z;
            Quadrado q;
            x = new Triangulo();
            y = new Retangulo();
            z = new Circulo();
            q = new Quadrado();

            //########## TRIÂNGULO #######
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.SetA(double.Parse(Console.ReadLine()));
            x.SetB(double.Parse(Console.ReadLine()));
            x.SetC(double.Parse(Console.ReadLine()));
            double areaX = x.CalculaArea();
            Console.WriteLine("Área de X = " + areaX.ToString("F4"));

            //########## RETÂNGULO #######
            Console.WriteLine("Entre com as medidas do retângulo Y:");
            y.SetA(double.Parse(Console.ReadLine()));
            y.SetB(double.Parse(Console.ReadLine()));
            double areaY = y.CalculaArea();
            Console.WriteLine("Área de Y = " + areaY.ToString("F4"));

            //########## Quadrado #######
            Console.WriteLine("Entre com as medidas do quadrado Y:");
            // q.A = double.Parse(Console.ReadLine());
            //  y.B = double.Parse(Console.ReadLine());
            q.InformarValores();
            double areaQ = q.CalculaArea();
            Console.WriteLine("Área de Q = " + areaQ.ToString("F4"));

            //########## CÍRCULO #######
            Console.WriteLine("Entre com o raio do círculo Z:");
            z.SetRaio(double.Parse(Console.ReadLine()));
            double areaZ = z.CalculaArea();
            Console.WriteLine("Área de Z = " + areaZ.ToString("F4"));
            Console.WriteLine();

            //########## VERIFICA A MAIOR ÁREA #######
            if ((areaX > areaY) && (areaX > areaZ))
            {
                Console.WriteLine("Maior área: X");
            }
            else if (areaY > areaZ)
            {
                Console.WriteLine("Maior área: Y");
            }
            else
            {
                Console.WriteLine("Maior área: Z");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para sair...");
            Console.ReadKey();
        }
    }
}
