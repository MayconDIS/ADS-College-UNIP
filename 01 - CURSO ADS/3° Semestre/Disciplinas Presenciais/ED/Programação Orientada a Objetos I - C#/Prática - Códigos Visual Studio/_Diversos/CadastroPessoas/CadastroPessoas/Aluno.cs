using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    class Aluno : Pessoa
    {
        public int numMatricula;
        public string curso;

        public Aluno()
        {
            numMatricula = 0;
            curso = "";
        }
        public void atualizaCurso(string cursoNovo)
        {
            curso = cursoNovo;
        }
        public void apagaMatricula()
        {
            numMatricula = 0;
        }
    }
}
