using System;
namespace Veiculo
{
    internal class Automovel
    {
        public string modelo;
        public double velocidade;
        public int passageiro;
        public string combustivel;
        private int _portas;
        private string _chassi;
        private string _placa;
        private int _anoFab;
        public string Modelo // properties
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public double Velocidade
        {
            get { return velocidade; }
            set { velocidade = value; }
        }
        public int Passageiro
        {
            get { return passageiro; }
            set { passageiro = value; }
        }
        public string Combustivel
        {
            get { return combustivel; }
            set { combustivel = value; }
        }
        public int Portas
        {
            get { return _portas; }
            set { _portas = value; }
        }
        public string Chassi
        {
            get { return _chassi; }
            set { _chassi = value; }
        }
        public string Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }
        public int AnoFab
        {
            get { return _anoFab; }
            set { _anoFab = value; }
        }
        public void ExibirAutomovel()
        {
            Console.WriteLine("Porta: " + _portas);
            Console.WriteLine("Chassi: " + _chassi);
            Console.WriteLine("Placa: " + _placa);
            Console.WriteLine("Ano de Fabricação: " + _anoFab);
        }
        public void Exibir()
        {
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Velocidade: " + velocidade);
            Console.WriteLine("Passageiro: " + passageiro);
            Console.WriteLine("Combustivel: " + combustivel);
        }
    }
}
