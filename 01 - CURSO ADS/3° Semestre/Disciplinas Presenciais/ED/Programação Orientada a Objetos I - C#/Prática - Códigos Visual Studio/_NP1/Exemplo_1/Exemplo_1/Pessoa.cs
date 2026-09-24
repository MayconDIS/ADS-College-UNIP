using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_1
{
    internal class Pessoa
    {
        private string _nome;
        private int _idade;

        // Construtor = inicialização
        public Pessoa(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        // Método (comportamento)
        public void Apresentar()
        {
            Console.WriteLine($"Olá, sou {_nome} e tenho {_idade} anos");
        }

    }
}
