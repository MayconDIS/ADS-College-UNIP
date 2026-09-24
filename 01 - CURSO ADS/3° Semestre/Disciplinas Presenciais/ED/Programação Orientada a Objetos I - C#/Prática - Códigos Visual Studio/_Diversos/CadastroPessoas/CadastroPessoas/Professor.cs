using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    class Professor : Pessoa
    {
        public double salario;
        public string disciplina;
        public Professor()
        {
            salario = 0.0;
            disciplina = "";
        }
    }
}
