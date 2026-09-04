using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    internal class Veiculo
    {
        protected string modelo;
        protected double velocidade;
        protected int passageiro;
        protected string combustivel;
        public string Modelo
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
        public void Exibir()
        {
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Velocidade: " + velocidade);
            Console.WriteLine("Passageiro: " + passageiro);
            Console.WriteLine("Combustivel: " + combustivel);
        }
    }
}
