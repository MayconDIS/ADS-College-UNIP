
using System;

namespace Exemplo_2

{
    class Program
    {
        // Função procedural que faz o papel do método Apresentar()
        static void Apresentar(string nome, int idade)
        {
            Console.WriteLine($"Olá, sou {nome} e tenho {idade} anos");
        }

        static void Main()
        {
            // Variáveis no lugar do objeto
            string nome = "Ana";
            int idade = 30;

            // Chamando a função diretamente
            Apresentar(nome, idade);
        }
    }
}