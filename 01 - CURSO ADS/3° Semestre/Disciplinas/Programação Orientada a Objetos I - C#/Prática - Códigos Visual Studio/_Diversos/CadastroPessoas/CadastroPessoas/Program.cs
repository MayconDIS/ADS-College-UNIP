using System;

namespace CadastroPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno objAluno = new Aluno();
            objAluno.nomePessoa = "João Lucas";
            objAluno.idade = 36;
            objAluno.sexo = "Masculino";
            objAluno.numMatricula = 2345;
            objAluno.curso = "ADS";
            Console.WriteLine("Nome: " + objAluno.nomePessoa +
                " Idade: "+ objAluno.idade+
                " Sexo: "+objAluno.sexo);
            Console.WriteLine("Número Matrícula: " + objAluno.numMatricula +
                " Curso: " + objAluno.curso);
            Console.WriteLine();

            Professor objProfessor = new Professor();
            objProfessor.nomePessoa = "Pedro Carlos";
            objProfessor.idade = 51;
            objProfessor.email = "email@unip.br";
            objProfessor.sexo = "Masculino";
            Console.WriteLine("Nome: " + objProfessor.nomePessoa +
                " Idade: " + objProfessor.idade +
                " Sexo: " + objProfessor.sexo);
            objProfessor.salario = 1000.00;
            objProfessor.disciplina = "POO";
            Console.WriteLine("Valor Salario: " + objProfessor.salario +
                " Curso: " + objProfessor.disciplina);
            Console.WriteLine();
            Console.WriteLine("");

            Console.WriteLine("pressione uma tecla");
            Console.Read();
        }
    }
}
