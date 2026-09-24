using System;
using System.Reflection;

namespace Veiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Automóveis");
            Automovel v = new Automovel();
            //######Automovel#######
            v.modelo = "BMW";
            v.velocidade = 250;
            v.passageiro = 4;
            v.combustivel = "flex";
            v.Portas= 4;
            v.Chassi = "XDM35M34M234";
            v.Placa = "BMW1D0"; 
            v.AnoFab = 2020;
            v.Exibir();
            v.ExibirAutomovel();
            Console.WriteLine("##########FimAutomovel##############");
            Console.WriteLine("\n\n##########Entrada de dados para veíiculo##############");
            Console.WriteLine("Entre com o nome do modelo");
            v.modelo = Console.ReadLine();
            Console.WriteLine("Entre com a velocidade: ");
            v.velocidade = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o número de passageiros: ");
            v.passageiro = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o tipo de combustível: ");
            v.combustivel = Console.ReadLine(); ;
            Console.WriteLine("Entre com o número de portas: ");
            v.Portas = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o número do chassi: ");
            v.Chassi = Console.ReadLine();
            Console.WriteLine("Entre com a identificação da placa: ");
            v.Placa = Console.ReadLine();
            Console.WriteLine("Entre com o ano de fabricação");
            v.AnoFab = int.Parse(Console.ReadLine());
            v.Exibir();
            v.ExibirAutomovel();
            Console.WriteLine("Modelo: " + v.modelo);
            Console.WriteLine("Velocidade: " + v.velocidade);
            Console.WriteLine("Passageiro: " + v.passageiro);
            Console.WriteLine("Combustivel: " + v.combustivel);

            Console.WriteLine("Porta: " + v.Portas);
            Console.WriteLine("Chassi: " + v.Chassi);
            Console.WriteLine("Placa: " + v.Placa);
            Console.WriteLine("Ano de Fabricação: " + v.AnoFab);

        }
    }

}