using System;
using static System.Console;

namespace ProjetoAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("#### AVE ####");
            Ave a = new Ave();
            a.SetPeso (32.4);
            a.SetIdade(23);
            a.SetMembro(2);
            a.SetCorPena("Amarela");
            WriteLine("Peso:" + a.GetPeso());
            WriteLine("Idade:" + a.GetIdade());
            WriteLine("Membros:" + a.GetMembro());
            WriteLine("Cor da Pena:" + a.GetCorPena());
            a.Locomover();
            a.Alimentar();
            
            WriteLine("\n#### MAMÍFERO ####");
            Mamifero m = new Mamifero();
            m.SetPeso(120.5);
            m.SetIdade(51);
            m.SetMembro(4);
            WriteLine("Peso:" + m.GetPeso());
            WriteLine("Idade:" + m.GetIdade());
            WriteLine("Membros::" + m.GetMembro());
            m.Locomover();
            m.Alimentar();
            m.EmitirSom();

            WriteLine("\n#### PEIXE ####");
            Peixe p = new Peixe();
            p.SetPeso(0.4);
            p.SetIdade(2);
            p.SetMembro(0);
            WriteLine("\nPeso:" + p.GetPeso());
            WriteLine("Idade:" + p.GetIdade());
            WriteLine("Membros::" + p.GetMembro());
            p.Locomover();
            p.Alimentar();
            p.EmitirSom();

            ReadKey();
        }
    }
}
