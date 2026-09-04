using System;
using static System.Console;

namespace ProjetoAnimal
{
    class Mamifero: Animal
    {
        private string corPelo;
        public void Locomover()
        {
            WriteLine("Correndo");
        }
        public void Alimentar()
        {
            WriteLine("Mamando");
        }
        public void EmitirSom()
        {
            WriteLine("Som de mamífero");
        }

    }
}
