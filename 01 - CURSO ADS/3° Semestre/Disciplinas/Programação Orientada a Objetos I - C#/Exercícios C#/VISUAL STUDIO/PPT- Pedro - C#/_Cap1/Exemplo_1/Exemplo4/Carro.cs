using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo4
{
    internal class Carro
    {
        public string Modelo { get; set; }
        public string Cor { get; set; }
        private int _velocidadeAtual; // campo privado

        // Construtor = linha de montagem
        public Carro(string modelo, string cor)
        {
            Modelo = modelo;
            Cor = cor;
            _velocidadeAtual = 0;
        }

        // Método = comportamento do modelo
        public void Acelerar(int valor)
        {
            _velocidadeAtual += valor;
            Console.WriteLine($"{Modelo} acelerou para {_velocidadeAtual} km/h");
        }
    }
}
