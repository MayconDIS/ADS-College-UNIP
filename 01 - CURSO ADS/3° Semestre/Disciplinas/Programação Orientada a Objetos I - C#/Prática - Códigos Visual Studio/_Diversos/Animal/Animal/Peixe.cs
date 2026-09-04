using System;
using static System.Console;

namespace ProjetoAnimal
{
    class Peixe: Animal
    {
        private string corEscama;
        public void Locomover()
        {
            WriteLine("Nadando");
        }
        public void Alimentar()
        {
            WriteLine("Comendo algo");
        }
        public void EmitirSom()
        {
            WriteLine("Não emite som");
        }
    }
}
