using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
  public  class Pessoa
    {
        public string nomePessoa;
        public int idade;
        public string email;
        public string sexo;

        public Pessoa()
        {
            nomePessoa = "";
            idade = 0;
            email = "";
            sexo = "";
        }           
        public void exibeDados()
        {
            //
        }
    }
}
