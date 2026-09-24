using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAnimal
{
    public abstract class Animal
    {
        protected double peso;
        protected int idade;
        protected int membro;
        private void Locomover()
        {
        }
        public void Alimentar()
        {
        }
        public void EmitirSom()
        {
        }
        public double GetPeso()
        {
            return peso;
        }
        public double GetIdade()
        {
            return idade;
        }
        public double GetMembro()
        {
            return membro;
        }
        public void SetPeso( double newPeso)
        {
            peso = newPeso;
         }
        public void SetIdade(int newIdade)
        {
            idade = newIdade;
            
        }
        public void SetMembro(int newMembro)
        {
            membro = newMembro;           
        }
    }
}
