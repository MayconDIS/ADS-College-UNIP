using System;
using System.Collections.Generic;
using System.Text;

namespace aula1
{
    internal class Pessoa
    {
        public string _nome;
        public int _idade;
        public int _cpf;
        public int _valid_cpf;
        public DateOnly _dataNascimento;


        public Pessoa() { } 
        public Pessoa(string nome, int idade,int cpf, int valid_cpf)
        {
            _nome = nome;
            _idade = idade;
            _cpf = cpf;
            _valid_cpf = valid_cpf;

        }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, sou {_nome} e tenho {_idade} anos");
            Console.WriteLine($"CPF: {_cpf}-{_valid_cpf} ");
        }
        public void Idade(DateOnly date)
        {
            int idade = dateNow - date;
            Console.WriteLine(" Idade = "+idade);

        }
    }
}
