using System;


namespace Veiculo
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Automóveis");
            Automovel v = new Automovel();
            Aeronave a = new Aeronave();
            //######Automovel#######
            v.Modelo = "BMW";
            v.Velocidade = 250;
            v.Passageiro = 4;
            v.Combustivel = "flex";
            v.Portas= 4;
            v.Chassi = "XDM35M34M234";
            v.Placa = "BMW1D0"; 
            v.AnoFab = 2020;
            v.Exibir();
            v.ExibirAutomovel();
            Console.WriteLine("##########FimAutomovel##############");
            //######Aeronave#######
            a.Modelo = "Bandeirantes";
            a.Velocidade = 400;
            a.Passageiro = 20;
            a.Combustivel = "Querosene";
            a.Matricula = "FAB2133";
            a.Tipo = "Turbo Hélice";
            a.Uso = "Comercial";
            a.Exibir();
            a.ExibirAeronave();
            Console.WriteLine("##########FimAeronave##############");



        }
    }

}

