using System;
namespace Exemplo_2
{
    // Struct = apenas estrutura de dados (sem foco em métodos)
    struct Pessoa
    {
        public string Nome;
        public int Idade;
    }
    class Program
    {
        // Função procedural que recebe a struct
        static void Apresentar(Pessoa pessoa)
        {
            Console.WriteLine($"Olá, sou {pessoa.Nome} e tenho 		{pessoa.Idade} anos");
        }
        static void Main()
        {
            // Criando uma pessoa com struct (sem new obrigatório)
            Pessoa pessoa1;
            pessoa1.Nome = "Ana";
            pessoa1.Idade = 30;
            // Chamando a função procedural
            Apresentar(pessoa1);
        }
    }
}

