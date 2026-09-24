using System;
namespace Veiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Automóveis");
            Veiculo v2 = new Veiculo(); 
            Veiculo v3 = new Veiculo("Fusca",80.0,4,"Gasolina");
            Veiculo v4 = new Veiculo("Uno", 100.0, 4, "Acool");
            v2.Exibir(); 
            v3.Exibir();
            v4.Exibir();
            //######Automovel V2#######

            Aeronave a = new Aeronave();
            Automovel v = new Automovel();
            VeiculoAutoproperty vA4 = new VeiculoAutoproperty();
            vA4.Modelo = "Ferrari";
            vA4.Velocidade = 350.2;
            vA4.Passageiro = 2;
            vA4.Combustivel = "Gasolina";
            Console.WriteLine("Modelo = "+v4.Modelo);
            v4.Exibir();
            //######Automovel#######
            v.Modelo = "BMW";
            v.Velocidade = 250.2;
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

