using System;
using static System.Console;


namespace ProjetoAnimal
{
     class Ave: Animal
    {
        private string corPena;
        public void Locomover()
        {
            WriteLine("Voando"); 
        }
        public void Alimentar()
        {
            WriteLine("Comendo frutas");
        }
        public void EmitirSom()
        {
            throw new NotImplementedException();
        }
        public void SetCorPena( string newCorPena)
        {
            corPena = newCorPena;
        }
        public string GetCorPena()
        {
            return corPena;
        }
    }
}
