using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    internal class Automovel : Veiculo
    {
        private int _portas;
        private string _chassi;
        private string _placa;
        private int _anoFab;

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
			Console.WriteLine("Modelo: " + Modelo);
			Console.WriteLine("Velocidade: " + velocidade);
			Console.WriteLine("Passageiro: " + passageiro);
			Console.WriteLine("Combustivel: " + combustivel);
		}
    }
}
